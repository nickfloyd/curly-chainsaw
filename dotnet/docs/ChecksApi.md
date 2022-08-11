# Org.OpenAPITools.Api.ChecksApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChecksCreate**](ChecksApi.md#checkscreate) | **POST** /repos/{owner}/{repo}/check-runs | Create a check run
[**ChecksCreateSuite**](ChecksApi.md#checkscreatesuite) | **POST** /repos/{owner}/{repo}/check-suites | Create a check suite
[**ChecksGet**](ChecksApi.md#checksget) | **GET** /repos/{owner}/{repo}/check-runs/{check_run_id} | Get a check run
[**ChecksGetSuite**](ChecksApi.md#checksgetsuite) | **GET** /repos/{owner}/{repo}/check-suites/{check_suite_id} | Get a check suite
[**ChecksListAnnotations**](ChecksApi.md#checkslistannotations) | **GET** /repos/{owner}/{repo}/check-runs/{check_run_id}/annotations | List check run annotations
[**ChecksListForRef**](ChecksApi.md#checkslistforref) | **GET** /repos/{owner}/{repo}/commits/{ref}/check-runs | List check runs for a Git reference
[**ChecksListForSuite**](ChecksApi.md#checkslistforsuite) | **GET** /repos/{owner}/{repo}/check-suites/{check_suite_id}/check-runs | List check runs in a check suite
[**ChecksListSuitesForRef**](ChecksApi.md#checkslistsuitesforref) | **GET** /repos/{owner}/{repo}/commits/{ref}/check-suites | List check suites for a Git reference
[**ChecksRerequestRun**](ChecksApi.md#checksrerequestrun) | **POST** /repos/{owner}/{repo}/check-runs/{check_run_id}/rerequest | Rerequest a check run
[**ChecksRerequestSuite**](ChecksApi.md#checksrerequestsuite) | **POST** /repos/{owner}/{repo}/check-suites/{check_suite_id}/rerequest | Rerequest a check suite
[**ChecksSetSuitesPreferences**](ChecksApi.md#checkssetsuitespreferences) | **PATCH** /repos/{owner}/{repo}/check-suites/preferences | Update repository preferences for check suites
[**ChecksUpdate**](ChecksApi.md#checksupdate) | **PATCH** /repos/{owner}/{repo}/check-runs/{check_run_id} | Update a check run


<a name="checkscreate"></a>
# **ChecksCreate**
> CheckRun ChecksCreate (string owner, string repo, ChecksCreateRequest checksCreateRequest)

Create a check run

**Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.  Creates a new check run for a specific commit in a repository. Your GitHub App must have the `checks:write` permission to create check runs.  In a check suite, GitHub limits the number of check runs with the same name to 1000. Once these check runs exceed 1000, GitHub will start to automatically delete older check runs.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChecksCreateExample
    {
        public void main()
        {
            var apiInstance = new ChecksApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var checksCreateRequest = new ChecksCreateRequest(); // ChecksCreateRequest | 

            try
            {
                // Create a check run
                CheckRun result = apiInstance.ChecksCreate(owner, repo, checksCreateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecksApi.ChecksCreate: " + e.Message );
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
 **checksCreateRequest** | [**ChecksCreateRequest**](ChecksCreateRequest.md)|  | 

### Return type

[**CheckRun**](CheckRun.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkscreatesuite"></a>
# **ChecksCreateSuite**
> CheckSuite ChecksCreateSuite (string owner, string repo, ChecksCreateSuiteRequest checksCreateSuiteRequest)

Create a check suite

**Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array and a `null` value for `head_branch`.  By default, check suites are automatically created when you create a [check run](https://docs.github.com/rest/reference/checks#check-runs). You only need to use this endpoint for manually creating check suites when you've disabled automatic creation using \"[Update repository preferences for check suites](https://docs.github.com/rest/reference/checks#update-repository-preferences-for-check-suites)\". Your GitHub App must have the `checks:write` permission to create check suites.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChecksCreateSuiteExample
    {
        public void main()
        {
            var apiInstance = new ChecksApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var checksCreateSuiteRequest = new ChecksCreateSuiteRequest(); // ChecksCreateSuiteRequest | 

            try
            {
                // Create a check suite
                CheckSuite result = apiInstance.ChecksCreateSuite(owner, repo, checksCreateSuiteRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecksApi.ChecksCreateSuite: " + e.Message );
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
 **checksCreateSuiteRequest** | [**ChecksCreateSuiteRequest**](ChecksCreateSuiteRequest.md)|  | 

### Return type

[**CheckSuite**](CheckSuite.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checksget"></a>
# **ChecksGet**
> CheckRun ChecksGet (string owner, string repo, int? checkRunId)

Get a check run

**Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.  Gets a single check run using its `id`. GitHub Apps must have the `checks:read` permission on a private repository or pull access to a public repository to get check runs. OAuth Apps and authenticated users must have the `repo` scope to get check runs in a private repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChecksGetExample
    {
        public void main()
        {
            var apiInstance = new ChecksApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var checkRunId = 56;  // int? | The unique identifier of the check run.

            try
            {
                // Get a check run
                CheckRun result = apiInstance.ChecksGet(owner, repo, checkRunId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecksApi.ChecksGet: " + e.Message );
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
 **checkRunId** | **int?**| The unique identifier of the check run. | 

### Return type

[**CheckRun**](CheckRun.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checksgetsuite"></a>
# **ChecksGetSuite**
> CheckSuite ChecksGetSuite (string owner, string repo, int? checkSuiteId)

Get a check suite

**Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array and a `null` value for `head_branch`.  Gets a single check suite using its `id`. GitHub Apps must have the `checks:read` permission on a private repository or pull access to a public repository to get check suites. OAuth Apps and authenticated users must have the `repo` scope to get check suites in a private repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChecksGetSuiteExample
    {
        public void main()
        {
            var apiInstance = new ChecksApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var checkSuiteId = 56;  // int? | The unique identifier of the check suite.

            try
            {
                // Get a check suite
                CheckSuite result = apiInstance.ChecksGetSuite(owner, repo, checkSuiteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecksApi.ChecksGetSuite: " + e.Message );
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
 **checkSuiteId** | **int?**| The unique identifier of the check suite. | 

### Return type

[**CheckSuite**](CheckSuite.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkslistannotations"></a>
# **ChecksListAnnotations**
> List<CheckAnnotation> ChecksListAnnotations (string owner, string repo, int? checkRunId, int? perPage, int? page)

List check run annotations

Lists annotations for a check run using the annotation `id`. GitHub Apps must have the `checks:read` permission on a private repository or pull access to a public repository to get annotations for a check run. OAuth Apps and authenticated users must have the `repo` scope to get annotations for a check run in a private repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChecksListAnnotationsExample
    {
        public void main()
        {
            var apiInstance = new ChecksApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var checkRunId = 56;  // int? | The unique identifier of the check run.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List check run annotations
                List&lt;CheckAnnotation&gt; result = apiInstance.ChecksListAnnotations(owner, repo, checkRunId, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecksApi.ChecksListAnnotations: " + e.Message );
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
 **checkRunId** | **int?**| The unique identifier of the check run. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<CheckAnnotation>**](CheckAnnotation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkslistforref"></a>
# **ChecksListForRef**
> ChecksListForSuite200Response ChecksListForRef (string owner, string repo, string _ref, string checkName, string status, string filter, int? perPage, int? page, int? appId)

List check runs for a Git reference

**Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.  Lists check runs for a commit ref. The `ref` can be a SHA, branch name, or a tag name. GitHub Apps must have the `checks:read` permission on a private repository or pull access to a public repository to get check runs. OAuth Apps and authenticated users must have the `repo` scope to get check runs in a private repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChecksListForRefExample
    {
        public void main()
        {
            var apiInstance = new ChecksApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var _ref = "_ref_example";  // string | ref parameter
            var checkName = "checkName_example";  // string | Returns check runs with the specified `name`. (optional) 
            var status = "queued";  // string | Returns check runs with the specified `status`. (optional) 
            var filter = "latest";  // string | Filters check runs by their `completed_at` timestamp. `latest` returns the most recent check runs. (optional)  (default to latest)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var appId = 56;  // int? |  (optional) 

            try
            {
                // List check runs for a Git reference
                ChecksListForSuite200Response result = apiInstance.ChecksListForRef(owner, repo, _ref, checkName, status, filter, perPage, page, appId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecksApi.ChecksListForRef: " + e.Message );
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
 **_ref** | **string**| ref parameter | 
 **checkName** | **string**| Returns check runs with the specified &#x60;name&#x60;. | [optional] 
 **status** | **string**| Returns check runs with the specified &#x60;status&#x60;. | [optional] 
 **filter** | **string**| Filters check runs by their &#x60;completed_at&#x60; timestamp. &#x60;latest&#x60; returns the most recent check runs. | [optional] [default to latest]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **appId** | **int?**|  | [optional] 

### Return type

[**ChecksListForSuite200Response**](ChecksListForSuite200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkslistforsuite"></a>
# **ChecksListForSuite**
> ChecksListForSuite200Response ChecksListForSuite (string owner, string repo, int? checkSuiteId, string checkName, string status, string filter, int? perPage, int? page)

List check runs in a check suite

**Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.  Lists check runs for a check suite using its `id`. GitHub Apps must have the `checks:read` permission on a private repository or pull access to a public repository to get check runs. OAuth Apps and authenticated users must have the `repo` scope to get check runs in a private repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChecksListForSuiteExample
    {
        public void main()
        {
            var apiInstance = new ChecksApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var checkSuiteId = 56;  // int? | The unique identifier of the check suite.
            var checkName = "checkName_example";  // string | Returns check runs with the specified `name`. (optional) 
            var status = "queued";  // string | Returns check runs with the specified `status`. (optional) 
            var filter = "latest";  // string | Filters check runs by their `completed_at` timestamp. `latest` returns the most recent check runs. (optional)  (default to latest)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List check runs in a check suite
                ChecksListForSuite200Response result = apiInstance.ChecksListForSuite(owner, repo, checkSuiteId, checkName, status, filter, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecksApi.ChecksListForSuite: " + e.Message );
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
 **checkSuiteId** | **int?**| The unique identifier of the check suite. | 
 **checkName** | **string**| Returns check runs with the specified &#x60;name&#x60;. | [optional] 
 **status** | **string**| Returns check runs with the specified &#x60;status&#x60;. | [optional] 
 **filter** | **string**| Filters check runs by their &#x60;completed_at&#x60; timestamp. &#x60;latest&#x60; returns the most recent check runs. | [optional] [default to latest]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**ChecksListForSuite200Response**](ChecksListForSuite200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkslistsuitesforref"></a>
# **ChecksListSuitesForRef**
> ChecksListSuitesForRef200Response ChecksListSuitesForRef (string owner, string repo, string _ref, int? appId, string checkName, int? perPage, int? page)

List check suites for a Git reference

**Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array and a `null` value for `head_branch`.  Lists check suites for a commit `ref`. The `ref` can be a SHA, branch name, or a tag name. GitHub Apps must have the `checks:read` permission on a private repository or pull access to a public repository to list check suites. OAuth Apps and authenticated users must have the `repo` scope to get check suites in a private repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChecksListSuitesForRefExample
    {
        public void main()
        {
            var apiInstance = new ChecksApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var _ref = "_ref_example";  // string | ref parameter
            var appId = 1;  // int? | Filters check suites by GitHub App `id`. (optional) 
            var checkName = "checkName_example";  // string | Returns check runs with the specified `name`. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List check suites for a Git reference
                ChecksListSuitesForRef200Response result = apiInstance.ChecksListSuitesForRef(owner, repo, _ref, appId, checkName, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecksApi.ChecksListSuitesForRef: " + e.Message );
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
 **_ref** | **string**| ref parameter | 
 **appId** | **int?**| Filters check suites by GitHub App &#x60;id&#x60;. | [optional] 
 **checkName** | **string**| Returns check runs with the specified &#x60;name&#x60;. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**ChecksListSuitesForRef200Response**](ChecksListSuitesForRef200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checksrerequestrun"></a>
# **ChecksRerequestRun**
> Object ChecksRerequestRun (string owner, string repo, int? checkRunId)

Rerequest a check run

Triggers GitHub to rerequest an existing check run, without pushing new code to a repository. This endpoint will trigger the [`check_run` webhook](https://docs.github.com/webhooks/event-payloads/#check_run) event with the action `rerequested`. When a check run is `rerequested`, its `status` is reset to `queued` and the `conclusion` is cleared.  To rerequest a check run, your GitHub App must have the `checks:read` permission on a private repository or pull access to a public repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChecksRerequestRunExample
    {
        public void main()
        {
            var apiInstance = new ChecksApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var checkRunId = 56;  // int? | The unique identifier of the check run.

            try
            {
                // Rerequest a check run
                Object result = apiInstance.ChecksRerequestRun(owner, repo, checkRunId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecksApi.ChecksRerequestRun: " + e.Message );
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
 **checkRunId** | **int?**| The unique identifier of the check run. | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checksrerequestsuite"></a>
# **ChecksRerequestSuite**
> Object ChecksRerequestSuite (string owner, string repo, int? checkSuiteId)

Rerequest a check suite

Triggers GitHub to rerequest an existing check suite, without pushing new code to a repository. This endpoint will trigger the [`check_suite` webhook](https://docs.github.com/webhooks/event-payloads/#check_suite) event with the action `rerequested`. When a check suite is `rerequested`, its `status` is reset to `queued` and the `conclusion` is cleared.  To rerequest a check suite, your GitHub App must have the `checks:read` permission on a private repository or pull access to a public repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChecksRerequestSuiteExample
    {
        public void main()
        {
            var apiInstance = new ChecksApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var checkSuiteId = 56;  // int? | The unique identifier of the check suite.

            try
            {
                // Rerequest a check suite
                Object result = apiInstance.ChecksRerequestSuite(owner, repo, checkSuiteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecksApi.ChecksRerequestSuite: " + e.Message );
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
 **checkSuiteId** | **int?**| The unique identifier of the check suite. | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkssetsuitespreferences"></a>
# **ChecksSetSuitesPreferences**
> CheckSuitePreference ChecksSetSuitesPreferences (string owner, string repo, ChecksSetSuitesPreferencesRequest checksSetSuitesPreferencesRequest)

Update repository preferences for check suites

Changes the default automatic flow when creating check suites. By default, a check suite is automatically created each time code is pushed to a repository. When you disable the automatic creation of check suites, you can manually [Create a check suite](https://docs.github.com/rest/reference/checks#create-a-check-suite). You must have admin permissions in the repository to set preferences for check suites.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChecksSetSuitesPreferencesExample
    {
        public void main()
        {
            var apiInstance = new ChecksApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var checksSetSuitesPreferencesRequest = new ChecksSetSuitesPreferencesRequest(); // ChecksSetSuitesPreferencesRequest | 

            try
            {
                // Update repository preferences for check suites
                CheckSuitePreference result = apiInstance.ChecksSetSuitesPreferences(owner, repo, checksSetSuitesPreferencesRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecksApi.ChecksSetSuitesPreferences: " + e.Message );
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
 **checksSetSuitesPreferencesRequest** | [**ChecksSetSuitesPreferencesRequest**](ChecksSetSuitesPreferencesRequest.md)|  | 

### Return type

[**CheckSuitePreference**](CheckSuitePreference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checksupdate"></a>
# **ChecksUpdate**
> CheckRun ChecksUpdate (string owner, string repo, int? checkRunId, ChecksUpdateRequest checksUpdateRequest)

Update a check run

**Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.  Updates a check run for a specific commit in a repository. Your GitHub App must have the `checks:write` permission to edit check runs.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChecksUpdateExample
    {
        public void main()
        {
            var apiInstance = new ChecksApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var checkRunId = 56;  // int? | The unique identifier of the check run.
            var checksUpdateRequest = new ChecksUpdateRequest(); // ChecksUpdateRequest | 

            try
            {
                // Update a check run
                CheckRun result = apiInstance.ChecksUpdate(owner, repo, checkRunId, checksUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecksApi.ChecksUpdate: " + e.Message );
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
 **checkRunId** | **int?**| The unique identifier of the check run. | 
 **checksUpdateRequest** | [**ChecksUpdateRequest**](ChecksUpdateRequest.md)|  | 

### Return type

[**CheckRun**](CheckRun.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

