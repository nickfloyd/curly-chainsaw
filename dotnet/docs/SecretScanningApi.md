# Org.OpenAPITools.Api.SecretScanningApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SecretScanningGetAlert**](SecretScanningApi.md#secretscanninggetalert) | **GET** /repos/{owner}/{repo}/secret-scanning/alerts/{alert_number} | Get a secret scanning alert
[**SecretScanningListAlertsForEnterprise**](SecretScanningApi.md#secretscanninglistalertsforenterprise) | **GET** /enterprises/{enterprise}/secret-scanning/alerts | List secret scanning alerts for an enterprise
[**SecretScanningListAlertsForOrg**](SecretScanningApi.md#secretscanninglistalertsfororg) | **GET** /orgs/{org}/secret-scanning/alerts | List secret scanning alerts for an organization
[**SecretScanningListAlertsForRepo**](SecretScanningApi.md#secretscanninglistalertsforrepo) | **GET** /repos/{owner}/{repo}/secret-scanning/alerts | List secret scanning alerts for a repository
[**SecretScanningListLocationsForAlert**](SecretScanningApi.md#secretscanninglistlocationsforalert) | **GET** /repos/{owner}/{repo}/secret-scanning/alerts/{alert_number}/locations | List locations for a secret scanning alert
[**SecretScanningUpdateAlert**](SecretScanningApi.md#secretscanningupdatealert) | **PATCH** /repos/{owner}/{repo}/secret-scanning/alerts/{alert_number} | Update a secret scanning alert


<a name="secretscanninggetalert"></a>
# **SecretScanningGetAlert**
> SecretScanningListAlertsForRepo200ResponseInner SecretScanningGetAlert (string owner, string repo, int? alertNumber)

Get a secret scanning alert

Gets a single secret scanning alert detected in an eligible repository. To use this endpoint, you must be an administrator for the repository or for the organization that owns the repository, and you must use a personal access token with the `repo` scope or `security_events` scope. For public repositories, you may instead use the `public_repo` scope.  GitHub Apps must have the `secret_scanning_alerts` read permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecretScanningGetAlertExample
    {
        public void main()
        {
            var apiInstance = new SecretScanningApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var alertNumber = 56;  // int? | The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the `number` field in the response from the `GET /repos/{owner}/{repo}/code-scanning/alerts` operation.

            try
            {
                // Get a secret scanning alert
                SecretScanningListAlertsForRepo200ResponseInner result = apiInstance.SecretScanningGetAlert(owner, repo, alertNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecretScanningApi.SecretScanningGetAlert: " + e.Message );
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

[**SecretScanningListAlertsForRepo200ResponseInner**](SecretScanningListAlertsForRepo200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="secretscanninglistalertsforenterprise"></a>
# **SecretScanningListAlertsForEnterprise**
> List<SecretScanningListAlertsForEnterprise200ResponseInner> SecretScanningListAlertsForEnterprise (string enterprise, string state, string secretType, string resolution, string sort, string direction, int? perPage, string before, string after)

List secret scanning alerts for an enterprise

Lists secret scanning alerts for eligible repositories in an enterprise, from newest to oldest. To use this endpoint, you must be a member of the enterprise, and you must use an access token with the `repo` scope or `security_events` scope. Alerts are only returned for organizations in the enterprise for which you are an organization owner or a [security manager](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecretScanningListAlertsForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new SecretScanningApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var state = "open";  // string | Set to `open` or `resolved` to only list secret scanning alerts in a specific state. (optional) 
            var secretType = "secretType_example";  // string | A comma-separated list of secret types to return. By default all secret types are returned. See \"[Secret scanning patterns](https://docs.github.com/code-security/secret-scanning/secret-scanning-patterns#supported-secrets-for-advanced-security)\" for a complete list of secret types. (optional) 
            var resolution = "resolution_example";  // string | A comma-separated list of resolutions. Only secret scanning alerts with one of these resolutions are listed. Valid resolutions are `false_positive`, `wont_fix`, `revoked`, `pattern_edited`, `pattern_deleted` or `used_in_tests`. (optional) 
            var sort = "created";  // string | The property to sort the results by. `created` means when the alert was created. `updated` means when the alert was updated or resolved. (optional)  (default to created)
            var direction = "asc";  // string | The direction to sort the results by. (optional)  (default to desc)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var before = "before_example";  // string | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. (optional) 
            var after = "after_example";  // string | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor. (optional) 

            try
            {
                // List secret scanning alerts for an enterprise
                List&lt;SecretScanningListAlertsForEnterprise200ResponseInner&gt; result = apiInstance.SecretScanningListAlertsForEnterprise(enterprise, state, secretType, resolution, sort, direction, perPage, before, after);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecretScanningApi.SecretScanningListAlertsForEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **state** | **string**| Set to &#x60;open&#x60; or &#x60;resolved&#x60; to only list secret scanning alerts in a specific state. | [optional] 
 **secretType** | **string**| A comma-separated list of secret types to return. By default all secret types are returned. See \&quot;[Secret scanning patterns](https://docs.github.com/code-security/secret-scanning/secret-scanning-patterns#supported-secrets-for-advanced-security)\&quot; for a complete list of secret types. | [optional] 
 **resolution** | **string**| A comma-separated list of resolutions. Only secret scanning alerts with one of these resolutions are listed. Valid resolutions are &#x60;false_positive&#x60;, &#x60;wont_fix&#x60;, &#x60;revoked&#x60;, &#x60;pattern_edited&#x60;, &#x60;pattern_deleted&#x60; or &#x60;used_in_tests&#x60;. | [optional] 
 **sort** | **string**| The property to sort the results by. &#x60;created&#x60; means when the alert was created. &#x60;updated&#x60; means when the alert was updated or resolved. | [optional] [default to created]
 **direction** | **string**| The direction to sort the results by. | [optional] [default to desc]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **before** | **string**| A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. | [optional] 
 **after** | **string**| A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor. | [optional] 

### Return type

[**List<SecretScanningListAlertsForEnterprise200ResponseInner>**](SecretScanningListAlertsForEnterprise200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="secretscanninglistalertsfororg"></a>
# **SecretScanningListAlertsForOrg**
> List<SecretScanningListAlertsForEnterprise200ResponseInner> SecretScanningListAlertsForOrg (string org, string state, string secretType, string resolution, string sort, string direction, int? page, int? perPage, string before, string after)

List secret scanning alerts for an organization

Lists secret scanning alerts for eligible repositories in an organization, from newest to oldest. To use this endpoint, you must be an administrator or security manager for the organization, and you must use an access token with the `repo` scope or `security_events` scope. For public repositories, you may instead use the `public_repo` scope.  GitHub Apps must have the `secret_scanning_alerts` read permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecretScanningListAlertsForOrgExample
    {
        public void main()
        {
            var apiInstance = new SecretScanningApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var state = "open";  // string | Set to `open` or `resolved` to only list secret scanning alerts in a specific state. (optional) 
            var secretType = "secretType_example";  // string | A comma-separated list of secret types to return. By default all secret types are returned. See \"[Secret scanning patterns](https://docs.github.com/code-security/secret-scanning/secret-scanning-patterns#supported-secrets-for-advanced-security)\" for a complete list of secret types. (optional) 
            var resolution = "resolution_example";  // string | A comma-separated list of resolutions. Only secret scanning alerts with one of these resolutions are listed. Valid resolutions are `false_positive`, `wont_fix`, `revoked`, `pattern_edited`, `pattern_deleted` or `used_in_tests`. (optional) 
            var sort = "created";  // string | The property to sort the results by. `created` means when the alert was created. `updated` means when the alert was updated or resolved. (optional)  (default to created)
            var direction = "asc";  // string | The direction to sort the results by. (optional)  (default to desc)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var before = "before_example";  // string | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. To receive an initial cursor on your first request, include an empty \"before\" query string. (optional) 
            var after = "after_example";  // string | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.  To receive an initial cursor on your first request, include an empty \"after\" query string. (optional) 

            try
            {
                // List secret scanning alerts for an organization
                List&lt;SecretScanningListAlertsForEnterprise200ResponseInner&gt; result = apiInstance.SecretScanningListAlertsForOrg(org, state, secretType, resolution, sort, direction, page, perPage, before, after);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecretScanningApi.SecretScanningListAlertsForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **state** | **string**| Set to &#x60;open&#x60; or &#x60;resolved&#x60; to only list secret scanning alerts in a specific state. | [optional] 
 **secretType** | **string**| A comma-separated list of secret types to return. By default all secret types are returned. See \&quot;[Secret scanning patterns](https://docs.github.com/code-security/secret-scanning/secret-scanning-patterns#supported-secrets-for-advanced-security)\&quot; for a complete list of secret types. | [optional] 
 **resolution** | **string**| A comma-separated list of resolutions. Only secret scanning alerts with one of these resolutions are listed. Valid resolutions are &#x60;false_positive&#x60;, &#x60;wont_fix&#x60;, &#x60;revoked&#x60;, &#x60;pattern_edited&#x60;, &#x60;pattern_deleted&#x60; or &#x60;used_in_tests&#x60;. | [optional] 
 **sort** | **string**| The property to sort the results by. &#x60;created&#x60; means when the alert was created. &#x60;updated&#x60; means when the alert was updated or resolved. | [optional] [default to created]
 **direction** | **string**| The direction to sort the results by. | [optional] [default to desc]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **before** | **string**| A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. To receive an initial cursor on your first request, include an empty \&quot;before\&quot; query string. | [optional] 
 **after** | **string**| A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.  To receive an initial cursor on your first request, include an empty \&quot;after\&quot; query string. | [optional] 

### Return type

[**List<SecretScanningListAlertsForEnterprise200ResponseInner>**](SecretScanningListAlertsForEnterprise200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="secretscanninglistalertsforrepo"></a>
# **SecretScanningListAlertsForRepo**
> List<SecretScanningListAlertsForRepo200ResponseInner> SecretScanningListAlertsForRepo (string owner, string repo, string state, string secretType, string resolution, string sort, string direction, int? page, int? perPage, string before, string after)

List secret scanning alerts for a repository

Lists secret scanning alerts for an eligible repository, from newest to oldest. To use this endpoint, you must be an administrator for the repository or for the organization that owns the repository, and you must use a personal access token with the `repo` scope or `security_events` scope. For public repositories, you may instead use the `public_repo` scope.  GitHub Apps must have the `secret_scanning_alerts` read permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecretScanningListAlertsForRepoExample
    {
        public void main()
        {
            var apiInstance = new SecretScanningApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var state = "open";  // string | Set to `open` or `resolved` to only list secret scanning alerts in a specific state. (optional) 
            var secretType = "secretType_example";  // string | A comma-separated list of secret types to return. By default all secret types are returned. See \"[Secret scanning patterns](https://docs.github.com/code-security/secret-scanning/secret-scanning-patterns#supported-secrets-for-advanced-security)\" for a complete list of secret types. (optional) 
            var resolution = "resolution_example";  // string | A comma-separated list of resolutions. Only secret scanning alerts with one of these resolutions are listed. Valid resolutions are `false_positive`, `wont_fix`, `revoked`, `pattern_edited`, `pattern_deleted` or `used_in_tests`. (optional) 
            var sort = "created";  // string | The property to sort the results by. `created` means when the alert was created. `updated` means when the alert was updated or resolved. (optional)  (default to created)
            var direction = "asc";  // string | The direction to sort the results by. (optional)  (default to desc)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var before = "before_example";  // string | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. To receive an initial cursor on your first request, include an empty \"before\" query string. (optional) 
            var after = "after_example";  // string | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.  To receive an initial cursor on your first request, include an empty \"after\" query string. (optional) 

            try
            {
                // List secret scanning alerts for a repository
                List&lt;SecretScanningListAlertsForRepo200ResponseInner&gt; result = apiInstance.SecretScanningListAlertsForRepo(owner, repo, state, secretType, resolution, sort, direction, page, perPage, before, after);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecretScanningApi.SecretScanningListAlertsForRepo: " + e.Message );
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
 **state** | **string**| Set to &#x60;open&#x60; or &#x60;resolved&#x60; to only list secret scanning alerts in a specific state. | [optional] 
 **secretType** | **string**| A comma-separated list of secret types to return. By default all secret types are returned. See \&quot;[Secret scanning patterns](https://docs.github.com/code-security/secret-scanning/secret-scanning-patterns#supported-secrets-for-advanced-security)\&quot; for a complete list of secret types. | [optional] 
 **resolution** | **string**| A comma-separated list of resolutions. Only secret scanning alerts with one of these resolutions are listed. Valid resolutions are &#x60;false_positive&#x60;, &#x60;wont_fix&#x60;, &#x60;revoked&#x60;, &#x60;pattern_edited&#x60;, &#x60;pattern_deleted&#x60; or &#x60;used_in_tests&#x60;. | [optional] 
 **sort** | **string**| The property to sort the results by. &#x60;created&#x60; means when the alert was created. &#x60;updated&#x60; means when the alert was updated or resolved. | [optional] [default to created]
 **direction** | **string**| The direction to sort the results by. | [optional] [default to desc]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **before** | **string**| A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. To receive an initial cursor on your first request, include an empty \&quot;before\&quot; query string. | [optional] 
 **after** | **string**| A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.  To receive an initial cursor on your first request, include an empty \&quot;after\&quot; query string. | [optional] 

### Return type

[**List<SecretScanningListAlertsForRepo200ResponseInner>**](SecretScanningListAlertsForRepo200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="secretscanninglistlocationsforalert"></a>
# **SecretScanningListLocationsForAlert**
> List<SecretScanningListLocationsForAlert200ResponseInner> SecretScanningListLocationsForAlert (string owner, string repo, int? alertNumber, int? page, int? perPage)

List locations for a secret scanning alert

Lists all locations for a given secret scanning alert for an eligible repository. To use this endpoint, you must be an administrator for the repository or for the organization that owns the repository, and you must use a personal access token with the `repo` scope or `security_events` scope. For public repositories, you may instead use the `public_repo` scope.  GitHub Apps must have the `secret_scanning_alerts` read permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecretScanningListLocationsForAlertExample
    {
        public void main()
        {
            var apiInstance = new SecretScanningApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var alertNumber = 56;  // int? | The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the `number` field in the response from the `GET /repos/{owner}/{repo}/code-scanning/alerts` operation.
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)

            try
            {
                // List locations for a secret scanning alert
                List&lt;SecretScanningListLocationsForAlert200ResponseInner&gt; result = apiInstance.SecretScanningListLocationsForAlert(owner, repo, alertNumber, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecretScanningApi.SecretScanningListLocationsForAlert: " + e.Message );
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

### Return type

[**List<SecretScanningListLocationsForAlert200ResponseInner>**](SecretScanningListLocationsForAlert200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="secretscanningupdatealert"></a>
# **SecretScanningUpdateAlert**
> SecretScanningListAlertsForRepo200ResponseInner SecretScanningUpdateAlert (string owner, string repo, int? alertNumber, SecretScanningUpdateAlertRequest secretScanningUpdateAlertRequest)

Update a secret scanning alert

Updates the status of a secret scanning alert in an eligible repository. To use this endpoint, you must be an administrator for the repository or for the organization that owns the repository, and you must use a personal access token with the `repo` scope or `security_events` scope. For public repositories, you may instead use the `public_repo` scope.  GitHub Apps must have the `secret_scanning_alerts` write permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecretScanningUpdateAlertExample
    {
        public void main()
        {
            var apiInstance = new SecretScanningApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var alertNumber = 56;  // int? | The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the `number` field in the response from the `GET /repos/{owner}/{repo}/code-scanning/alerts` operation.
            var secretScanningUpdateAlertRequest = new SecretScanningUpdateAlertRequest(); // SecretScanningUpdateAlertRequest | 

            try
            {
                // Update a secret scanning alert
                SecretScanningListAlertsForRepo200ResponseInner result = apiInstance.SecretScanningUpdateAlert(owner, repo, alertNumber, secretScanningUpdateAlertRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecretScanningApi.SecretScanningUpdateAlert: " + e.Message );
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
 **secretScanningUpdateAlertRequest** | [**SecretScanningUpdateAlertRequest**](SecretScanningUpdateAlertRequest.md)|  | 

### Return type

[**SecretScanningListAlertsForRepo200ResponseInner**](SecretScanningListAlertsForRepo200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

