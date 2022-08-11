# Org.OpenAPITools.Api.CodeScanningApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CodeScanningDeleteAnalysis**](CodeScanningApi.md#codescanningdeleteanalysis) | **DELETE** /repos/{owner}/{repo}/code-scanning/analyses/{analysis_id} | Delete a code scanning analysis from a repository
[**CodeScanningGetAlert**](CodeScanningApi.md#codescanninggetalert) | **GET** /repos/{owner}/{repo}/code-scanning/alerts/{alert_number} | Get a code scanning alert
[**CodeScanningGetAnalysis**](CodeScanningApi.md#codescanninggetanalysis) | **GET** /repos/{owner}/{repo}/code-scanning/analyses/{analysis_id} | Get a code scanning analysis for a repository
[**CodeScanningGetSarif**](CodeScanningApi.md#codescanninggetsarif) | **GET** /repos/{owner}/{repo}/code-scanning/sarifs/{sarif_id} | Get information about a SARIF upload
[**CodeScanningListAlertInstances**](CodeScanningApi.md#codescanninglistalertinstances) | **GET** /repos/{owner}/{repo}/code-scanning/alerts/{alert_number}/instances | List instances of a code scanning alert
[**CodeScanningListAlertsForEnterprise**](CodeScanningApi.md#codescanninglistalertsforenterprise) | **GET** /enterprises/{enterprise}/code-scanning/alerts | List code scanning alerts for an enterprise
[**CodeScanningListAlertsForOrg**](CodeScanningApi.md#codescanninglistalertsfororg) | **GET** /orgs/{org}/code-scanning/alerts | List code scanning alerts for an organization
[**CodeScanningListAlertsForRepo**](CodeScanningApi.md#codescanninglistalertsforrepo) | **GET** /repos/{owner}/{repo}/code-scanning/alerts | List code scanning alerts for a repository
[**CodeScanningListRecentAnalyses**](CodeScanningApi.md#codescanninglistrecentanalyses) | **GET** /repos/{owner}/{repo}/code-scanning/analyses | List code scanning analyses for a repository
[**CodeScanningUpdateAlert**](CodeScanningApi.md#codescanningupdatealert) | **PATCH** /repos/{owner}/{repo}/code-scanning/alerts/{alert_number} | Update a code scanning alert
[**CodeScanningUploadSarif**](CodeScanningApi.md#codescanninguploadsarif) | **POST** /repos/{owner}/{repo}/code-scanning/sarifs | Upload an analysis as SARIF data


<a name="codescanningdeleteanalysis"></a>
# **CodeScanningDeleteAnalysis**
> AnalysisDeletion CodeScanningDeleteAnalysis (string owner, string repo, int? analysisId, string confirmDelete)

Delete a code scanning analysis from a repository

Deletes a specified code scanning analysis from a repository. For private repositories, you must use an access token with the `repo` scope. For public repositories, you must use an access token with `public_repo` scope. GitHub Apps must have the `security_events` write permission to use this endpoint.  You can delete one analysis at a time. To delete a series of analyses, start with the most recent analysis and work backwards. Conceptually, the process is similar to the undo function in a text editor.  When you list the analyses for a repository, one or more will be identified as deletable in the response:  ``` \"deletable\": true ```  An analysis is deletable when it's the most recent in a set of analyses. Typically, a repository will have multiple sets of analyses for each enabled code scanning tool, where a set is determined by a unique combination of analysis values:  * `ref` * `tool` * `analysis_key` * `environment`  If you attempt to delete an analysis that is not the most recent in a set, you'll get a 400 response with the message:  ``` Analysis specified is not deletable. ```  The response from a successful `DELETE` operation provides you with two alternative URLs for deleting the next analysis in the set: `next_analysis_url` and `confirm_delete_url`. Use the `next_analysis_url` URL if you want to avoid accidentally deleting the final analysis in a set. This is a useful option if you want to preserve at least one analysis for the specified tool in your repository. Use the `confirm_delete_url` URL if you are content to remove all analyses for a tool. When you delete the last analysis in a set, the value of `next_analysis_url` and `confirm_delete_url` in the 200 response is `null`.  As an example of the deletion process, let's imagine that you added a workflow that configured a particular code scanning tool to analyze the code in a repository. This tool has added 15 analyses: 10 on the default branch, and another 5 on a topic branch. You therefore have two separate sets of analyses for this tool. You've now decided that you want to remove all of the analyses for the tool. To do this you must make 15 separate deletion requests. To start, you must find an analysis that's identified as deletable. Each set of analyses always has one that's identified as deletable. Having found the deletable analysis for one of the two sets, delete this analysis and then continue deleting the next analysis in the set until they're all deleted. Then repeat the process for the second set. The procedure therefore consists of a nested loop:  **Outer loop**: * List the analyses for the repository, filtered by tool. * Parse this list to find a deletable analysis. If found:    **Inner loop**:   * Delete the identified analysis.   * Parse the response for the value of `confirm_delete_url` and, if found, use this in the next iteration.  The above process assumes that you want to remove all trace of the tool's analyses from the GitHub user interface, for the specified repository, and it therefore uses the `confirm_delete_url` value. Alternatively, you could use the `next_analysis_url` value, which would leave the last analysis in each set undeleted to avoid removing a tool's analysis entirely.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodeScanningDeleteAnalysisExample
    {
        public void main()
        {
            var apiInstance = new CodeScanningApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var analysisId = 56;  // int? | The ID of the analysis, as returned from the `GET /repos/{owner}/{repo}/code-scanning/analyses` operation.
            var confirmDelete = "confirmDelete_example";  // string | Allow deletion if the specified analysis is the last in a set. If you attempt to delete the final analysis in a set without setting this parameter to `true`, you'll get a 400 response with the message: `Analysis is last of its type and deletion may result in the loss of historical alert data. Please specify confirm_delete.` (optional) 

            try
            {
                // Delete a code scanning analysis from a repository
                AnalysisDeletion result = apiInstance.CodeScanningDeleteAnalysis(owner, repo, analysisId, confirmDelete);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodeScanningApi.CodeScanningDeleteAnalysis: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **analysisId** | **int?**| The ID of the analysis, as returned from the &#x60;GET /repos/{owner}/{repo}/code-scanning/analyses&#x60; operation. | 
 **confirmDelete** | **string**| Allow deletion if the specified analysis is the last in a set. If you attempt to delete the final analysis in a set without setting this parameter to &#x60;true&#x60;, you&#39;ll get a 400 response with the message: &#x60;Analysis is last of its type and deletion may result in the loss of historical alert data. Please specify confirm_delete.&#x60; | [optional] 

### Return type

[**AnalysisDeletion**](AnalysisDeletion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/scim+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codescanninggetalert"></a>
# **CodeScanningGetAlert**
> CodeScanningGetAlert200Response CodeScanningGetAlert (string owner, string repo, int? alertNumber)

Get a code scanning alert

Gets a single code scanning alert. You must use an access token with the `security_events` scope to use this endpoint with private repos, the `public_repo` scope also grants permission to read security events on public repos only. GitHub Apps must have the `security_events` read permission to use this endpoint.  **Deprecation notice**: The instances field is deprecated and will, in future, not be included in the response for this endpoint. The example response reflects this change. The same information can now be retrieved via a GET request to the URL specified by `instances_url`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodeScanningGetAlertExample
    {
        public void main()
        {
            var apiInstance = new CodeScanningApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var alertNumber = 56;  // int? | The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the `number` field in the response from the `GET /repos/{owner}/{repo}/code-scanning/alerts` operation.

            try
            {
                // Get a code scanning alert
                CodeScanningGetAlert200Response result = apiInstance.CodeScanningGetAlert(owner, repo, alertNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodeScanningApi.CodeScanningGetAlert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **alertNumber** | **int?**| The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the &#x60;number&#x60; field in the response from the &#x60;GET /repos/{owner}/{repo}/code-scanning/alerts&#x60; operation. | 

### Return type

[**CodeScanningGetAlert200Response**](CodeScanningGetAlert200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codescanninggetanalysis"></a>
# **CodeScanningGetAnalysis**
> CodeScanningListRecentAnalyses200ResponseInner CodeScanningGetAnalysis (string owner, string repo, int? analysisId)

Get a code scanning analysis for a repository

Gets a specified code scanning analysis for a repository. You must use an access token with the `security_events` scope to use this endpoint with private repos, the `public_repo` scope also grants permission to read security events on public repos only. GitHub Apps must have the `security_events` read permission to use this endpoint.  The default JSON response contains fields that describe the analysis. This includes the Git reference and commit SHA to which the analysis relates, the datetime of the analysis, the name of the code scanning tool, and the number of alerts.  The `rules_count` field in the default response give the number of rules that were run in the analysis. For very old analyses this data is not available, and `0` is returned in this field.  If you use the Accept header `application/sarif+json`, the response contains the analysis data that was uploaded. This is formatted as [SARIF version 2.1.0](https://docs.oasis-open.org/sarif/sarif/v2.1.0/cs01/sarif-v2.1.0-cs01.html).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodeScanningGetAnalysisExample
    {
        public void main()
        {
            var apiInstance = new CodeScanningApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var analysisId = 56;  // int? | The ID of the analysis, as returned from the `GET /repos/{owner}/{repo}/code-scanning/analyses` operation.

            try
            {
                // Get a code scanning analysis for a repository
                CodeScanningListRecentAnalyses200ResponseInner result = apiInstance.CodeScanningGetAnalysis(owner, repo, analysisId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodeScanningApi.CodeScanningGetAnalysis: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **analysisId** | **int?**| The ID of the analysis, as returned from the &#x60;GET /repos/{owner}/{repo}/code-scanning/analyses&#x60; operation. | 

### Return type

[**CodeScanningListRecentAnalyses200ResponseInner**](CodeScanningListRecentAnalyses200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/json+sarif

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codescanninggetsarif"></a>
# **CodeScanningGetSarif**
> CodeScanningGetSarif200Response CodeScanningGetSarif (string owner, string repo, string sarifId)

Get information about a SARIF upload

Gets information about a SARIF upload, including the status and the URL of the analysis that was uploaded so that you can retrieve details of the analysis. For more information, see \"[Get a code scanning analysis for a repository](/rest/reference/code-scanning#get-a-code-scanning-analysis-for-a-repository).\" You must use an access token with the `security_events` scope to use this endpoint with private repos, the `public_repo` scope also grants permission to read security events on public repos only. GitHub Apps must have the `security_events` read permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodeScanningGetSarifExample
    {
        public void main()
        {
            var apiInstance = new CodeScanningApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var sarifId = "sarifId_example";  // string | The SARIF ID obtained after uploading.

            try
            {
                // Get information about a SARIF upload
                CodeScanningGetSarif200Response result = apiInstance.CodeScanningGetSarif(owner, repo, sarifId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodeScanningApi.CodeScanningGetSarif: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **sarifId** | **string**| The SARIF ID obtained after uploading. | 

### Return type

[**CodeScanningGetSarif200Response**](CodeScanningGetSarif200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codescanninglistalertinstances"></a>
# **CodeScanningListAlertInstances**
> List<CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance> CodeScanningListAlertInstances (string owner, string repo, int? alertNumber, int? page, int? perPage, string _ref)

List instances of a code scanning alert

Lists all instances of the specified code scanning alert. You must use an access token with the `security_events` scope to use this endpoint with private repos, the `public_repo` scope also grants permission to read security events on public repos only. GitHub Apps must have the `security_events` read permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodeScanningListAlertInstancesExample
    {
        public void main()
        {
            var apiInstance = new CodeScanningApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var alertNumber = 56;  // int? | The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the `number` field in the response from the `GET /repos/{owner}/{repo}/code-scanning/alerts` operation.
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var _ref = "_ref_example";  // string | The Git reference for the results you want to list. The `ref` for a branch can be formatted either as `refs/heads/<branch name>` or simply `<branch name>`. To reference a pull request use `refs/pull/<number>/merge`. (optional) 

            try
            {
                // List instances of a code scanning alert
                List&lt;CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance&gt; result = apiInstance.CodeScanningListAlertInstances(owner, repo, alertNumber, page, perPage, _ref);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodeScanningApi.CodeScanningListAlertInstances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **alertNumber** | **int?**| The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the &#x60;number&#x60; field in the response from the &#x60;GET /repos/{owner}/{repo}/code-scanning/alerts&#x60; operation. | 
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **_ref** | **string**| The Git reference for the results you want to list. The &#x60;ref&#x60; for a branch can be formatted either as &#x60;refs/heads/&lt;branch name&gt;&#x60; or simply &#x60;&lt;branch name&gt;&#x60;. To reference a pull request use &#x60;refs/pull/&lt;number&gt;/merge&#x60;. | [optional] 

### Return type

[**List<CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance>**](CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codescanninglistalertsforenterprise"></a>
# **CodeScanningListAlertsForEnterprise**
> List<CodeScanningListAlertsForEnterprise200ResponseInner> CodeScanningListAlertsForEnterprise (string enterprise, string toolName, string toolGuid, string before, string after, int? page, int? perPage, string direction, string state, string sort)

List code scanning alerts for an enterprise

Lists code scanning alerts for the default branch for all eligible repositories in an enterprise. Eligible repositories are repositories that are owned by organizations that you own or for which you are a security manager. For more information, see \"[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).\"  To use this endpoint, you must be a member of the enterprise, and you must use an access token with the `repo` scope or `security_events` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodeScanningListAlertsForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new CodeScanningApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var toolName = "toolName_example";  // string | The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either `tool_name` or `tool_guid`, but not both. (optional) 
            var toolGuid = "toolGuid_example";  // string | The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either `tool_guid` or `tool_name`, but not both. (optional) 
            var before = "before_example";  // string | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. (optional) 
            var after = "after_example";  // string | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor. (optional) 
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var direction = "asc";  // string | The direction to sort the results by. (optional)  (default to desc)
            var state = "open";  // string | If specified, only code scanning alerts with this state will be returned. (optional) 
            var sort = "created";  // string | The property by which to sort the results. (optional)  (default to created)

            try
            {
                // List code scanning alerts for an enterprise
                List&lt;CodeScanningListAlertsForEnterprise200ResponseInner&gt; result = apiInstance.CodeScanningListAlertsForEnterprise(enterprise, toolName, toolGuid, before, after, page, perPage, direction, state, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodeScanningApi.CodeScanningListAlertsForEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **toolName** | **string**| The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either &#x60;tool_name&#x60; or &#x60;tool_guid&#x60;, but not both. | [optional] 
 **toolGuid** | **string**| The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either &#x60;tool_guid&#x60; or &#x60;tool_name&#x60;, but not both. | [optional] 
 **before** | **string**| A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. | [optional] 
 **after** | **string**| A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor. | [optional] 
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **direction** | **string**| The direction to sort the results by. | [optional] [default to desc]
 **state** | **string**| If specified, only code scanning alerts with this state will be returned. | [optional] 
 **sort** | **string**| The property by which to sort the results. | [optional] [default to created]

### Return type

[**List<CodeScanningListAlertsForEnterprise200ResponseInner>**](CodeScanningListAlertsForEnterprise200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codescanninglistalertsfororg"></a>
# **CodeScanningListAlertsForOrg**
> List<CodeScanningListAlertsForEnterprise200ResponseInner> CodeScanningListAlertsForOrg (string org, string toolName, string toolGuid, string before, string after, int? page, int? perPage, string direction, string state, string sort)

List code scanning alerts for an organization

Lists code scanning alerts for the default branch for all eligible repositories in an organization. Eligible repositories are repositories that are owned by organizations that you own or for which you are a security manager. For more information, see \"[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).\"  To use this endpoint, you must be an owner or security manager for the organization, and you must use an access token with the `repo` scope or `security_events` scope.  For public repositories, you may instead use the `public_repo` scope.  GitHub Apps must have the `security_events` read permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodeScanningListAlertsForOrgExample
    {
        public void main()
        {
            var apiInstance = new CodeScanningApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var toolName = "toolName_example";  // string | The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either `tool_name` or `tool_guid`, but not both. (optional) 
            var toolGuid = "toolGuid_example";  // string | The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either `tool_guid` or `tool_name`, but not both. (optional) 
            var before = "before_example";  // string | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. (optional) 
            var after = "after_example";  // string | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor. (optional) 
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var direction = "asc";  // string | The direction to sort the results by. (optional)  (default to desc)
            var state = "open";  // string | If specified, only code scanning alerts with this state will be returned. (optional) 
            var sort = "created";  // string | The property by which to sort the results. (optional)  (default to created)

            try
            {
                // List code scanning alerts for an organization
                List&lt;CodeScanningListAlertsForEnterprise200ResponseInner&gt; result = apiInstance.CodeScanningListAlertsForOrg(org, toolName, toolGuid, before, after, page, perPage, direction, state, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodeScanningApi.CodeScanningListAlertsForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **toolName** | **string**| The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either &#x60;tool_name&#x60; or &#x60;tool_guid&#x60;, but not both. | [optional] 
 **toolGuid** | **string**| The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either &#x60;tool_guid&#x60; or &#x60;tool_name&#x60;, but not both. | [optional] 
 **before** | **string**| A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. | [optional] 
 **after** | **string**| A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor. | [optional] 
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **direction** | **string**| The direction to sort the results by. | [optional] [default to desc]
 **state** | **string**| If specified, only code scanning alerts with this state will be returned. | [optional] 
 **sort** | **string**| The property by which to sort the results. | [optional] [default to created]

### Return type

[**List<CodeScanningListAlertsForEnterprise200ResponseInner>**](CodeScanningListAlertsForEnterprise200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codescanninglistalertsforrepo"></a>
# **CodeScanningListAlertsForRepo**
> List<CodeScanningListAlertsForRepo200ResponseInner> CodeScanningListAlertsForRepo (string owner, string repo, string toolName, string toolGuid, int? page, int? perPage, string _ref, string direction, string sort, string state)

List code scanning alerts for a repository

Lists code scanning alerts.  To use this endpoint, you must use an access token with the `security_events` scope or, for alerts from public repositories only, an access token with the `public_repo` scope.  GitHub Apps must have the `security_events` read permission to use this endpoint.  The response includes a `most_recent_instance` object. This provides details of the most recent instance of this alert for the default branch (or for the specified Git reference if you used `ref` in the request).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodeScanningListAlertsForRepoExample
    {
        public void main()
        {
            var apiInstance = new CodeScanningApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var toolName = "toolName_example";  // string | The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either `tool_name` or `tool_guid`, but not both. (optional) 
            var toolGuid = "toolGuid_example";  // string | The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either `tool_guid` or `tool_name`, but not both. (optional) 
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var _ref = "_ref_example";  // string | The Git reference for the results you want to list. The `ref` for a branch can be formatted either as `refs/heads/<branch name>` or simply `<branch name>`. To reference a pull request use `refs/pull/<number>/merge`. (optional) 
            var direction = "asc";  // string | The direction to sort the results by. (optional)  (default to desc)
            var sort = "created";  // string | The property by which to sort the results. (optional)  (default to created)
            var state = "open";  // string | If specified, only code scanning alerts with this state will be returned. (optional) 

            try
            {
                // List code scanning alerts for a repository
                List&lt;CodeScanningListAlertsForRepo200ResponseInner&gt; result = apiInstance.CodeScanningListAlertsForRepo(owner, repo, toolName, toolGuid, page, perPage, _ref, direction, sort, state);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodeScanningApi.CodeScanningListAlertsForRepo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **toolName** | **string**| The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either &#x60;tool_name&#x60; or &#x60;tool_guid&#x60;, but not both. | [optional] 
 **toolGuid** | **string**| The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either &#x60;tool_guid&#x60; or &#x60;tool_name&#x60;, but not both. | [optional] 
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **_ref** | **string**| The Git reference for the results you want to list. The &#x60;ref&#x60; for a branch can be formatted either as &#x60;refs/heads/&lt;branch name&gt;&#x60; or simply &#x60;&lt;branch name&gt;&#x60;. To reference a pull request use &#x60;refs/pull/&lt;number&gt;/merge&#x60;. | [optional] 
 **direction** | **string**| The direction to sort the results by. | [optional] [default to desc]
 **sort** | **string**| The property by which to sort the results. | [optional] [default to created]
 **state** | **string**| If specified, only code scanning alerts with this state will be returned. | [optional] 

### Return type

[**List<CodeScanningListAlertsForRepo200ResponseInner>**](CodeScanningListAlertsForRepo200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codescanninglistrecentanalyses"></a>
# **CodeScanningListRecentAnalyses**
> List<CodeScanningListRecentAnalyses200ResponseInner> CodeScanningListRecentAnalyses (string owner, string repo, string toolName, string toolGuid, int? page, int? perPage, string _ref, string sarifId)

List code scanning analyses for a repository

Lists the details of all code scanning analyses for a repository, starting with the most recent. The response is paginated and you can use the `page` and `per_page` parameters to list the analyses you're interested in. By default 30 analyses are listed per page.  The `rules_count` field in the response give the number of rules that were run in the analysis. For very old analyses this data is not available, and `0` is returned in this field.  You must use an access token with the `security_events` scope to use this endpoint with private repos, the `public_repo` scope also grants permission to read security events on public repos only. GitHub Apps must have the `security_events` read permission to use this endpoint.  **Deprecation notice**: The `tool_name` field is deprecated and will, in future, not be included in the response for this endpoint. The example response reflects this change. The tool name can now be found inside the `tool` field.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodeScanningListRecentAnalysesExample
    {
        public void main()
        {
            var apiInstance = new CodeScanningApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var toolName = "toolName_example";  // string | The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either `tool_name` or `tool_guid`, but not both. (optional) 
            var toolGuid = "toolGuid_example";  // string | The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either `tool_guid` or `tool_name`, but not both. (optional) 
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var _ref = "_ref_example";  // string | The Git reference for the analyses you want to list. The `ref` for a branch can be formatted either as `refs/heads/<branch name>` or simply `<branch name>`. To reference a pull request use `refs/pull/<number>/merge`. (optional) 
            var sarifId = 6c81cd8e-b078-4ac3-a3be-1dad7dbd0b53;  // string | Filter analyses belonging to the same SARIF upload. (optional) 

            try
            {
                // List code scanning analyses for a repository
                List&lt;CodeScanningListRecentAnalyses200ResponseInner&gt; result = apiInstance.CodeScanningListRecentAnalyses(owner, repo, toolName, toolGuid, page, perPage, _ref, sarifId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodeScanningApi.CodeScanningListRecentAnalyses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **toolName** | **string**| The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either &#x60;tool_name&#x60; or &#x60;tool_guid&#x60;, but not both. | [optional] 
 **toolGuid** | **string**| The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either &#x60;tool_guid&#x60; or &#x60;tool_name&#x60;, but not both. | [optional] 
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **_ref** | **string**| The Git reference for the analyses you want to list. The &#x60;ref&#x60; for a branch can be formatted either as &#x60;refs/heads/&lt;branch name&gt;&#x60; or simply &#x60;&lt;branch name&gt;&#x60;. To reference a pull request use &#x60;refs/pull/&lt;number&gt;/merge&#x60;. | [optional] 
 **sarifId** | **string**| Filter analyses belonging to the same SARIF upload. | [optional] 

### Return type

[**List<CodeScanningListRecentAnalyses200ResponseInner>**](CodeScanningListRecentAnalyses200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codescanningupdatealert"></a>
# **CodeScanningUpdateAlert**
> CodeScanningGetAlert200Response CodeScanningUpdateAlert (string owner, string repo, int? alertNumber, CodeScanningUpdateAlertRequest codeScanningUpdateAlertRequest)

Update a code scanning alert

Updates the status of a single code scanning alert. You must use an access token with the `security_events` scope to use this endpoint with private repositories. You can also use tokens with the `public_repo` scope for public repositories only. GitHub Apps must have the `security_events` write permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodeScanningUpdateAlertExample
    {
        public void main()
        {
            var apiInstance = new CodeScanningApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var alertNumber = 56;  // int? | The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the `number` field in the response from the `GET /repos/{owner}/{repo}/code-scanning/alerts` operation.
            var codeScanningUpdateAlertRequest = new CodeScanningUpdateAlertRequest(); // CodeScanningUpdateAlertRequest | 

            try
            {
                // Update a code scanning alert
                CodeScanningGetAlert200Response result = apiInstance.CodeScanningUpdateAlert(owner, repo, alertNumber, codeScanningUpdateAlertRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodeScanningApi.CodeScanningUpdateAlert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **alertNumber** | **int?**| The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the &#x60;number&#x60; field in the response from the &#x60;GET /repos/{owner}/{repo}/code-scanning/alerts&#x60; operation. | 
 **codeScanningUpdateAlertRequest** | [**CodeScanningUpdateAlertRequest**](CodeScanningUpdateAlertRequest.md)|  | 

### Return type

[**CodeScanningGetAlert200Response**](CodeScanningGetAlert200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codescanninguploadsarif"></a>
# **CodeScanningUploadSarif**
> CodeScanningUploadSarif202Response CodeScanningUploadSarif (string owner, string repo, CodeScanningUploadSarifRequest codeScanningUploadSarifRequest)

Upload an analysis as SARIF data

Uploads SARIF data containing the results of a code scanning analysis to make the results available in a repository. You must use an access token with the `security_events` scope to use this endpoint for private repositories. You can also use tokens with the `public_repo` scope for public repositories only. GitHub Apps must have the `security_events` write permission to use this endpoint.  There are two places where you can upload code scanning results.  - If you upload to a pull request, for example `- -ref refs/pull/42/merge` or `- -ref refs/pull/42/head`, then the results appear as alerts in a pull request check. For more information, see \"[Triaging code scanning alerts in pull requests](/code-security/secure-coding/triaging-code-scanning-alerts-in-pull-requests).\"  - If you upload to a branch, for example `- -ref refs/heads/my-branch`, then the results appear in the **Security** tab for your repository. For more information, see \"[Managing code scanning alerts for your repository](/code-security/secure-coding/managing-code-scanning-alerts-for-your-repository#viewing-the-alerts-for-a-repository).\"  You must compress the SARIF-formatted analysis data that you want to upload, using `gzip`, and then encode it as a Base64 format string. For example:  ``` gzip -c analysis-data.sarif | base64 -w0 ```  SARIF upload supports a maximum of 5000 results per analysis run. Any results over this limit are ignored and any SARIF uploads with more than 25,000 results are rejected. Typically, but not necessarily, a SARIF file contains a single run of a single tool. If a code scanning tool generates too many results, you should update the analysis configuration to run only the most important rules or queries.  The `202 Accepted`, response includes an `id` value. You can use this ID to check the status of the upload by using this for the `/sarifs/{sarif_id}` endpoint. For more information, see \"[Get information about a SARIF upload](/rest/reference/code-scanning#get-information-about-a-sarif-upload).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodeScanningUploadSarifExample
    {
        public void main()
        {
            var apiInstance = new CodeScanningApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var codeScanningUploadSarifRequest = new CodeScanningUploadSarifRequest(); // CodeScanningUploadSarifRequest | 

            try
            {
                // Upload an analysis as SARIF data
                CodeScanningUploadSarif202Response result = apiInstance.CodeScanningUploadSarif(owner, repo, codeScanningUploadSarifRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodeScanningApi.CodeScanningUploadSarif: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **codeScanningUploadSarifRequest** | [**CodeScanningUploadSarifRequest**](CodeScanningUploadSarifRequest.md)|  | 

### Return type

[**CodeScanningUploadSarif202Response**](CodeScanningUploadSarif202Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

