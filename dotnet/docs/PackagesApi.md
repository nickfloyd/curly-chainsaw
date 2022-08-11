# Org.OpenAPITools.Api.PackagesApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PackagesDeletePackageForAuthenticatedUser**](PackagesApi.md#packagesdeletepackageforauthenticateduser) | **DELETE** /user/packages/{package_type}/{package_name} | Delete a package for the authenticated user
[**PackagesDeletePackageForOrg**](PackagesApi.md#packagesdeletepackagefororg) | **DELETE** /orgs/{org}/packages/{package_type}/{package_name} | Delete a package for an organization
[**PackagesDeletePackageForUser**](PackagesApi.md#packagesdeletepackageforuser) | **DELETE** /users/{username}/packages/{package_type}/{package_name} | Delete a package for a user
[**PackagesDeletePackageVersionForAuthenticatedUser**](PackagesApi.md#packagesdeletepackageversionforauthenticateduser) | **DELETE** /user/packages/{package_type}/{package_name}/versions/{package_version_id} | Delete a package version for the authenticated user
[**PackagesDeletePackageVersionForOrg**](PackagesApi.md#packagesdeletepackageversionfororg) | **DELETE** /orgs/{org}/packages/{package_type}/{package_name}/versions/{package_version_id} | Delete package version for an organization
[**PackagesDeletePackageVersionForUser**](PackagesApi.md#packagesdeletepackageversionforuser) | **DELETE** /users/{username}/packages/{package_type}/{package_name}/versions/{package_version_id} | Delete package version for a user
[**PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUser**](PackagesApi.md#packagesgetallpackageversionsforpackageownedbyauthenticateduser) | **GET** /user/packages/{package_type}/{package_name}/versions | Get all package versions for a package owned by the authenticated user
[**PackagesGetAllPackageVersionsForPackageOwnedByOrg**](PackagesApi.md#packagesgetallpackageversionsforpackageownedbyorg) | **GET** /orgs/{org}/packages/{package_type}/{package_name}/versions | Get all package versions for a package owned by an organization
[**PackagesGetAllPackageVersionsForPackageOwnedByUser**](PackagesApi.md#packagesgetallpackageversionsforpackageownedbyuser) | **GET** /users/{username}/packages/{package_type}/{package_name}/versions | Get all package versions for a package owned by a user
[**PackagesGetPackageForAuthenticatedUser**](PackagesApi.md#packagesgetpackageforauthenticateduser) | **GET** /user/packages/{package_type}/{package_name} | Get a package for the authenticated user
[**PackagesGetPackageForOrganization**](PackagesApi.md#packagesgetpackagefororganization) | **GET** /orgs/{org}/packages/{package_type}/{package_name} | Get a package for an organization
[**PackagesGetPackageForUser**](PackagesApi.md#packagesgetpackageforuser) | **GET** /users/{username}/packages/{package_type}/{package_name} | Get a package for a user
[**PackagesGetPackageVersionForAuthenticatedUser**](PackagesApi.md#packagesgetpackageversionforauthenticateduser) | **GET** /user/packages/{package_type}/{package_name}/versions/{package_version_id} | Get a package version for the authenticated user
[**PackagesGetPackageVersionForOrganization**](PackagesApi.md#packagesgetpackageversionfororganization) | **GET** /orgs/{org}/packages/{package_type}/{package_name}/versions/{package_version_id} | Get a package version for an organization
[**PackagesGetPackageVersionForUser**](PackagesApi.md#packagesgetpackageversionforuser) | **GET** /users/{username}/packages/{package_type}/{package_name}/versions/{package_version_id} | Get a package version for a user
[**PackagesListPackagesForAuthenticatedUser**](PackagesApi.md#packageslistpackagesforauthenticateduser) | **GET** /user/packages | List packages for the authenticated user&#39;s namespace
[**PackagesListPackagesForOrganization**](PackagesApi.md#packageslistpackagesfororganization) | **GET** /orgs/{org}/packages | List packages for an organization
[**PackagesListPackagesForUser**](PackagesApi.md#packageslistpackagesforuser) | **GET** /users/{username}/packages | List packages for a user
[**PackagesRestorePackageForAuthenticatedUser**](PackagesApi.md#packagesrestorepackageforauthenticateduser) | **POST** /user/packages/{package_type}/{package_name}/restore | Restore a package for the authenticated user
[**PackagesRestorePackageForOrg**](PackagesApi.md#packagesrestorepackagefororg) | **POST** /orgs/{org}/packages/{package_type}/{package_name}/restore | Restore a package for an organization
[**PackagesRestorePackageForUser**](PackagesApi.md#packagesrestorepackageforuser) | **POST** /users/{username}/packages/{package_type}/{package_name}/restore | Restore a package for a user
[**PackagesRestorePackageVersionForAuthenticatedUser**](PackagesApi.md#packagesrestorepackageversionforauthenticateduser) | **POST** /user/packages/{package_type}/{package_name}/versions/{package_version_id}/restore | Restore a package version for the authenticated user
[**PackagesRestorePackageVersionForOrg**](PackagesApi.md#packagesrestorepackageversionfororg) | **POST** /orgs/{org}/packages/{package_type}/{package_name}/versions/{package_version_id}/restore | Restore package version for an organization
[**PackagesRestorePackageVersionForUser**](PackagesApi.md#packagesrestorepackageversionforuser) | **POST** /users/{username}/packages/{package_type}/{package_name}/versions/{package_version_id}/restore | Restore package version for a user


<a name="packagesdeletepackageforauthenticateduser"></a>
# **PackagesDeletePackageForAuthenticatedUser**
> void PackagesDeletePackageForAuthenticatedUser (string packageType, string packageName)

Delete a package for the authenticated user

Deletes a package owned by the authenticated user. You cannot delete a public package if any version of the package has more than 5,000 downloads. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must authenticate using an access token with the `packages:read` and `packages:delete` scopes. If `package_type` is not `container`, your token must also include the `repo` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesDeletePackageForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var packageName = "packageName_example";  // string | The name of the package.

            try
            {
                // Delete a package for the authenticated user
                apiInstance.PackagesDeletePackageForAuthenticatedUser(packageType, packageName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesDeletePackageForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **packageName** | **string**| The name of the package. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagesdeletepackagefororg"></a>
# **PackagesDeletePackageForOrg**
> void PackagesDeletePackageForOrg (string packageType, string packageName, string org)

Delete a package for an organization

Deletes an entire package in an organization. You cannot delete a public package if any version of the package has more than 5,000 downloads. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must have admin permissions in the organization and authenticate using an access token with the `packages:read` and `packages:delete` scopes. In addition: - If `package_type` is not `container`, your token must also include the `repo` scope. - If `package_type` is `container`, you must also have admin permissions to the container you want to delete.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesDeletePackageForOrgExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var packageName = "packageName_example";  // string | The name of the package.
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // Delete a package for an organization
                apiInstance.PackagesDeletePackageForOrg(packageType, packageName, org);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesDeletePackageForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **packageName** | **string**| The name of the package. | 
 **org** | **string**| The organization name. The name is not case sensitive. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagesdeletepackageforuser"></a>
# **PackagesDeletePackageForUser**
> void PackagesDeletePackageForUser (string packageType, string packageName, string username)

Delete a package for a user

Deletes an entire package for a user. You cannot delete a public package if any version of the package has more than 5,000 downloads. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must authenticate using an access token with the `packages:read` and `packages:delete` scopes. In addition: - If `package_type` is not `container`, your token must also include the `repo` scope. - If `package_type` is `container`, you must also have admin permissions to the container you want to delete.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesDeletePackageForUserExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var packageName = "packageName_example";  // string | The name of the package.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Delete a package for a user
                apiInstance.PackagesDeletePackageForUser(packageType, packageName, username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesDeletePackageForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **packageName** | **string**| The name of the package. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagesdeletepackageversionforauthenticateduser"></a>
# **PackagesDeletePackageVersionForAuthenticatedUser**
> void PackagesDeletePackageVersionForAuthenticatedUser (string packageType, string packageName, int? packageVersionId)

Delete a package version for the authenticated user

Deletes a specific package version for a package owned by the authenticated user.  If the package is public and the package version has more than 5,000 downloads, you cannot delete the package version. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must have admin permissions in the organization and authenticate using an access token with the `packages:read` and `packages:delete` scopes. If `package_type` is not `container`, your token must also include the `repo` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesDeletePackageVersionForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var packageName = "packageName_example";  // string | The name of the package.
            var packageVersionId = 56;  // int? | Unique identifier of the package version.

            try
            {
                // Delete a package version for the authenticated user
                apiInstance.PackagesDeletePackageVersionForAuthenticatedUser(packageType, packageName, packageVersionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesDeletePackageVersionForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **packageName** | **string**| The name of the package. | 
 **packageVersionId** | **int?**| Unique identifier of the package version. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagesdeletepackageversionfororg"></a>
# **PackagesDeletePackageVersionForOrg**
> void PackagesDeletePackageVersionForOrg (string packageType, string packageName, string org, int? packageVersionId)

Delete package version for an organization

Deletes a specific package version in an organization. If the package is public and the package version has more than 5,000 downloads, you cannot delete the package version. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must have admin permissions in the organization and authenticate using an access token with the `packages:read` and `packages:delete` scopes. In addition: - If `package_type` is not `container`, your token must also include the `repo` scope. - If `package_type` is `container`, you must also have admin permissions to the container you want to delete.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesDeletePackageVersionForOrgExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var packageName = "packageName_example";  // string | The name of the package.
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var packageVersionId = 56;  // int? | Unique identifier of the package version.

            try
            {
                // Delete package version for an organization
                apiInstance.PackagesDeletePackageVersionForOrg(packageType, packageName, org, packageVersionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesDeletePackageVersionForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **packageName** | **string**| The name of the package. | 
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **packageVersionId** | **int?**| Unique identifier of the package version. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagesdeletepackageversionforuser"></a>
# **PackagesDeletePackageVersionForUser**
> void PackagesDeletePackageVersionForUser (string packageType, string packageName, string username, int? packageVersionId)

Delete package version for a user

Deletes a specific package version for a user. If the package is public and the package version has more than 5,000 downloads, you cannot delete the package version. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must authenticate using an access token with the `packages:read` and `packages:delete` scopes. In addition: - If `package_type` is not `container`, your token must also include the `repo` scope. - If `package_type` is `container`, you must also have admin permissions to the container you want to delete.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesDeletePackageVersionForUserExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var packageName = "packageName_example";  // string | The name of the package.
            var username = "username_example";  // string | The handle for the GitHub user account.
            var packageVersionId = 56;  // int? | Unique identifier of the package version.

            try
            {
                // Delete package version for a user
                apiInstance.PackagesDeletePackageVersionForUser(packageType, packageName, username, packageVersionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesDeletePackageVersionForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **packageName** | **string**| The name of the package. | 
 **username** | **string**| The handle for the GitHub user account. | 
 **packageVersionId** | **int?**| Unique identifier of the package version. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagesgetallpackageversionsforpackageownedbyauthenticateduser"></a>
# **PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUser**
> List<PackageVersion> PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUser (string packageType, string packageName, int? page, int? perPage, string state)

Get all package versions for a package owned by the authenticated user

Returns all package versions for a package owned by the authenticated user.  To use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var packageName = "packageName_example";  // string | The name of the package.
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var state = "active";  // string | The state of the package, either active or deleted. (optional)  (default to active)

            try
            {
                // Get all package versions for a package owned by the authenticated user
                List&lt;PackageVersion&gt; result = apiInstance.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUser(packageType, packageName, page, perPage, state);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **packageName** | **string**| The name of the package. | 
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **state** | **string**| The state of the package, either active or deleted. | [optional] [default to active]

### Return type

[**List<PackageVersion>**](PackageVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagesgetallpackageversionsforpackageownedbyorg"></a>
# **PackagesGetAllPackageVersionsForPackageOwnedByOrg**
> List<PackageVersion> PackagesGetAllPackageVersionsForPackageOwnedByOrg (string packageType, string packageName, string org, int? page, int? perPage, string state)

Get all package versions for a package owned by an organization

Returns all package versions for a package owned by an organization.  To use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesGetAllPackageVersionsForPackageOwnedByOrgExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var packageName = "packageName_example";  // string | The name of the package.
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var state = "active";  // string | The state of the package, either active or deleted. (optional)  (default to active)

            try
            {
                // Get all package versions for a package owned by an organization
                List&lt;PackageVersion&gt; result = apiInstance.PackagesGetAllPackageVersionsForPackageOwnedByOrg(packageType, packageName, org, page, perPage, state);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesGetAllPackageVersionsForPackageOwnedByOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **packageName** | **string**| The name of the package. | 
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **state** | **string**| The state of the package, either active or deleted. | [optional] [default to active]

### Return type

[**List<PackageVersion>**](PackageVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagesgetallpackageversionsforpackageownedbyuser"></a>
# **PackagesGetAllPackageVersionsForPackageOwnedByUser**
> List<PackageVersion> PackagesGetAllPackageVersionsForPackageOwnedByUser (string packageType, string packageName, string username)

Get all package versions for a package owned by a user

Returns all package versions for a public package owned by a specified user.  To use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesGetAllPackageVersionsForPackageOwnedByUserExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var packageName = "packageName_example";  // string | The name of the package.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Get all package versions for a package owned by a user
                List&lt;PackageVersion&gt; result = apiInstance.PackagesGetAllPackageVersionsForPackageOwnedByUser(packageType, packageName, username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesGetAllPackageVersionsForPackageOwnedByUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **packageName** | **string**| The name of the package. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

[**List<PackageVersion>**](PackageVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagesgetpackageforauthenticateduser"></a>
# **PackagesGetPackageForAuthenticatedUser**
> Package PackagesGetPackageForAuthenticatedUser (string packageType, string packageName)

Get a package for the authenticated user

Gets a specific package for a package owned by the authenticated user.  To use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesGetPackageForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var packageName = "packageName_example";  // string | The name of the package.

            try
            {
                // Get a package for the authenticated user
                Package result = apiInstance.PackagesGetPackageForAuthenticatedUser(packageType, packageName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesGetPackageForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **packageName** | **string**| The name of the package. | 

### Return type

[**Package**](Package.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagesgetpackagefororganization"></a>
# **PackagesGetPackageForOrganization**
> Package PackagesGetPackageForOrganization (string packageType, string packageName, string org)

Get a package for an organization

Gets a specific package in an organization.  To use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesGetPackageForOrganizationExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var packageName = "packageName_example";  // string | The name of the package.
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // Get a package for an organization
                Package result = apiInstance.PackagesGetPackageForOrganization(packageType, packageName, org);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesGetPackageForOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **packageName** | **string**| The name of the package. | 
 **org** | **string**| The organization name. The name is not case sensitive. | 

### Return type

[**Package**](Package.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagesgetpackageforuser"></a>
# **PackagesGetPackageForUser**
> Package PackagesGetPackageForUser (string packageType, string packageName, string username)

Get a package for a user

Gets a specific package metadata for a public package owned by a user.  To use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesGetPackageForUserExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var packageName = "packageName_example";  // string | The name of the package.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Get a package for a user
                Package result = apiInstance.PackagesGetPackageForUser(packageType, packageName, username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesGetPackageForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **packageName** | **string**| The name of the package. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

[**Package**](Package.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagesgetpackageversionforauthenticateduser"></a>
# **PackagesGetPackageVersionForAuthenticatedUser**
> PackageVersion PackagesGetPackageVersionForAuthenticatedUser (string packageType, string packageName, int? packageVersionId)

Get a package version for the authenticated user

Gets a specific package version for a package owned by the authenticated user.  To use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesGetPackageVersionForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var packageName = "packageName_example";  // string | The name of the package.
            var packageVersionId = 56;  // int? | Unique identifier of the package version.

            try
            {
                // Get a package version for the authenticated user
                PackageVersion result = apiInstance.PackagesGetPackageVersionForAuthenticatedUser(packageType, packageName, packageVersionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesGetPackageVersionForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **packageName** | **string**| The name of the package. | 
 **packageVersionId** | **int?**| Unique identifier of the package version. | 

### Return type

[**PackageVersion**](PackageVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagesgetpackageversionfororganization"></a>
# **PackagesGetPackageVersionForOrganization**
> PackageVersion PackagesGetPackageVersionForOrganization (string packageType, string packageName, string org, int? packageVersionId)

Get a package version for an organization

Gets a specific package version in an organization.  You must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesGetPackageVersionForOrganizationExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var packageName = "packageName_example";  // string | The name of the package.
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var packageVersionId = 56;  // int? | Unique identifier of the package version.

            try
            {
                // Get a package version for an organization
                PackageVersion result = apiInstance.PackagesGetPackageVersionForOrganization(packageType, packageName, org, packageVersionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesGetPackageVersionForOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **packageName** | **string**| The name of the package. | 
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **packageVersionId** | **int?**| Unique identifier of the package version. | 

### Return type

[**PackageVersion**](PackageVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagesgetpackageversionforuser"></a>
# **PackagesGetPackageVersionForUser**
> PackageVersion PackagesGetPackageVersionForUser (string packageType, string packageName, int? packageVersionId, string username)

Get a package version for a user

Gets a specific package version for a public package owned by a specified user.  At this time, to use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesGetPackageVersionForUserExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var packageName = "packageName_example";  // string | The name of the package.
            var packageVersionId = 56;  // int? | Unique identifier of the package version.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Get a package version for a user
                PackageVersion result = apiInstance.PackagesGetPackageVersionForUser(packageType, packageName, packageVersionId, username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesGetPackageVersionForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **packageName** | **string**| The name of the package. | 
 **packageVersionId** | **int?**| Unique identifier of the package version. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

[**PackageVersion**](PackageVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packageslistpackagesforauthenticateduser"></a>
# **PackagesListPackagesForAuthenticatedUser**
> List<Package> PackagesListPackagesForAuthenticatedUser (string packageType, string visibility)

List packages for the authenticated user's namespace

Lists packages owned by the authenticated user within the user's namespace.  To use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesListPackagesForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var visibility = "public";  // string | The selected visibility of the packages. Only `container` package_types currently support `internal` visibility properly. For other ecosystems `internal` is synonymous with `private`. This parameter is optional and only filters an existing result set. (optional) 

            try
            {
                // List packages for the authenticated user's namespace
                List&lt;Package&gt; result = apiInstance.PackagesListPackagesForAuthenticatedUser(packageType, visibility);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesListPackagesForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **visibility** | **string**| The selected visibility of the packages. Only &#x60;container&#x60; package_types currently support &#x60;internal&#x60; visibility properly. For other ecosystems &#x60;internal&#x60; is synonymous with &#x60;private&#x60;. This parameter is optional and only filters an existing result set. | [optional] 

### Return type

[**List<Package>**](Package.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packageslistpackagesfororganization"></a>
# **PackagesListPackagesForOrganization**
> List<Package> PackagesListPackagesForOrganization (string packageType, string org, string visibility)

List packages for an organization

Lists all packages in an organization readable by the user.  To use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesListPackagesForOrganizationExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var visibility = "public";  // string | The selected visibility of the packages. Only `container` package_types currently support `internal` visibility properly. For other ecosystems `internal` is synonymous with `private`. This parameter is optional and only filters an existing result set. (optional) 

            try
            {
                // List packages for an organization
                List&lt;Package&gt; result = apiInstance.PackagesListPackagesForOrganization(packageType, org, visibility);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesListPackagesForOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **visibility** | **string**| The selected visibility of the packages. Only &#x60;container&#x60; package_types currently support &#x60;internal&#x60; visibility properly. For other ecosystems &#x60;internal&#x60; is synonymous with &#x60;private&#x60;. This parameter is optional and only filters an existing result set. | [optional] 

### Return type

[**List<Package>**](Package.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packageslistpackagesforuser"></a>
# **PackagesListPackagesForUser**
> List<Package> PackagesListPackagesForUser (string packageType, string username, string visibility)

List packages for a user

Lists all packages in a user's namespace for which the requesting user has access.  To use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesListPackagesForUserExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var username = "username_example";  // string | The handle for the GitHub user account.
            var visibility = "public";  // string | The selected visibility of the packages. Only `container` package_types currently support `internal` visibility properly. For other ecosystems `internal` is synonymous with `private`. This parameter is optional and only filters an existing result set. (optional) 

            try
            {
                // List packages for a user
                List&lt;Package&gt; result = apiInstance.PackagesListPackagesForUser(packageType, username, visibility);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesListPackagesForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **username** | **string**| The handle for the GitHub user account. | 
 **visibility** | **string**| The selected visibility of the packages. Only &#x60;container&#x60; package_types currently support &#x60;internal&#x60; visibility properly. For other ecosystems &#x60;internal&#x60; is synonymous with &#x60;private&#x60;. This parameter is optional and only filters an existing result set. | [optional] 

### Return type

[**List<Package>**](Package.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagesrestorepackageforauthenticateduser"></a>
# **PackagesRestorePackageForAuthenticatedUser**
> void PackagesRestorePackageForAuthenticatedUser (string packageType, string packageName, string token)

Restore a package for the authenticated user

Restores a package owned by the authenticated user.  You can restore a deleted package under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package's namespace first.  To use this endpoint, you must authenticate using an access token with the `packages:read` and `packages:write` scopes. If `package_type` is not `container`, your token must also include the `repo` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesRestorePackageForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var packageName = "packageName_example";  // string | The name of the package.
            var token = "token_example";  // string | package token (optional) 

            try
            {
                // Restore a package for the authenticated user
                apiInstance.PackagesRestorePackageForAuthenticatedUser(packageType, packageName, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesRestorePackageForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **packageName** | **string**| The name of the package. | 
 **token** | **string**| package token | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagesrestorepackagefororg"></a>
# **PackagesRestorePackageForOrg**
> void PackagesRestorePackageForOrg (string packageType, string packageName, string org, string token)

Restore a package for an organization

Restores an entire package in an organization.  You can restore a deleted package under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package's namespace first.  To use this endpoint, you must have admin permissions in the organization and authenticate using an access token with the `packages:read` and `packages:write` scopes. In addition: - If `package_type` is not `container`, your token must also include the `repo` scope. - If `package_type` is `container`, you must also have admin permissions to the container that you want to restore.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesRestorePackageForOrgExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var packageName = "packageName_example";  // string | The name of the package.
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var token = "token_example";  // string | package token (optional) 

            try
            {
                // Restore a package for an organization
                apiInstance.PackagesRestorePackageForOrg(packageType, packageName, org, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesRestorePackageForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **packageName** | **string**| The name of the package. | 
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **token** | **string**| package token | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagesrestorepackageforuser"></a>
# **PackagesRestorePackageForUser**
> void PackagesRestorePackageForUser (string packageType, string packageName, string username, string token)

Restore a package for a user

Restores an entire package for a user.  You can restore a deleted package under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package's namespace first.  To use this endpoint, you must authenticate using an access token with the `packages:read` and `packages:write` scopes. In addition: - If `package_type` is not `container`, your token must also include the `repo` scope. - If `package_type` is `container`, you must also have admin permissions to the container that you want to restore.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesRestorePackageForUserExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var packageName = "packageName_example";  // string | The name of the package.
            var username = "username_example";  // string | The handle for the GitHub user account.
            var token = "token_example";  // string | package token (optional) 

            try
            {
                // Restore a package for a user
                apiInstance.PackagesRestorePackageForUser(packageType, packageName, username, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesRestorePackageForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **packageName** | **string**| The name of the package. | 
 **username** | **string**| The handle for the GitHub user account. | 
 **token** | **string**| package token | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagesrestorepackageversionforauthenticateduser"></a>
# **PackagesRestorePackageVersionForAuthenticatedUser**
> void PackagesRestorePackageVersionForAuthenticatedUser (string packageType, string packageName, int? packageVersionId)

Restore a package version for the authenticated user

Restores a package version owned by the authenticated user.  You can restore a deleted package version under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package's namespace first.  To use this endpoint, you must authenticate using an access token with the `packages:read` and `packages:write` scopes. If `package_type` is not `container`, your token must also include the `repo` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesRestorePackageVersionForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var packageName = "packageName_example";  // string | The name of the package.
            var packageVersionId = 56;  // int? | Unique identifier of the package version.

            try
            {
                // Restore a package version for the authenticated user
                apiInstance.PackagesRestorePackageVersionForAuthenticatedUser(packageType, packageName, packageVersionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesRestorePackageVersionForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **packageName** | **string**| The name of the package. | 
 **packageVersionId** | **int?**| Unique identifier of the package version. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagesrestorepackageversionfororg"></a>
# **PackagesRestorePackageVersionForOrg**
> void PackagesRestorePackageVersionForOrg (string packageType, string packageName, string org, int? packageVersionId)

Restore package version for an organization

Restores a specific package version in an organization.  You can restore a deleted package under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package's namespace first.  To use this endpoint, you must have admin permissions in the organization and authenticate using an access token with the `packages:read` and `packages:write` scopes. In addition: - If `package_type` is not `container`, your token must also include the `repo` scope. - If `package_type` is `container`, you must also have admin permissions to the container that you want to restore.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesRestorePackageVersionForOrgExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var packageName = "packageName_example";  // string | The name of the package.
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var packageVersionId = 56;  // int? | Unique identifier of the package version.

            try
            {
                // Restore package version for an organization
                apiInstance.PackagesRestorePackageVersionForOrg(packageType, packageName, org, packageVersionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesRestorePackageVersionForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **packageName** | **string**| The name of the package. | 
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **packageVersionId** | **int?**| Unique identifier of the package version. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="packagesrestorepackageversionforuser"></a>
# **PackagesRestorePackageVersionForUser**
> void PackagesRestorePackageVersionForUser (string packageType, string packageName, string username, int? packageVersionId)

Restore package version for a user

Restores a specific package version for a user.  You can restore a deleted package under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package's namespace first.  To use this endpoint, you must authenticate using an access token with the `packages:read` and `packages:write` scopes. In addition: - If `package_type` is not `container`, your token must also include the `repo` scope. - If `package_type` is `container`, you must also have admin permissions to the container that you want to restore.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PackagesRestorePackageVersionForUserExample
    {
        public void main()
        {
            var apiInstance = new PackagesApi();
            var packageType = "npm";  // string | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
            var packageName = "packageName_example";  // string | The name of the package.
            var username = "username_example";  // string | The handle for the GitHub user account.
            var packageVersionId = 56;  // int? | Unique identifier of the package version.

            try
            {
                // Restore package version for a user
                apiInstance.PackagesRestorePackageVersionForUser(packageType, packageName, username, packageVersionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PackagesApi.PackagesRestorePackageVersionForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageType** | **string**| The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. | 
 **packageName** | **string**| The name of the package. | 
 **username** | **string**| The handle for the GitHub user account. | 
 **packageVersionId** | **int?**| Unique identifier of the package version. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

