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
    public interface ICodeScanningApi
    {
        /// <summary>
        /// Delete a code scanning analysis from a repository Deletes a specified code scanning analysis from a repository. For private repositories, you must use an access token with the &#x60;repo&#x60; scope. For public repositories, you must use an access token with &#x60;public_repo&#x60; scope. GitHub Apps must have the &#x60;security_events&#x60; write permission to use this endpoint.  You can delete one analysis at a time. To delete a series of analyses, start with the most recent analysis and work backwards. Conceptually, the process is similar to the undo function in a text editor.  When you list the analyses for a repository, one or more will be identified as deletable in the response:  &#x60;&#x60;&#x60; \&quot;deletable\&quot;: true &#x60;&#x60;&#x60;  An analysis is deletable when it&#39;s the most recent in a set of analyses. Typically, a repository will have multiple sets of analyses for each enabled code scanning tool, where a set is determined by a unique combination of analysis values:  * &#x60;ref&#x60; * &#x60;tool&#x60; * &#x60;analysis_key&#x60; * &#x60;environment&#x60;  If you attempt to delete an analysis that is not the most recent in a set, you&#39;ll get a 400 response with the message:  &#x60;&#x60;&#x60; Analysis specified is not deletable. &#x60;&#x60;&#x60;  The response from a successful &#x60;DELETE&#x60; operation provides you with two alternative URLs for deleting the next analysis in the set: &#x60;next_analysis_url&#x60; and &#x60;confirm_delete_url&#x60;. Use the &#x60;next_analysis_url&#x60; URL if you want to avoid accidentally deleting the final analysis in a set. This is a useful option if you want to preserve at least one analysis for the specified tool in your repository. Use the &#x60;confirm_delete_url&#x60; URL if you are content to remove all analyses for a tool. When you delete the last analysis in a set, the value of &#x60;next_analysis_url&#x60; and &#x60;confirm_delete_url&#x60; in the 200 response is &#x60;null&#x60;.  As an example of the deletion process, let&#39;s imagine that you added a workflow that configured a particular code scanning tool to analyze the code in a repository. This tool has added 15 analyses: 10 on the default branch, and another 5 on a topic branch. You therefore have two separate sets of analyses for this tool. You&#39;ve now decided that you want to remove all of the analyses for the tool. To do this you must make 15 separate deletion requests. To start, you must find an analysis that&#39;s identified as deletable. Each set of analyses always has one that&#39;s identified as deletable. Having found the deletable analysis for one of the two sets, delete this analysis and then continue deleting the next analysis in the set until they&#39;re all deleted. Then repeat the process for the second set. The procedure therefore consists of a nested loop:  **Outer loop**: * List the analyses for the repository, filtered by tool. * Parse this list to find a deletable analysis. If found:    **Inner loop**:   * Delete the identified analysis.   * Parse the response for the value of &#x60;confirm_delete_url&#x60; and, if found, use this in the next iteration.  The above process assumes that you want to remove all trace of the tool&#39;s analyses from the GitHub user interface, for the specified repository, and it therefore uses the &#x60;confirm_delete_url&#x60; value. Alternatively, you could use the &#x60;next_analysis_url&#x60; value, which would leave the last analysis in each set undeleted to avoid removing a tool&#39;s analysis entirely.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="analysisId">The ID of the analysis, as returned from the &#x60;GET /repos/{owner}/{repo}/code-scanning/analyses&#x60; operation.</param>
        /// <param name="confirmDelete">Allow deletion if the specified analysis is the last in a set. If you attempt to delete the final analysis in a set without setting this parameter to &#x60;true&#x60;, you&#39;ll get a 400 response with the message: &#x60;Analysis is last of its type and deletion may result in the loss of historical alert data. Please specify confirm_delete.&#x60;</param>
        /// <returns>AnalysisDeletion</returns>
        AnalysisDeletion CodeScanningDeleteAnalysis (string owner, string repo, int? analysisId, string confirmDelete);
        /// <summary>
        /// Get a code scanning alert Gets a single code scanning alert. You must use an access token with the &#x60;security_events&#x60; scope to use this endpoint with private repos, the &#x60;public_repo&#x60; scope also grants permission to read security events on public repos only. GitHub Apps must have the &#x60;security_events&#x60; read permission to use this endpoint.  **Deprecation notice**: The instances field is deprecated and will, in future, not be included in the response for this endpoint. The example response reflects this change. The same information can now be retrieved via a GET request to the URL specified by &#x60;instances_url&#x60;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="alertNumber">The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the &#x60;number&#x60; field in the response from the &#x60;GET /repos/{owner}/{repo}/code-scanning/alerts&#x60; operation.</param>
        /// <returns>CodeScanningGetAlert200Response</returns>
        CodeScanningGetAlert200Response CodeScanningGetAlert (string owner, string repo, int? alertNumber);
        /// <summary>
        /// Get a code scanning analysis for a repository Gets a specified code scanning analysis for a repository. You must use an access token with the &#x60;security_events&#x60; scope to use this endpoint with private repos, the &#x60;public_repo&#x60; scope also grants permission to read security events on public repos only. GitHub Apps must have the &#x60;security_events&#x60; read permission to use this endpoint.  The default JSON response contains fields that describe the analysis. This includes the Git reference and commit SHA to which the analysis relates, the datetime of the analysis, the name of the code scanning tool, and the number of alerts.  The &#x60;rules_count&#x60; field in the default response give the number of rules that were run in the analysis. For very old analyses this data is not available, and &#x60;0&#x60; is returned in this field.  If you use the Accept header &#x60;application/sarif+json&#x60;, the response contains the analysis data that was uploaded. This is formatted as [SARIF version 2.1.0](https://docs.oasis-open.org/sarif/sarif/v2.1.0/cs01/sarif-v2.1.0-cs01.html).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="analysisId">The ID of the analysis, as returned from the &#x60;GET /repos/{owner}/{repo}/code-scanning/analyses&#x60; operation.</param>
        /// <returns>CodeScanningListRecentAnalyses200ResponseInner</returns>
        CodeScanningListRecentAnalyses200ResponseInner CodeScanningGetAnalysis (string owner, string repo, int? analysisId);
        /// <summary>
        /// Get information about a SARIF upload Gets information about a SARIF upload, including the status and the URL of the analysis that was uploaded so that you can retrieve details of the analysis. For more information, see \&quot;[Get a code scanning analysis for a repository](/rest/reference/code-scanning#get-a-code-scanning-analysis-for-a-repository).\&quot; You must use an access token with the &#x60;security_events&#x60; scope to use this endpoint with private repos, the &#x60;public_repo&#x60; scope also grants permission to read security events on public repos only. GitHub Apps must have the &#x60;security_events&#x60; read permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="sarifId">The SARIF ID obtained after uploading.</param>
        /// <returns>CodeScanningGetSarif200Response</returns>
        CodeScanningGetSarif200Response CodeScanningGetSarif (string owner, string repo, string sarifId);
        /// <summary>
        /// List instances of a code scanning alert Lists all instances of the specified code scanning alert. You must use an access token with the &#x60;security_events&#x60; scope to use this endpoint with private repos, the &#x60;public_repo&#x60; scope also grants permission to read security events on public repos only. GitHub Apps must have the &#x60;security_events&#x60; read permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="alertNumber">The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the &#x60;number&#x60; field in the response from the &#x60;GET /repos/{owner}/{repo}/code-scanning/alerts&#x60; operation.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="_ref">The Git reference for the results you want to list. The &#x60;ref&#x60; for a branch can be formatted either as &#x60;refs/heads/&lt;branch name&gt;&#x60; or simply &#x60;&lt;branch name&gt;&#x60;. To reference a pull request use &#x60;refs/pull/&lt;number&gt;/merge&#x60;.</param>
        /// <returns>List&lt;CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance&gt;</returns>
        List<CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance> CodeScanningListAlertInstances (string owner, string repo, int? alertNumber, int? page, int? perPage, string _ref);
        /// <summary>
        /// List code scanning alerts for an enterprise Lists code scanning alerts for the default branch for all eligible repositories in an enterprise. Eligible repositories are repositories that are owned by organizations that you own or for which you are a security manager. For more information, see \&quot;[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).\&quot;  To use this endpoint, you must be a member of the enterprise, and you must use an access token with the &#x60;repo&#x60; scope or &#x60;security_events&#x60; scope.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="toolName">The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either &#x60;tool_name&#x60; or &#x60;tool_guid&#x60;, but not both.</param>
        /// <param name="toolGuid">The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either &#x60;tool_guid&#x60; or &#x60;tool_name&#x60;, but not both.</param>
        /// <param name="before">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor.</param>
        /// <param name="after">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="state">If specified, only code scanning alerts with this state will be returned.</param>
        /// <param name="sort">The property by which to sort the results.</param>
        /// <returns>List&lt;CodeScanningListAlertsForEnterprise200ResponseInner&gt;</returns>
        List<CodeScanningListAlertsForEnterprise200ResponseInner> CodeScanningListAlertsForEnterprise (string enterprise, string toolName, string toolGuid, string before, string after, int? page, int? perPage, string direction, string state, string sort);
        /// <summary>
        /// List code scanning alerts for an organization Lists code scanning alerts for the default branch for all eligible repositories in an organization. Eligible repositories are repositories that are owned by organizations that you own or for which you are a security manager. For more information, see \&quot;[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).\&quot;  To use this endpoint, you must be an owner or security manager for the organization, and you must use an access token with the &#x60;repo&#x60; scope or &#x60;security_events&#x60; scope.  For public repositories, you may instead use the &#x60;public_repo&#x60; scope.  GitHub Apps must have the &#x60;security_events&#x60; read permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="toolName">The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either &#x60;tool_name&#x60; or &#x60;tool_guid&#x60;, but not both.</param>
        /// <param name="toolGuid">The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either &#x60;tool_guid&#x60; or &#x60;tool_name&#x60;, but not both.</param>
        /// <param name="before">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor.</param>
        /// <param name="after">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="state">If specified, only code scanning alerts with this state will be returned.</param>
        /// <param name="sort">The property by which to sort the results.</param>
        /// <returns>List&lt;CodeScanningListAlertsForEnterprise200ResponseInner&gt;</returns>
        List<CodeScanningListAlertsForEnterprise200ResponseInner> CodeScanningListAlertsForOrg (string org, string toolName, string toolGuid, string before, string after, int? page, int? perPage, string direction, string state, string sort);
        /// <summary>
        /// List code scanning alerts for a repository Lists code scanning alerts.  To use this endpoint, you must use an access token with the &#x60;security_events&#x60; scope or, for alerts from public repositories only, an access token with the &#x60;public_repo&#x60; scope.  GitHub Apps must have the &#x60;security_events&#x60; read permission to use this endpoint.  The response includes a &#x60;most_recent_instance&#x60; object. This provides details of the most recent instance of this alert for the default branch (or for the specified Git reference if you used &#x60;ref&#x60; in the request).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="toolName">The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either &#x60;tool_name&#x60; or &#x60;tool_guid&#x60;, but not both.</param>
        /// <param name="toolGuid">The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either &#x60;tool_guid&#x60; or &#x60;tool_name&#x60;, but not both.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="_ref">The Git reference for the results you want to list. The &#x60;ref&#x60; for a branch can be formatted either as &#x60;refs/heads/&lt;branch name&gt;&#x60; or simply &#x60;&lt;branch name&gt;&#x60;. To reference a pull request use &#x60;refs/pull/&lt;number&gt;/merge&#x60;.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="sort">The property by which to sort the results.</param>
        /// <param name="state">If specified, only code scanning alerts with this state will be returned.</param>
        /// <returns>List&lt;CodeScanningListAlertsForRepo200ResponseInner&gt;</returns>
        List<CodeScanningListAlertsForRepo200ResponseInner> CodeScanningListAlertsForRepo (string owner, string repo, string toolName, string toolGuid, int? page, int? perPage, string _ref, string direction, string sort, string state);
        /// <summary>
        /// List code scanning analyses for a repository Lists the details of all code scanning analyses for a repository, starting with the most recent. The response is paginated and you can use the &#x60;page&#x60; and &#x60;per_page&#x60; parameters to list the analyses you&#39;re interested in. By default 30 analyses are listed per page.  The &#x60;rules_count&#x60; field in the response give the number of rules that were run in the analysis. For very old analyses this data is not available, and &#x60;0&#x60; is returned in this field.  You must use an access token with the &#x60;security_events&#x60; scope to use this endpoint with private repos, the &#x60;public_repo&#x60; scope also grants permission to read security events on public repos only. GitHub Apps must have the &#x60;security_events&#x60; read permission to use this endpoint.  **Deprecation notice**: The &#x60;tool_name&#x60; field is deprecated and will, in future, not be included in the response for this endpoint. The example response reflects this change. The tool name can now be found inside the &#x60;tool&#x60; field.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="toolName">The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either &#x60;tool_name&#x60; or &#x60;tool_guid&#x60;, but not both.</param>
        /// <param name="toolGuid">The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either &#x60;tool_guid&#x60; or &#x60;tool_name&#x60;, but not both.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="_ref">The Git reference for the analyses you want to list. The &#x60;ref&#x60; for a branch can be formatted either as &#x60;refs/heads/&lt;branch name&gt;&#x60; or simply &#x60;&lt;branch name&gt;&#x60;. To reference a pull request use &#x60;refs/pull/&lt;number&gt;/merge&#x60;.</param>
        /// <param name="sarifId">Filter analyses belonging to the same SARIF upload.</param>
        /// <returns>List&lt;CodeScanningListRecentAnalyses200ResponseInner&gt;</returns>
        List<CodeScanningListRecentAnalyses200ResponseInner> CodeScanningListRecentAnalyses (string owner, string repo, string toolName, string toolGuid, int? page, int? perPage, string _ref, string sarifId);
        /// <summary>
        /// Update a code scanning alert Updates the status of a single code scanning alert. You must use an access token with the &#x60;security_events&#x60; scope to use this endpoint with private repositories. You can also use tokens with the &#x60;public_repo&#x60; scope for public repositories only. GitHub Apps must have the &#x60;security_events&#x60; write permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="alertNumber">The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the &#x60;number&#x60; field in the response from the &#x60;GET /repos/{owner}/{repo}/code-scanning/alerts&#x60; operation.</param>
        /// <param name="codeScanningUpdateAlertRequest"></param>
        /// <returns>CodeScanningGetAlert200Response</returns>
        CodeScanningGetAlert200Response CodeScanningUpdateAlert (string owner, string repo, int? alertNumber, CodeScanningUpdateAlertRequest codeScanningUpdateAlertRequest);
        /// <summary>
        /// Upload an analysis as SARIF data Uploads SARIF data containing the results of a code scanning analysis to make the results available in a repository. You must use an access token with the &#x60;security_events&#x60; scope to use this endpoint for private repositories. You can also use tokens with the &#x60;public_repo&#x60; scope for public repositories only. GitHub Apps must have the &#x60;security_events&#x60; write permission to use this endpoint.  There are two places where you can upload code scanning results.  - If you upload to a pull request, for example &#x60;- -ref refs/pull/42/merge&#x60; or &#x60;- -ref refs/pull/42/head&#x60;, then the results appear as alerts in a pull request check. For more information, see \&quot;[Triaging code scanning alerts in pull requests](/code-security/secure-coding/triaging-code-scanning-alerts-in-pull-requests).\&quot;  - If you upload to a branch, for example &#x60;- -ref refs/heads/my-branch&#x60;, then the results appear in the **Security** tab for your repository. For more information, see \&quot;[Managing code scanning alerts for your repository](/code-security/secure-coding/managing-code-scanning-alerts-for-your-repository#viewing-the-alerts-for-a-repository).\&quot;  You must compress the SARIF-formatted analysis data that you want to upload, using &#x60;gzip&#x60;, and then encode it as a Base64 format string. For example:  &#x60;&#x60;&#x60; gzip -c analysis-data.sarif | base64 -w0 &#x60;&#x60;&#x60;  SARIF upload supports a maximum of 5000 results per analysis run. Any results over this limit are ignored and any SARIF uploads with more than 25,000 results are rejected. Typically, but not necessarily, a SARIF file contains a single run of a single tool. If a code scanning tool generates too many results, you should update the analysis configuration to run only the most important rules or queries.  The &#x60;202 Accepted&#x60;, response includes an &#x60;id&#x60; value. You can use this ID to check the status of the upload by using this for the &#x60;/sarifs/{sarif_id}&#x60; endpoint. For more information, see \&quot;[Get information about a SARIF upload](/rest/reference/code-scanning#get-information-about-a-sarif-upload).\&quot;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="codeScanningUploadSarifRequest"></param>
        /// <returns>CodeScanningUploadSarif202Response</returns>
        CodeScanningUploadSarif202Response CodeScanningUploadSarif (string owner, string repo, CodeScanningUploadSarifRequest codeScanningUploadSarifRequest);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CodeScanningApi : ICodeScanningApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CodeScanningApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CodeScanningApi(String basePath)
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
        /// Delete a code scanning analysis from a repository Deletes a specified code scanning analysis from a repository. For private repositories, you must use an access token with the &#x60;repo&#x60; scope. For public repositories, you must use an access token with &#x60;public_repo&#x60; scope. GitHub Apps must have the &#x60;security_events&#x60; write permission to use this endpoint.  You can delete one analysis at a time. To delete a series of analyses, start with the most recent analysis and work backwards. Conceptually, the process is similar to the undo function in a text editor.  When you list the analyses for a repository, one or more will be identified as deletable in the response:  &#x60;&#x60;&#x60; \&quot;deletable\&quot;: true &#x60;&#x60;&#x60;  An analysis is deletable when it&#39;s the most recent in a set of analyses. Typically, a repository will have multiple sets of analyses for each enabled code scanning tool, where a set is determined by a unique combination of analysis values:  * &#x60;ref&#x60; * &#x60;tool&#x60; * &#x60;analysis_key&#x60; * &#x60;environment&#x60;  If you attempt to delete an analysis that is not the most recent in a set, you&#39;ll get a 400 response with the message:  &#x60;&#x60;&#x60; Analysis specified is not deletable. &#x60;&#x60;&#x60;  The response from a successful &#x60;DELETE&#x60; operation provides you with two alternative URLs for deleting the next analysis in the set: &#x60;next_analysis_url&#x60; and &#x60;confirm_delete_url&#x60;. Use the &#x60;next_analysis_url&#x60; URL if you want to avoid accidentally deleting the final analysis in a set. This is a useful option if you want to preserve at least one analysis for the specified tool in your repository. Use the &#x60;confirm_delete_url&#x60; URL if you are content to remove all analyses for a tool. When you delete the last analysis in a set, the value of &#x60;next_analysis_url&#x60; and &#x60;confirm_delete_url&#x60; in the 200 response is &#x60;null&#x60;.  As an example of the deletion process, let&#39;s imagine that you added a workflow that configured a particular code scanning tool to analyze the code in a repository. This tool has added 15 analyses: 10 on the default branch, and another 5 on a topic branch. You therefore have two separate sets of analyses for this tool. You&#39;ve now decided that you want to remove all of the analyses for the tool. To do this you must make 15 separate deletion requests. To start, you must find an analysis that&#39;s identified as deletable. Each set of analyses always has one that&#39;s identified as deletable. Having found the deletable analysis for one of the two sets, delete this analysis and then continue deleting the next analysis in the set until they&#39;re all deleted. Then repeat the process for the second set. The procedure therefore consists of a nested loop:  **Outer loop**: * List the analyses for the repository, filtered by tool. * Parse this list to find a deletable analysis. If found:    **Inner loop**:   * Delete the identified analysis.   * Parse the response for the value of &#x60;confirm_delete_url&#x60; and, if found, use this in the next iteration.  The above process assumes that you want to remove all trace of the tool&#39;s analyses from the GitHub user interface, for the specified repository, and it therefore uses the &#x60;confirm_delete_url&#x60; value. Alternatively, you could use the &#x60;next_analysis_url&#x60; value, which would leave the last analysis in each set undeleted to avoid removing a tool&#39;s analysis entirely.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="analysisId">The ID of the analysis, as returned from the &#x60;GET /repos/{owner}/{repo}/code-scanning/analyses&#x60; operation.</param>
        /// <param name="confirmDelete">Allow deletion if the specified analysis is the last in a set. If you attempt to delete the final analysis in a set without setting this parameter to &#x60;true&#x60;, you&#39;ll get a 400 response with the message: &#x60;Analysis is last of its type and deletion may result in the loss of historical alert data. Please specify confirm_delete.&#x60;</param>
        /// <returns>AnalysisDeletion</returns>
        public AnalysisDeletion CodeScanningDeleteAnalysis (string owner, string repo, int? analysisId, string confirmDelete)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling CodeScanningDeleteAnalysis");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling CodeScanningDeleteAnalysis");
            
            // verify the required parameter 'analysisId' is set
            if (analysisId == null) throw new ApiException(400, "Missing required parameter 'analysisId' when calling CodeScanningDeleteAnalysis");
            

            var path = "/repos/{owner}/{repo}/code-scanning/analyses/{analysis_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "analysis_id" + "}", ApiClient.ParameterToString(analysisId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (confirmDelete != null) queryParams.Add("confirm_delete", ApiClient.ParameterToString(confirmDelete)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningDeleteAnalysis: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningDeleteAnalysis: " + response.ErrorMessage, response.ErrorMessage);

            return (AnalysisDeletion) ApiClient.Deserialize(response.Content, typeof(AnalysisDeletion), response.Headers);
        }

        /// <summary>
        /// Get a code scanning alert Gets a single code scanning alert. You must use an access token with the &#x60;security_events&#x60; scope to use this endpoint with private repos, the &#x60;public_repo&#x60; scope also grants permission to read security events on public repos only. GitHub Apps must have the &#x60;security_events&#x60; read permission to use this endpoint.  **Deprecation notice**: The instances field is deprecated and will, in future, not be included in the response for this endpoint. The example response reflects this change. The same information can now be retrieved via a GET request to the URL specified by &#x60;instances_url&#x60;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="alertNumber">The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the &#x60;number&#x60; field in the response from the &#x60;GET /repos/{owner}/{repo}/code-scanning/alerts&#x60; operation.</param>
        /// <returns>CodeScanningGetAlert200Response</returns>
        public CodeScanningGetAlert200Response CodeScanningGetAlert (string owner, string repo, int? alertNumber)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling CodeScanningGetAlert");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling CodeScanningGetAlert");
            
            // verify the required parameter 'alertNumber' is set
            if (alertNumber == null) throw new ApiException(400, "Missing required parameter 'alertNumber' when calling CodeScanningGetAlert");
            

            var path = "/repos/{owner}/{repo}/code-scanning/alerts/{alert_number}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningGetAlert: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningGetAlert: " + response.ErrorMessage, response.ErrorMessage);

            return (CodeScanningGetAlert200Response) ApiClient.Deserialize(response.Content, typeof(CodeScanningGetAlert200Response), response.Headers);
        }

        /// <summary>
        /// Get a code scanning analysis for a repository Gets a specified code scanning analysis for a repository. You must use an access token with the &#x60;security_events&#x60; scope to use this endpoint with private repos, the &#x60;public_repo&#x60; scope also grants permission to read security events on public repos only. GitHub Apps must have the &#x60;security_events&#x60; read permission to use this endpoint.  The default JSON response contains fields that describe the analysis. This includes the Git reference and commit SHA to which the analysis relates, the datetime of the analysis, the name of the code scanning tool, and the number of alerts.  The &#x60;rules_count&#x60; field in the default response give the number of rules that were run in the analysis. For very old analyses this data is not available, and &#x60;0&#x60; is returned in this field.  If you use the Accept header &#x60;application/sarif+json&#x60;, the response contains the analysis data that was uploaded. This is formatted as [SARIF version 2.1.0](https://docs.oasis-open.org/sarif/sarif/v2.1.0/cs01/sarif-v2.1.0-cs01.html).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="analysisId">The ID of the analysis, as returned from the &#x60;GET /repos/{owner}/{repo}/code-scanning/analyses&#x60; operation.</param>
        /// <returns>CodeScanningListRecentAnalyses200ResponseInner</returns>
        public CodeScanningListRecentAnalyses200ResponseInner CodeScanningGetAnalysis (string owner, string repo, int? analysisId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling CodeScanningGetAnalysis");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling CodeScanningGetAnalysis");
            
            // verify the required parameter 'analysisId' is set
            if (analysisId == null) throw new ApiException(400, "Missing required parameter 'analysisId' when calling CodeScanningGetAnalysis");
            

            var path = "/repos/{owner}/{repo}/code-scanning/analyses/{analysis_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "analysis_id" + "}", ApiClient.ParameterToString(analysisId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningGetAnalysis: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningGetAnalysis: " + response.ErrorMessage, response.ErrorMessage);

            return (CodeScanningListRecentAnalyses200ResponseInner) ApiClient.Deserialize(response.Content, typeof(CodeScanningListRecentAnalyses200ResponseInner), response.Headers);
        }

        /// <summary>
        /// Get information about a SARIF upload Gets information about a SARIF upload, including the status and the URL of the analysis that was uploaded so that you can retrieve details of the analysis. For more information, see \&quot;[Get a code scanning analysis for a repository](/rest/reference/code-scanning#get-a-code-scanning-analysis-for-a-repository).\&quot; You must use an access token with the &#x60;security_events&#x60; scope to use this endpoint with private repos, the &#x60;public_repo&#x60; scope also grants permission to read security events on public repos only. GitHub Apps must have the &#x60;security_events&#x60; read permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="sarifId">The SARIF ID obtained after uploading.</param>
        /// <returns>CodeScanningGetSarif200Response</returns>
        public CodeScanningGetSarif200Response CodeScanningGetSarif (string owner, string repo, string sarifId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling CodeScanningGetSarif");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling CodeScanningGetSarif");
            
            // verify the required parameter 'sarifId' is set
            if (sarifId == null) throw new ApiException(400, "Missing required parameter 'sarifId' when calling CodeScanningGetSarif");
            

            var path = "/repos/{owner}/{repo}/code-scanning/sarifs/{sarif_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "sarif_id" + "}", ApiClient.ParameterToString(sarifId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningGetSarif: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningGetSarif: " + response.ErrorMessage, response.ErrorMessage);

            return (CodeScanningGetSarif200Response) ApiClient.Deserialize(response.Content, typeof(CodeScanningGetSarif200Response), response.Headers);
        }

        /// <summary>
        /// List instances of a code scanning alert Lists all instances of the specified code scanning alert. You must use an access token with the &#x60;security_events&#x60; scope to use this endpoint with private repos, the &#x60;public_repo&#x60; scope also grants permission to read security events on public repos only. GitHub Apps must have the &#x60;security_events&#x60; read permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="alertNumber">The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the &#x60;number&#x60; field in the response from the &#x60;GET /repos/{owner}/{repo}/code-scanning/alerts&#x60; operation.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="_ref">The Git reference for the results you want to list. The &#x60;ref&#x60; for a branch can be formatted either as &#x60;refs/heads/&lt;branch name&gt;&#x60; or simply &#x60;&lt;branch name&gt;&#x60;. To reference a pull request use &#x60;refs/pull/&lt;number&gt;/merge&#x60;.</param>
        /// <returns>List&lt;CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance&gt;</returns>
        public List<CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance> CodeScanningListAlertInstances (string owner, string repo, int? alertNumber, int? page, int? perPage, string _ref)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling CodeScanningListAlertInstances");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling CodeScanningListAlertInstances");
            
            // verify the required parameter 'alertNumber' is set
            if (alertNumber == null) throw new ApiException(400, "Missing required parameter 'alertNumber' when calling CodeScanningListAlertInstances");
            

            var path = "/repos/{owner}/{repo}/code-scanning/alerts/{alert_number}/instances";
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
 if (_ref != null) queryParams.Add("ref", ApiClient.ParameterToString(_ref)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningListAlertInstances: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningListAlertInstances: " + response.ErrorMessage, response.ErrorMessage);

            return (List<CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance>) ApiClient.Deserialize(response.Content, typeof(List<CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance>), response.Headers);
        }

        /// <summary>
        /// List code scanning alerts for an enterprise Lists code scanning alerts for the default branch for all eligible repositories in an enterprise. Eligible repositories are repositories that are owned by organizations that you own or for which you are a security manager. For more information, see \&quot;[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).\&quot;  To use this endpoint, you must be a member of the enterprise, and you must use an access token with the &#x60;repo&#x60; scope or &#x60;security_events&#x60; scope.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="toolName">The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either &#x60;tool_name&#x60; or &#x60;tool_guid&#x60;, but not both.</param>
        /// <param name="toolGuid">The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either &#x60;tool_guid&#x60; or &#x60;tool_name&#x60;, but not both.</param>
        /// <param name="before">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor.</param>
        /// <param name="after">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="state">If specified, only code scanning alerts with this state will be returned.</param>
        /// <param name="sort">The property by which to sort the results.</param>
        /// <returns>List&lt;CodeScanningListAlertsForEnterprise200ResponseInner&gt;</returns>
        public List<CodeScanningListAlertsForEnterprise200ResponseInner> CodeScanningListAlertsForEnterprise (string enterprise, string toolName, string toolGuid, string before, string after, int? page, int? perPage, string direction, string state, string sort)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling CodeScanningListAlertsForEnterprise");
            

            var path = "/enterprises/{enterprise}/code-scanning/alerts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (toolName != null) queryParams.Add("tool_name", ApiClient.ParameterToString(toolName)); // query parameter
 if (toolGuid != null) queryParams.Add("tool_guid", ApiClient.ParameterToString(toolGuid)); // query parameter
 if (before != null) queryParams.Add("before", ApiClient.ParameterToString(before)); // query parameter
 if (after != null) queryParams.Add("after", ApiClient.ParameterToString(after)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningListAlertsForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningListAlertsForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (List<CodeScanningListAlertsForEnterprise200ResponseInner>) ApiClient.Deserialize(response.Content, typeof(List<CodeScanningListAlertsForEnterprise200ResponseInner>), response.Headers);
        }

        /// <summary>
        /// List code scanning alerts for an organization Lists code scanning alerts for the default branch for all eligible repositories in an organization. Eligible repositories are repositories that are owned by organizations that you own or for which you are a security manager. For more information, see \&quot;[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).\&quot;  To use this endpoint, you must be an owner or security manager for the organization, and you must use an access token with the &#x60;repo&#x60; scope or &#x60;security_events&#x60; scope.  For public repositories, you may instead use the &#x60;public_repo&#x60; scope.  GitHub Apps must have the &#x60;security_events&#x60; read permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="toolName">The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either &#x60;tool_name&#x60; or &#x60;tool_guid&#x60;, but not both.</param>
        /// <param name="toolGuid">The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either &#x60;tool_guid&#x60; or &#x60;tool_name&#x60;, but not both.</param>
        /// <param name="before">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor.</param>
        /// <param name="after">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="state">If specified, only code scanning alerts with this state will be returned.</param>
        /// <param name="sort">The property by which to sort the results.</param>
        /// <returns>List&lt;CodeScanningListAlertsForEnterprise200ResponseInner&gt;</returns>
        public List<CodeScanningListAlertsForEnterprise200ResponseInner> CodeScanningListAlertsForOrg (string org, string toolName, string toolGuid, string before, string after, int? page, int? perPage, string direction, string state, string sort)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling CodeScanningListAlertsForOrg");
            

            var path = "/orgs/{org}/code-scanning/alerts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (toolName != null) queryParams.Add("tool_name", ApiClient.ParameterToString(toolName)); // query parameter
 if (toolGuid != null) queryParams.Add("tool_guid", ApiClient.ParameterToString(toolGuid)); // query parameter
 if (before != null) queryParams.Add("before", ApiClient.ParameterToString(before)); // query parameter
 if (after != null) queryParams.Add("after", ApiClient.ParameterToString(after)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningListAlertsForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningListAlertsForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (List<CodeScanningListAlertsForEnterprise200ResponseInner>) ApiClient.Deserialize(response.Content, typeof(List<CodeScanningListAlertsForEnterprise200ResponseInner>), response.Headers);
        }

        /// <summary>
        /// List code scanning alerts for a repository Lists code scanning alerts.  To use this endpoint, you must use an access token with the &#x60;security_events&#x60; scope or, for alerts from public repositories only, an access token with the &#x60;public_repo&#x60; scope.  GitHub Apps must have the &#x60;security_events&#x60; read permission to use this endpoint.  The response includes a &#x60;most_recent_instance&#x60; object. This provides details of the most recent instance of this alert for the default branch (or for the specified Git reference if you used &#x60;ref&#x60; in the request).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="toolName">The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either &#x60;tool_name&#x60; or &#x60;tool_guid&#x60;, but not both.</param>
        /// <param name="toolGuid">The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either &#x60;tool_guid&#x60; or &#x60;tool_name&#x60;, but not both.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="_ref">The Git reference for the results you want to list. The &#x60;ref&#x60; for a branch can be formatted either as &#x60;refs/heads/&lt;branch name&gt;&#x60; or simply &#x60;&lt;branch name&gt;&#x60;. To reference a pull request use &#x60;refs/pull/&lt;number&gt;/merge&#x60;.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="sort">The property by which to sort the results.</param>
        /// <param name="state">If specified, only code scanning alerts with this state will be returned.</param>
        /// <returns>List&lt;CodeScanningListAlertsForRepo200ResponseInner&gt;</returns>
        public List<CodeScanningListAlertsForRepo200ResponseInner> CodeScanningListAlertsForRepo (string owner, string repo, string toolName, string toolGuid, int? page, int? perPage, string _ref, string direction, string sort, string state)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling CodeScanningListAlertsForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling CodeScanningListAlertsForRepo");
            

            var path = "/repos/{owner}/{repo}/code-scanning/alerts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (toolName != null) queryParams.Add("tool_name", ApiClient.ParameterToString(toolName)); // query parameter
 if (toolGuid != null) queryParams.Add("tool_guid", ApiClient.ParameterToString(toolGuid)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (_ref != null) queryParams.Add("ref", ApiClient.ParameterToString(_ref)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningListAlertsForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningListAlertsForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (List<CodeScanningListAlertsForRepo200ResponseInner>) ApiClient.Deserialize(response.Content, typeof(List<CodeScanningListAlertsForRepo200ResponseInner>), response.Headers);
        }

        /// <summary>
        /// List code scanning analyses for a repository Lists the details of all code scanning analyses for a repository, starting with the most recent. The response is paginated and you can use the &#x60;page&#x60; and &#x60;per_page&#x60; parameters to list the analyses you&#39;re interested in. By default 30 analyses are listed per page.  The &#x60;rules_count&#x60; field in the response give the number of rules that were run in the analysis. For very old analyses this data is not available, and &#x60;0&#x60; is returned in this field.  You must use an access token with the &#x60;security_events&#x60; scope to use this endpoint with private repos, the &#x60;public_repo&#x60; scope also grants permission to read security events on public repos only. GitHub Apps must have the &#x60;security_events&#x60; read permission to use this endpoint.  **Deprecation notice**: The &#x60;tool_name&#x60; field is deprecated and will, in future, not be included in the response for this endpoint. The example response reflects this change. The tool name can now be found inside the &#x60;tool&#x60; field.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="toolName">The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either &#x60;tool_name&#x60; or &#x60;tool_guid&#x60;, but not both.</param>
        /// <param name="toolGuid">The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either &#x60;tool_guid&#x60; or &#x60;tool_name&#x60;, but not both.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="_ref">The Git reference for the analyses you want to list. The &#x60;ref&#x60; for a branch can be formatted either as &#x60;refs/heads/&lt;branch name&gt;&#x60; or simply &#x60;&lt;branch name&gt;&#x60;. To reference a pull request use &#x60;refs/pull/&lt;number&gt;/merge&#x60;.</param>
        /// <param name="sarifId">Filter analyses belonging to the same SARIF upload.</param>
        /// <returns>List&lt;CodeScanningListRecentAnalyses200ResponseInner&gt;</returns>
        public List<CodeScanningListRecentAnalyses200ResponseInner> CodeScanningListRecentAnalyses (string owner, string repo, string toolName, string toolGuid, int? page, int? perPage, string _ref, string sarifId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling CodeScanningListRecentAnalyses");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling CodeScanningListRecentAnalyses");
            

            var path = "/repos/{owner}/{repo}/code-scanning/analyses";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (toolName != null) queryParams.Add("tool_name", ApiClient.ParameterToString(toolName)); // query parameter
 if (toolGuid != null) queryParams.Add("tool_guid", ApiClient.ParameterToString(toolGuid)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (_ref != null) queryParams.Add("ref", ApiClient.ParameterToString(_ref)); // query parameter
 if (sarifId != null) queryParams.Add("sarif_id", ApiClient.ParameterToString(sarifId)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningListRecentAnalyses: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningListRecentAnalyses: " + response.ErrorMessage, response.ErrorMessage);

            return (List<CodeScanningListRecentAnalyses200ResponseInner>) ApiClient.Deserialize(response.Content, typeof(List<CodeScanningListRecentAnalyses200ResponseInner>), response.Headers);
        }

        /// <summary>
        /// Update a code scanning alert Updates the status of a single code scanning alert. You must use an access token with the &#x60;security_events&#x60; scope to use this endpoint with private repositories. You can also use tokens with the &#x60;public_repo&#x60; scope for public repositories only. GitHub Apps must have the &#x60;security_events&#x60; write permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="alertNumber">The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the &#x60;number&#x60; field in the response from the &#x60;GET /repos/{owner}/{repo}/code-scanning/alerts&#x60; operation.</param>
        /// <param name="codeScanningUpdateAlertRequest"></param>
        /// <returns>CodeScanningGetAlert200Response</returns>
        public CodeScanningGetAlert200Response CodeScanningUpdateAlert (string owner, string repo, int? alertNumber, CodeScanningUpdateAlertRequest codeScanningUpdateAlertRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling CodeScanningUpdateAlert");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling CodeScanningUpdateAlert");
            
            // verify the required parameter 'alertNumber' is set
            if (alertNumber == null) throw new ApiException(400, "Missing required parameter 'alertNumber' when calling CodeScanningUpdateAlert");
            
            // verify the required parameter 'codeScanningUpdateAlertRequest' is set
            if (codeScanningUpdateAlertRequest == null) throw new ApiException(400, "Missing required parameter 'codeScanningUpdateAlertRequest' when calling CodeScanningUpdateAlert");
            

            var path = "/repos/{owner}/{repo}/code-scanning/alerts/{alert_number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "alert_number" + "}", ApiClient.ParameterToString(alertNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(codeScanningUpdateAlertRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningUpdateAlert: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningUpdateAlert: " + response.ErrorMessage, response.ErrorMessage);

            return (CodeScanningGetAlert200Response) ApiClient.Deserialize(response.Content, typeof(CodeScanningGetAlert200Response), response.Headers);
        }

        /// <summary>
        /// Upload an analysis as SARIF data Uploads SARIF data containing the results of a code scanning analysis to make the results available in a repository. You must use an access token with the &#x60;security_events&#x60; scope to use this endpoint for private repositories. You can also use tokens with the &#x60;public_repo&#x60; scope for public repositories only. GitHub Apps must have the &#x60;security_events&#x60; write permission to use this endpoint.  There are two places where you can upload code scanning results.  - If you upload to a pull request, for example &#x60;- -ref refs/pull/42/merge&#x60; or &#x60;- -ref refs/pull/42/head&#x60;, then the results appear as alerts in a pull request check. For more information, see \&quot;[Triaging code scanning alerts in pull requests](/code-security/secure-coding/triaging-code-scanning-alerts-in-pull-requests).\&quot;  - If you upload to a branch, for example &#x60;- -ref refs/heads/my-branch&#x60;, then the results appear in the **Security** tab for your repository. For more information, see \&quot;[Managing code scanning alerts for your repository](/code-security/secure-coding/managing-code-scanning-alerts-for-your-repository#viewing-the-alerts-for-a-repository).\&quot;  You must compress the SARIF-formatted analysis data that you want to upload, using &#x60;gzip&#x60;, and then encode it as a Base64 format string. For example:  &#x60;&#x60;&#x60; gzip -c analysis-data.sarif | base64 -w0 &#x60;&#x60;&#x60;  SARIF upload supports a maximum of 5000 results per analysis run. Any results over this limit are ignored and any SARIF uploads with more than 25,000 results are rejected. Typically, but not necessarily, a SARIF file contains a single run of a single tool. If a code scanning tool generates too many results, you should update the analysis configuration to run only the most important rules or queries.  The &#x60;202 Accepted&#x60;, response includes an &#x60;id&#x60; value. You can use this ID to check the status of the upload by using this for the &#x60;/sarifs/{sarif_id}&#x60; endpoint. For more information, see \&quot;[Get information about a SARIF upload](/rest/reference/code-scanning#get-information-about-a-sarif-upload).\&quot;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="codeScanningUploadSarifRequest"></param>
        /// <returns>CodeScanningUploadSarif202Response</returns>
        public CodeScanningUploadSarif202Response CodeScanningUploadSarif (string owner, string repo, CodeScanningUploadSarifRequest codeScanningUploadSarifRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling CodeScanningUploadSarif");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling CodeScanningUploadSarif");
            
            // verify the required parameter 'codeScanningUploadSarifRequest' is set
            if (codeScanningUploadSarifRequest == null) throw new ApiException(400, "Missing required parameter 'codeScanningUploadSarifRequest' when calling CodeScanningUploadSarif");
            

            var path = "/repos/{owner}/{repo}/code-scanning/sarifs";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(codeScanningUploadSarifRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningUploadSarif: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodeScanningUploadSarif: " + response.ErrorMessage, response.ErrorMessage);

            return (CodeScanningUploadSarif202Response) ApiClient.Deserialize(response.Content, typeof(CodeScanningUploadSarif202Response), response.Headers);
        }

    }
}
