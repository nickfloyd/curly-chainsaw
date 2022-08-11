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
    public interface IPackagesApi
    {
        /// <summary>
        /// Delete a package for the authenticated user Deletes a package owned by the authenticated user. You cannot delete a public package if any version of the package has more than 5,000 downloads. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:delete&#x60; scopes. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <returns></returns>
        void PackagesDeletePackageForAuthenticatedUser (string packageType, string packageName);
        /// <summary>
        /// Delete a package for an organization Deletes an entire package in an organization. You cannot delete a public package if any version of the package has more than 5,000 downloads. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must have admin permissions in the organization and authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:delete&#x60; scopes. In addition: - If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope. - If &#x60;package_type&#x60; is &#x60;container&#x60;, you must also have admin permissions to the container you want to delete.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns></returns>
        void PackagesDeletePackageForOrg (string packageType, string packageName, string org);
        /// <summary>
        /// Delete a package for a user Deletes an entire package for a user. You cannot delete a public package if any version of the package has more than 5,000 downloads. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:delete&#x60; scopes. In addition: - If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope. - If &#x60;package_type&#x60; is &#x60;container&#x60;, you must also have admin permissions to the container you want to delete.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        void PackagesDeletePackageForUser (string packageType, string packageName, string username);
        /// <summary>
        /// Delete a package version for the authenticated user Deletes a specific package version for a package owned by the authenticated user.  If the package is public and the package version has more than 5,000 downloads, you cannot delete the package version. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must have admin permissions in the organization and authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:delete&#x60; scopes. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="packageVersionId">Unique identifier of the package version.</param>
        /// <returns></returns>
        void PackagesDeletePackageVersionForAuthenticatedUser (string packageType, string packageName, int? packageVersionId);
        /// <summary>
        /// Delete package version for an organization Deletes a specific package version in an organization. If the package is public and the package version has more than 5,000 downloads, you cannot delete the package version. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must have admin permissions in the organization and authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:delete&#x60; scopes. In addition: - If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope. - If &#x60;package_type&#x60; is &#x60;container&#x60;, you must also have admin permissions to the container you want to delete.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="packageVersionId">Unique identifier of the package version.</param>
        /// <returns></returns>
        void PackagesDeletePackageVersionForOrg (string packageType, string packageName, string org, int? packageVersionId);
        /// <summary>
        /// Delete package version for a user Deletes a specific package version for a user. If the package is public and the package version has more than 5,000 downloads, you cannot delete the package version. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:delete&#x60; scopes. In addition: - If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope. - If &#x60;package_type&#x60; is &#x60;container&#x60;, you must also have admin permissions to the container you want to delete.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="packageVersionId">Unique identifier of the package version.</param>
        /// <returns></returns>
        void PackagesDeletePackageVersionForUser (string packageType, string packageName, string username, int? packageVersionId);
        /// <summary>
        /// Get all package versions for a package owned by the authenticated user Returns all package versions for a package owned by the authenticated user.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="state">The state of the package, either active or deleted.</param>
        /// <returns>List&lt;PackageVersion&gt;</returns>
        List<PackageVersion> PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUser (string packageType, string packageName, int? page, int? perPage, string state);
        /// <summary>
        /// Get all package versions for a package owned by an organization Returns all package versions for a package owned by an organization.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="state">The state of the package, either active or deleted.</param>
        /// <returns>List&lt;PackageVersion&gt;</returns>
        List<PackageVersion> PackagesGetAllPackageVersionsForPackageOwnedByOrg (string packageType, string packageName, string org, int? page, int? perPage, string state);
        /// <summary>
        /// Get all package versions for a package owned by a user Returns all package versions for a public package owned by a specified user.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>List&lt;PackageVersion&gt;</returns>
        List<PackageVersion> PackagesGetAllPackageVersionsForPackageOwnedByUser (string packageType, string packageName, string username);
        /// <summary>
        /// Get a package for the authenticated user Gets a specific package for a package owned by the authenticated user.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <returns>Package</returns>
        Package PackagesGetPackageForAuthenticatedUser (string packageType, string packageName);
        /// <summary>
        /// Get a package for an organization Gets a specific package in an organization.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>Package</returns>
        Package PackagesGetPackageForOrganization (string packageType, string packageName, string org);
        /// <summary>
        /// Get a package for a user Gets a specific package metadata for a public package owned by a user.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>Package</returns>
        Package PackagesGetPackageForUser (string packageType, string packageName, string username);
        /// <summary>
        /// Get a package version for the authenticated user Gets a specific package version for a package owned by the authenticated user.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="packageVersionId">Unique identifier of the package version.</param>
        /// <returns>PackageVersion</returns>
        PackageVersion PackagesGetPackageVersionForAuthenticatedUser (string packageType, string packageName, int? packageVersionId);
        /// <summary>
        /// Get a package version for an organization Gets a specific package version in an organization.  You must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="packageVersionId">Unique identifier of the package version.</param>
        /// <returns>PackageVersion</returns>
        PackageVersion PackagesGetPackageVersionForOrganization (string packageType, string packageName, string org, int? packageVersionId);
        /// <summary>
        /// Get a package version for a user Gets a specific package version for a public package owned by a specified user.  At this time, to use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="packageVersionId">Unique identifier of the package version.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>PackageVersion</returns>
        PackageVersion PackagesGetPackageVersionForUser (string packageType, string packageName, int? packageVersionId, string username);
        /// <summary>
        /// List packages for the authenticated user&#39;s namespace Lists packages owned by the authenticated user within the user&#39;s namespace.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="visibility">The selected visibility of the packages. Only &#x60;container&#x60; package_types currently support &#x60;internal&#x60; visibility properly. For other ecosystems &#x60;internal&#x60; is synonymous with &#x60;private&#x60;. This parameter is optional and only filters an existing result set.</param>
        /// <returns>List&lt;Package&gt;</returns>
        List<Package> PackagesListPackagesForAuthenticatedUser (string packageType, string visibility);
        /// <summary>
        /// List packages for an organization Lists all packages in an organization readable by the user.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="visibility">The selected visibility of the packages. Only &#x60;container&#x60; package_types currently support &#x60;internal&#x60; visibility properly. For other ecosystems &#x60;internal&#x60; is synonymous with &#x60;private&#x60;. This parameter is optional and only filters an existing result set.</param>
        /// <returns>List&lt;Package&gt;</returns>
        List<Package> PackagesListPackagesForOrganization (string packageType, string org, string visibility);
        /// <summary>
        /// List packages for a user Lists all packages in a user&#39;s namespace for which the requesting user has access.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="visibility">The selected visibility of the packages. Only &#x60;container&#x60; package_types currently support &#x60;internal&#x60; visibility properly. For other ecosystems &#x60;internal&#x60; is synonymous with &#x60;private&#x60;. This parameter is optional and only filters an existing result set.</param>
        /// <returns>List&lt;Package&gt;</returns>
        List<Package> PackagesListPackagesForUser (string packageType, string username, string visibility);
        /// <summary>
        /// Restore a package for the authenticated user Restores a package owned by the authenticated user.  You can restore a deleted package under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package&#39;s namespace first.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:write&#x60; scopes. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="token">package token</param>
        /// <returns></returns>
        void PackagesRestorePackageForAuthenticatedUser (string packageType, string packageName, string token);
        /// <summary>
        /// Restore a package for an organization Restores an entire package in an organization.  You can restore a deleted package under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package&#39;s namespace first.  To use this endpoint, you must have admin permissions in the organization and authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:write&#x60; scopes. In addition: - If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope. - If &#x60;package_type&#x60; is &#x60;container&#x60;, you must also have admin permissions to the container that you want to restore.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="token">package token</param>
        /// <returns></returns>
        void PackagesRestorePackageForOrg (string packageType, string packageName, string org, string token);
        /// <summary>
        /// Restore a package for a user Restores an entire package for a user.  You can restore a deleted package under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package&#39;s namespace first.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:write&#x60; scopes. In addition: - If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope. - If &#x60;package_type&#x60; is &#x60;container&#x60;, you must also have admin permissions to the container that you want to restore.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="token">package token</param>
        /// <returns></returns>
        void PackagesRestorePackageForUser (string packageType, string packageName, string username, string token);
        /// <summary>
        /// Restore a package version for the authenticated user Restores a package version owned by the authenticated user.  You can restore a deleted package version under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package&#39;s namespace first.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:write&#x60; scopes. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="packageVersionId">Unique identifier of the package version.</param>
        /// <returns></returns>
        void PackagesRestorePackageVersionForAuthenticatedUser (string packageType, string packageName, int? packageVersionId);
        /// <summary>
        /// Restore package version for an organization Restores a specific package version in an organization.  You can restore a deleted package under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package&#39;s namespace first.  To use this endpoint, you must have admin permissions in the organization and authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:write&#x60; scopes. In addition: - If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope. - If &#x60;package_type&#x60; is &#x60;container&#x60;, you must also have admin permissions to the container that you want to restore.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="packageVersionId">Unique identifier of the package version.</param>
        /// <returns></returns>
        void PackagesRestorePackageVersionForOrg (string packageType, string packageName, string org, int? packageVersionId);
        /// <summary>
        /// Restore package version for a user Restores a specific package version for a user.  You can restore a deleted package under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package&#39;s namespace first.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:write&#x60; scopes. In addition: - If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope. - If &#x60;package_type&#x60; is &#x60;container&#x60;, you must also have admin permissions to the container that you want to restore.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="packageVersionId">Unique identifier of the package version.</param>
        /// <returns></returns>
        void PackagesRestorePackageVersionForUser (string packageType, string packageName, string username, int? packageVersionId);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PackagesApi : IPackagesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PackagesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PackagesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PackagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PackagesApi(String basePath)
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
        /// Delete a package for the authenticated user Deletes a package owned by the authenticated user. You cannot delete a public package if any version of the package has more than 5,000 downloads. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:delete&#x60; scopes. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <returns></returns>
        public void PackagesDeletePackageForAuthenticatedUser (string packageType, string packageName)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesDeletePackageForAuthenticatedUser");
            
            // verify the required parameter 'packageName' is set
            if (packageName == null) throw new ApiException(400, "Missing required parameter 'packageName' when calling PackagesDeletePackageForAuthenticatedUser");
            

            var path = "/user/packages/{package_type}/{package_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "package_type" + "}", ApiClient.ParameterToString(packageType));
path = path.Replace("{" + "package_name" + "}", ApiClient.ParameterToString(packageName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesDeletePackageForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesDeletePackageForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a package for an organization Deletes an entire package in an organization. You cannot delete a public package if any version of the package has more than 5,000 downloads. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must have admin permissions in the organization and authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:delete&#x60; scopes. In addition: - If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope. - If &#x60;package_type&#x60; is &#x60;container&#x60;, you must also have admin permissions to the container you want to delete.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns></returns>
        public void PackagesDeletePackageForOrg (string packageType, string packageName, string org)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesDeletePackageForOrg");
            
            // verify the required parameter 'packageName' is set
            if (packageName == null) throw new ApiException(400, "Missing required parameter 'packageName' when calling PackagesDeletePackageForOrg");
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling PackagesDeletePackageForOrg");
            

            var path = "/orgs/{org}/packages/{package_type}/{package_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "package_type" + "}", ApiClient.ParameterToString(packageType));
path = path.Replace("{" + "package_name" + "}", ApiClient.ParameterToString(packageName));
path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesDeletePackageForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesDeletePackageForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a package for a user Deletes an entire package for a user. You cannot delete a public package if any version of the package has more than 5,000 downloads. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:delete&#x60; scopes. In addition: - If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope. - If &#x60;package_type&#x60; is &#x60;container&#x60;, you must also have admin permissions to the container you want to delete.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        public void PackagesDeletePackageForUser (string packageType, string packageName, string username)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesDeletePackageForUser");
            
            // verify the required parameter 'packageName' is set
            if (packageName == null) throw new ApiException(400, "Missing required parameter 'packageName' when calling PackagesDeletePackageForUser");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling PackagesDeletePackageForUser");
            

            var path = "/users/{username}/packages/{package_type}/{package_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "package_type" + "}", ApiClient.ParameterToString(packageType));
path = path.Replace("{" + "package_name" + "}", ApiClient.ParameterToString(packageName));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesDeletePackageForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesDeletePackageForUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a package version for the authenticated user Deletes a specific package version for a package owned by the authenticated user.  If the package is public and the package version has more than 5,000 downloads, you cannot delete the package version. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must have admin permissions in the organization and authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:delete&#x60; scopes. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="packageVersionId">Unique identifier of the package version.</param>
        /// <returns></returns>
        public void PackagesDeletePackageVersionForAuthenticatedUser (string packageType, string packageName, int? packageVersionId)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesDeletePackageVersionForAuthenticatedUser");
            
            // verify the required parameter 'packageName' is set
            if (packageName == null) throw new ApiException(400, "Missing required parameter 'packageName' when calling PackagesDeletePackageVersionForAuthenticatedUser");
            
            // verify the required parameter 'packageVersionId' is set
            if (packageVersionId == null) throw new ApiException(400, "Missing required parameter 'packageVersionId' when calling PackagesDeletePackageVersionForAuthenticatedUser");
            

            var path = "/user/packages/{package_type}/{package_name}/versions/{package_version_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "package_type" + "}", ApiClient.ParameterToString(packageType));
path = path.Replace("{" + "package_name" + "}", ApiClient.ParameterToString(packageName));
path = path.Replace("{" + "package_version_id" + "}", ApiClient.ParameterToString(packageVersionId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesDeletePackageVersionForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesDeletePackageVersionForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete package version for an organization Deletes a specific package version in an organization. If the package is public and the package version has more than 5,000 downloads, you cannot delete the package version. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must have admin permissions in the organization and authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:delete&#x60; scopes. In addition: - If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope. - If &#x60;package_type&#x60; is &#x60;container&#x60;, you must also have admin permissions to the container you want to delete.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="packageVersionId">Unique identifier of the package version.</param>
        /// <returns></returns>
        public void PackagesDeletePackageVersionForOrg (string packageType, string packageName, string org, int? packageVersionId)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesDeletePackageVersionForOrg");
            
            // verify the required parameter 'packageName' is set
            if (packageName == null) throw new ApiException(400, "Missing required parameter 'packageName' when calling PackagesDeletePackageVersionForOrg");
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling PackagesDeletePackageVersionForOrg");
            
            // verify the required parameter 'packageVersionId' is set
            if (packageVersionId == null) throw new ApiException(400, "Missing required parameter 'packageVersionId' when calling PackagesDeletePackageVersionForOrg");
            

            var path = "/orgs/{org}/packages/{package_type}/{package_name}/versions/{package_version_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "package_type" + "}", ApiClient.ParameterToString(packageType));
path = path.Replace("{" + "package_name" + "}", ApiClient.ParameterToString(packageName));
path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "package_version_id" + "}", ApiClient.ParameterToString(packageVersionId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesDeletePackageVersionForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesDeletePackageVersionForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete package version for a user Deletes a specific package version for a user. If the package is public and the package version has more than 5,000 downloads, you cannot delete the package version. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:delete&#x60; scopes. In addition: - If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope. - If &#x60;package_type&#x60; is &#x60;container&#x60;, you must also have admin permissions to the container you want to delete.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="packageVersionId">Unique identifier of the package version.</param>
        /// <returns></returns>
        public void PackagesDeletePackageVersionForUser (string packageType, string packageName, string username, int? packageVersionId)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesDeletePackageVersionForUser");
            
            // verify the required parameter 'packageName' is set
            if (packageName == null) throw new ApiException(400, "Missing required parameter 'packageName' when calling PackagesDeletePackageVersionForUser");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling PackagesDeletePackageVersionForUser");
            
            // verify the required parameter 'packageVersionId' is set
            if (packageVersionId == null) throw new ApiException(400, "Missing required parameter 'packageVersionId' when calling PackagesDeletePackageVersionForUser");
            

            var path = "/users/{username}/packages/{package_type}/{package_name}/versions/{package_version_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "package_type" + "}", ApiClient.ParameterToString(packageType));
path = path.Replace("{" + "package_name" + "}", ApiClient.ParameterToString(packageName));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));
path = path.Replace("{" + "package_version_id" + "}", ApiClient.ParameterToString(packageVersionId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesDeletePackageVersionForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesDeletePackageVersionForUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get all package versions for a package owned by the authenticated user Returns all package versions for a package owned by the authenticated user.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="state">The state of the package, either active or deleted.</param>
        /// <returns>List&lt;PackageVersion&gt;</returns>
        public List<PackageVersion> PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUser (string packageType, string packageName, int? page, int? perPage, string state)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUser");
            
            // verify the required parameter 'packageName' is set
            if (packageName == null) throw new ApiException(400, "Missing required parameter 'packageName' when calling PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUser");
            

            var path = "/user/packages/{package_type}/{package_name}/versions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "package_type" + "}", ApiClient.ParameterToString(packageType));
path = path.Replace("{" + "package_name" + "}", ApiClient.ParameterToString(packageName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<PackageVersion>) ApiClient.Deserialize(response.Content, typeof(List<PackageVersion>), response.Headers);
        }

        /// <summary>
        /// Get all package versions for a package owned by an organization Returns all package versions for a package owned by an organization.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="state">The state of the package, either active or deleted.</param>
        /// <returns>List&lt;PackageVersion&gt;</returns>
        public List<PackageVersion> PackagesGetAllPackageVersionsForPackageOwnedByOrg (string packageType, string packageName, string org, int? page, int? perPage, string state)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesGetAllPackageVersionsForPackageOwnedByOrg");
            
            // verify the required parameter 'packageName' is set
            if (packageName == null) throw new ApiException(400, "Missing required parameter 'packageName' when calling PackagesGetAllPackageVersionsForPackageOwnedByOrg");
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling PackagesGetAllPackageVersionsForPackageOwnedByOrg");
            

            var path = "/orgs/{org}/packages/{package_type}/{package_name}/versions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "package_type" + "}", ApiClient.ParameterToString(packageType));
path = path.Replace("{" + "package_name" + "}", ApiClient.ParameterToString(packageName));
path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesGetAllPackageVersionsForPackageOwnedByOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesGetAllPackageVersionsForPackageOwnedByOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (List<PackageVersion>) ApiClient.Deserialize(response.Content, typeof(List<PackageVersion>), response.Headers);
        }

        /// <summary>
        /// Get all package versions for a package owned by a user Returns all package versions for a public package owned by a specified user.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>List&lt;PackageVersion&gt;</returns>
        public List<PackageVersion> PackagesGetAllPackageVersionsForPackageOwnedByUser (string packageType, string packageName, string username)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesGetAllPackageVersionsForPackageOwnedByUser");
            
            // verify the required parameter 'packageName' is set
            if (packageName == null) throw new ApiException(400, "Missing required parameter 'packageName' when calling PackagesGetAllPackageVersionsForPackageOwnedByUser");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling PackagesGetAllPackageVersionsForPackageOwnedByUser");
            

            var path = "/users/{username}/packages/{package_type}/{package_name}/versions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "package_type" + "}", ApiClient.ParameterToString(packageType));
path = path.Replace("{" + "package_name" + "}", ApiClient.ParameterToString(packageName));
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
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesGetAllPackageVersionsForPackageOwnedByUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesGetAllPackageVersionsForPackageOwnedByUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<PackageVersion>) ApiClient.Deserialize(response.Content, typeof(List<PackageVersion>), response.Headers);
        }

        /// <summary>
        /// Get a package for the authenticated user Gets a specific package for a package owned by the authenticated user.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <returns>Package</returns>
        public Package PackagesGetPackageForAuthenticatedUser (string packageType, string packageName)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesGetPackageForAuthenticatedUser");
            
            // verify the required parameter 'packageName' is set
            if (packageName == null) throw new ApiException(400, "Missing required parameter 'packageName' when calling PackagesGetPackageForAuthenticatedUser");
            

            var path = "/user/packages/{package_type}/{package_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "package_type" + "}", ApiClient.ParameterToString(packageType));
path = path.Replace("{" + "package_name" + "}", ApiClient.ParameterToString(packageName));

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
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesGetPackageForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesGetPackageForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (Package) ApiClient.Deserialize(response.Content, typeof(Package), response.Headers);
        }

        /// <summary>
        /// Get a package for an organization Gets a specific package in an organization.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>Package</returns>
        public Package PackagesGetPackageForOrganization (string packageType, string packageName, string org)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesGetPackageForOrganization");
            
            // verify the required parameter 'packageName' is set
            if (packageName == null) throw new ApiException(400, "Missing required parameter 'packageName' when calling PackagesGetPackageForOrganization");
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling PackagesGetPackageForOrganization");
            

            var path = "/orgs/{org}/packages/{package_type}/{package_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "package_type" + "}", ApiClient.ParameterToString(packageType));
path = path.Replace("{" + "package_name" + "}", ApiClient.ParameterToString(packageName));
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
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesGetPackageForOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesGetPackageForOrganization: " + response.ErrorMessage, response.ErrorMessage);

            return (Package) ApiClient.Deserialize(response.Content, typeof(Package), response.Headers);
        }

        /// <summary>
        /// Get a package for a user Gets a specific package metadata for a public package owned by a user.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>Package</returns>
        public Package PackagesGetPackageForUser (string packageType, string packageName, string username)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesGetPackageForUser");
            
            // verify the required parameter 'packageName' is set
            if (packageName == null) throw new ApiException(400, "Missing required parameter 'packageName' when calling PackagesGetPackageForUser");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling PackagesGetPackageForUser");
            

            var path = "/users/{username}/packages/{package_type}/{package_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "package_type" + "}", ApiClient.ParameterToString(packageType));
path = path.Replace("{" + "package_name" + "}", ApiClient.ParameterToString(packageName));
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
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesGetPackageForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesGetPackageForUser: " + response.ErrorMessage, response.ErrorMessage);

            return (Package) ApiClient.Deserialize(response.Content, typeof(Package), response.Headers);
        }

        /// <summary>
        /// Get a package version for the authenticated user Gets a specific package version for a package owned by the authenticated user.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="packageVersionId">Unique identifier of the package version.</param>
        /// <returns>PackageVersion</returns>
        public PackageVersion PackagesGetPackageVersionForAuthenticatedUser (string packageType, string packageName, int? packageVersionId)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesGetPackageVersionForAuthenticatedUser");
            
            // verify the required parameter 'packageName' is set
            if (packageName == null) throw new ApiException(400, "Missing required parameter 'packageName' when calling PackagesGetPackageVersionForAuthenticatedUser");
            
            // verify the required parameter 'packageVersionId' is set
            if (packageVersionId == null) throw new ApiException(400, "Missing required parameter 'packageVersionId' when calling PackagesGetPackageVersionForAuthenticatedUser");
            

            var path = "/user/packages/{package_type}/{package_name}/versions/{package_version_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "package_type" + "}", ApiClient.ParameterToString(packageType));
path = path.Replace("{" + "package_name" + "}", ApiClient.ParameterToString(packageName));
path = path.Replace("{" + "package_version_id" + "}", ApiClient.ParameterToString(packageVersionId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesGetPackageVersionForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesGetPackageVersionForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (PackageVersion) ApiClient.Deserialize(response.Content, typeof(PackageVersion), response.Headers);
        }

        /// <summary>
        /// Get a package version for an organization Gets a specific package version in an organization.  You must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="packageVersionId">Unique identifier of the package version.</param>
        /// <returns>PackageVersion</returns>
        public PackageVersion PackagesGetPackageVersionForOrganization (string packageType, string packageName, string org, int? packageVersionId)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesGetPackageVersionForOrganization");
            
            // verify the required parameter 'packageName' is set
            if (packageName == null) throw new ApiException(400, "Missing required parameter 'packageName' when calling PackagesGetPackageVersionForOrganization");
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling PackagesGetPackageVersionForOrganization");
            
            // verify the required parameter 'packageVersionId' is set
            if (packageVersionId == null) throw new ApiException(400, "Missing required parameter 'packageVersionId' when calling PackagesGetPackageVersionForOrganization");
            

            var path = "/orgs/{org}/packages/{package_type}/{package_name}/versions/{package_version_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "package_type" + "}", ApiClient.ParameterToString(packageType));
path = path.Replace("{" + "package_name" + "}", ApiClient.ParameterToString(packageName));
path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "package_version_id" + "}", ApiClient.ParameterToString(packageVersionId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesGetPackageVersionForOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesGetPackageVersionForOrganization: " + response.ErrorMessage, response.ErrorMessage);

            return (PackageVersion) ApiClient.Deserialize(response.Content, typeof(PackageVersion), response.Headers);
        }

        /// <summary>
        /// Get a package version for a user Gets a specific package version for a public package owned by a specified user.  At this time, to use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="packageVersionId">Unique identifier of the package version.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>PackageVersion</returns>
        public PackageVersion PackagesGetPackageVersionForUser (string packageType, string packageName, int? packageVersionId, string username)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesGetPackageVersionForUser");
            
            // verify the required parameter 'packageName' is set
            if (packageName == null) throw new ApiException(400, "Missing required parameter 'packageName' when calling PackagesGetPackageVersionForUser");
            
            // verify the required parameter 'packageVersionId' is set
            if (packageVersionId == null) throw new ApiException(400, "Missing required parameter 'packageVersionId' when calling PackagesGetPackageVersionForUser");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling PackagesGetPackageVersionForUser");
            

            var path = "/users/{username}/packages/{package_type}/{package_name}/versions/{package_version_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "package_type" + "}", ApiClient.ParameterToString(packageType));
path = path.Replace("{" + "package_name" + "}", ApiClient.ParameterToString(packageName));
path = path.Replace("{" + "package_version_id" + "}", ApiClient.ParameterToString(packageVersionId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesGetPackageVersionForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesGetPackageVersionForUser: " + response.ErrorMessage, response.ErrorMessage);

            return (PackageVersion) ApiClient.Deserialize(response.Content, typeof(PackageVersion), response.Headers);
        }

        /// <summary>
        /// List packages for the authenticated user&#39;s namespace Lists packages owned by the authenticated user within the user&#39;s namespace.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="visibility">The selected visibility of the packages. Only &#x60;container&#x60; package_types currently support &#x60;internal&#x60; visibility properly. For other ecosystems &#x60;internal&#x60; is synonymous with &#x60;private&#x60;. This parameter is optional and only filters an existing result set.</param>
        /// <returns>List&lt;Package&gt;</returns>
        public List<Package> PackagesListPackagesForAuthenticatedUser (string packageType, string visibility)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesListPackagesForAuthenticatedUser");
            

            var path = "/user/packages";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (packageType != null) queryParams.Add("package_type", ApiClient.ParameterToString(packageType)); // query parameter
 if (visibility != null) queryParams.Add("visibility", ApiClient.ParameterToString(visibility)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesListPackagesForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesListPackagesForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Package>) ApiClient.Deserialize(response.Content, typeof(List<Package>), response.Headers);
        }

        /// <summary>
        /// List packages for an organization Lists all packages in an organization readable by the user.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="visibility">The selected visibility of the packages. Only &#x60;container&#x60; package_types currently support &#x60;internal&#x60; visibility properly. For other ecosystems &#x60;internal&#x60; is synonymous with &#x60;private&#x60;. This parameter is optional and only filters an existing result set.</param>
        /// <returns>List&lt;Package&gt;</returns>
        public List<Package> PackagesListPackagesForOrganization (string packageType, string org, string visibility)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesListPackagesForOrganization");
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling PackagesListPackagesForOrganization");
            

            var path = "/orgs/{org}/packages";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (packageType != null) queryParams.Add("package_type", ApiClient.ParameterToString(packageType)); // query parameter
 if (visibility != null) queryParams.Add("visibility", ApiClient.ParameterToString(visibility)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesListPackagesForOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesListPackagesForOrganization: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Package>) ApiClient.Deserialize(response.Content, typeof(List<Package>), response.Headers);
        }

        /// <summary>
        /// List packages for a user Lists all packages in a user&#39;s namespace for which the requesting user has access.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; scope. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="visibility">The selected visibility of the packages. Only &#x60;container&#x60; package_types currently support &#x60;internal&#x60; visibility properly. For other ecosystems &#x60;internal&#x60; is synonymous with &#x60;private&#x60;. This parameter is optional and only filters an existing result set.</param>
        /// <returns>List&lt;Package&gt;</returns>
        public List<Package> PackagesListPackagesForUser (string packageType, string username, string visibility)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesListPackagesForUser");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling PackagesListPackagesForUser");
            

            var path = "/users/{username}/packages";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (packageType != null) queryParams.Add("package_type", ApiClient.ParameterToString(packageType)); // query parameter
 if (visibility != null) queryParams.Add("visibility", ApiClient.ParameterToString(visibility)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesListPackagesForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesListPackagesForUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Package>) ApiClient.Deserialize(response.Content, typeof(List<Package>), response.Headers);
        }

        /// <summary>
        /// Restore a package for the authenticated user Restores a package owned by the authenticated user.  You can restore a deleted package under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package&#39;s namespace first.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:write&#x60; scopes. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="token">package token</param>
        /// <returns></returns>
        public void PackagesRestorePackageForAuthenticatedUser (string packageType, string packageName, string token)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesRestorePackageForAuthenticatedUser");
            
            // verify the required parameter 'packageName' is set
            if (packageName == null) throw new ApiException(400, "Missing required parameter 'packageName' when calling PackagesRestorePackageForAuthenticatedUser");
            

            var path = "/user/packages/{package_type}/{package_name}/restore";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "package_type" + "}", ApiClient.ParameterToString(packageType));
path = path.Replace("{" + "package_name" + "}", ApiClient.ParameterToString(packageName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesRestorePackageForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesRestorePackageForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Restore a package for an organization Restores an entire package in an organization.  You can restore a deleted package under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package&#39;s namespace first.  To use this endpoint, you must have admin permissions in the organization and authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:write&#x60; scopes. In addition: - If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope. - If &#x60;package_type&#x60; is &#x60;container&#x60;, you must also have admin permissions to the container that you want to restore.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="token">package token</param>
        /// <returns></returns>
        public void PackagesRestorePackageForOrg (string packageType, string packageName, string org, string token)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesRestorePackageForOrg");
            
            // verify the required parameter 'packageName' is set
            if (packageName == null) throw new ApiException(400, "Missing required parameter 'packageName' when calling PackagesRestorePackageForOrg");
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling PackagesRestorePackageForOrg");
            

            var path = "/orgs/{org}/packages/{package_type}/{package_name}/restore";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "package_type" + "}", ApiClient.ParameterToString(packageType));
path = path.Replace("{" + "package_name" + "}", ApiClient.ParameterToString(packageName));
path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesRestorePackageForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesRestorePackageForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Restore a package for a user Restores an entire package for a user.  You can restore a deleted package under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package&#39;s namespace first.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:write&#x60; scopes. In addition: - If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope. - If &#x60;package_type&#x60; is &#x60;container&#x60;, you must also have admin permissions to the container that you want to restore.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="token">package token</param>
        /// <returns></returns>
        public void PackagesRestorePackageForUser (string packageType, string packageName, string username, string token)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesRestorePackageForUser");
            
            // verify the required parameter 'packageName' is set
            if (packageName == null) throw new ApiException(400, "Missing required parameter 'packageName' when calling PackagesRestorePackageForUser");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling PackagesRestorePackageForUser");
            

            var path = "/users/{username}/packages/{package_type}/{package_name}/restore";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "package_type" + "}", ApiClient.ParameterToString(packageType));
path = path.Replace("{" + "package_name" + "}", ApiClient.ParameterToString(packageName));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesRestorePackageForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesRestorePackageForUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Restore a package version for the authenticated user Restores a package version owned by the authenticated user.  You can restore a deleted package version under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package&#39;s namespace first.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:write&#x60; scopes. If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="packageVersionId">Unique identifier of the package version.</param>
        /// <returns></returns>
        public void PackagesRestorePackageVersionForAuthenticatedUser (string packageType, string packageName, int? packageVersionId)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesRestorePackageVersionForAuthenticatedUser");
            
            // verify the required parameter 'packageName' is set
            if (packageName == null) throw new ApiException(400, "Missing required parameter 'packageName' when calling PackagesRestorePackageVersionForAuthenticatedUser");
            
            // verify the required parameter 'packageVersionId' is set
            if (packageVersionId == null) throw new ApiException(400, "Missing required parameter 'packageVersionId' when calling PackagesRestorePackageVersionForAuthenticatedUser");
            

            var path = "/user/packages/{package_type}/{package_name}/versions/{package_version_id}/restore";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "package_type" + "}", ApiClient.ParameterToString(packageType));
path = path.Replace("{" + "package_name" + "}", ApiClient.ParameterToString(packageName));
path = path.Replace("{" + "package_version_id" + "}", ApiClient.ParameterToString(packageVersionId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesRestorePackageVersionForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesRestorePackageVersionForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Restore package version for an organization Restores a specific package version in an organization.  You can restore a deleted package under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package&#39;s namespace first.  To use this endpoint, you must have admin permissions in the organization and authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:write&#x60; scopes. In addition: - If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope. - If &#x60;package_type&#x60; is &#x60;container&#x60;, you must also have admin permissions to the container that you want to restore.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="packageVersionId">Unique identifier of the package version.</param>
        /// <returns></returns>
        public void PackagesRestorePackageVersionForOrg (string packageType, string packageName, string org, int? packageVersionId)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesRestorePackageVersionForOrg");
            
            // verify the required parameter 'packageName' is set
            if (packageName == null) throw new ApiException(400, "Missing required parameter 'packageName' when calling PackagesRestorePackageVersionForOrg");
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling PackagesRestorePackageVersionForOrg");
            
            // verify the required parameter 'packageVersionId' is set
            if (packageVersionId == null) throw new ApiException(400, "Missing required parameter 'packageVersionId' when calling PackagesRestorePackageVersionForOrg");
            

            var path = "/orgs/{org}/packages/{package_type}/{package_name}/versions/{package_version_id}/restore";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "package_type" + "}", ApiClient.ParameterToString(packageType));
path = path.Replace("{" + "package_name" + "}", ApiClient.ParameterToString(packageName));
path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "package_version_id" + "}", ApiClient.ParameterToString(packageVersionId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesRestorePackageVersionForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesRestorePackageVersionForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Restore package version for a user Restores a specific package version for a user.  You can restore a deleted package under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package&#39;s namespace first.  To use this endpoint, you must authenticate using an access token with the &#x60;packages:read&#x60; and &#x60;packages:write&#x60; scopes. In addition: - If &#x60;package_type&#x60; is not &#x60;container&#x60;, your token must also include the &#x60;repo&#x60; scope. - If &#x60;package_type&#x60; is &#x60;container&#x60;, you must also have admin permissions to the container that you want to restore.
        /// </summary>
        /// <param name="packageType">The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry.</param>
        /// <param name="packageName">The name of the package.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="packageVersionId">Unique identifier of the package version.</param>
        /// <returns></returns>
        public void PackagesRestorePackageVersionForUser (string packageType, string packageName, string username, int? packageVersionId)
        {
            
            // verify the required parameter 'packageType' is set
            if (packageType == null) throw new ApiException(400, "Missing required parameter 'packageType' when calling PackagesRestorePackageVersionForUser");
            
            // verify the required parameter 'packageName' is set
            if (packageName == null) throw new ApiException(400, "Missing required parameter 'packageName' when calling PackagesRestorePackageVersionForUser");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling PackagesRestorePackageVersionForUser");
            
            // verify the required parameter 'packageVersionId' is set
            if (packageVersionId == null) throw new ApiException(400, "Missing required parameter 'packageVersionId' when calling PackagesRestorePackageVersionForUser");
            

            var path = "/users/{username}/packages/{package_type}/{package_name}/versions/{package_version_id}/restore";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "package_type" + "}", ApiClient.ParameterToString(packageType));
path = path.Replace("{" + "package_name" + "}", ApiClient.ParameterToString(packageName));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));
path = path.Replace("{" + "package_version_id" + "}", ApiClient.ParameterToString(packageVersionId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesRestorePackageVersionForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PackagesRestorePackageVersionForUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

    }
}
