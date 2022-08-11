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
    public interface IAppsApi
    {
        /// <summary>
        /// Add a repository to an app installation Add a single repository to an installation. The authenticated user must have admin access to the repository.  You must use a personal access token (which you can create via the [command line](https://docs.github.com/github/authenticating-to-github/creating-a-personal-access-token) or [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication)) to access this endpoint.
        /// </summary>
        /// <param name="installationId">The unique identifier of the installation.</param>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <returns></returns>
        void AppsAddRepoToInstallationForAuthenticatedUser (int? installationId, int? repositoryId);
        /// <summary>
        /// Check a token OAuth applications can use a special API method for checking OAuth token validity without exceeding the normal rate limits for failed login attempts. Authentication works differently with this particular endpoint. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) to use this endpoint, where the username is the OAuth application &#x60;client_id&#x60; and the password is its &#x60;client_secret&#x60;. Invalid tokens will return &#x60;404 NOT FOUND&#x60;.
        /// </summary>
        /// <param name="clientId">The client ID of the GitHub app.</param>
        /// <param name="appsCheckTokenRequest"></param>
        /// <returns>Authorization</returns>
        Authorization AppsCheckToken (string clientId, AppsCheckTokenRequest appsCheckTokenRequest);
        /// <summary>
        /// Create a GitHub App from a manifest Use this endpoint to complete the handshake necessary when implementing the [GitHub App Manifest flow](https://docs.github.com/apps/building-github-apps/creating-github-apps-from-a-manifest/). When you create a GitHub App with the manifest flow, you receive a temporary &#x60;code&#x60; used to retrieve the GitHub App&#39;s &#x60;id&#x60;, &#x60;pem&#x60; (private key), and &#x60;webhook_secret&#x60;.
        /// </summary>
        /// <param name="code"></param>
        /// <returns>AppsCreateFromManifest201Response</returns>
        AppsCreateFromManifest201Response AppsCreateFromManifest (string code);
        /// <summary>
        /// Create an installation access token for an app Creates an installation access token that enables a GitHub App to make authenticated API requests for the app&#39;s installation on an organization or individual account. Installation tokens expire one hour from the time you create them. Using an expired token produces a status code of &#x60;401 - Unauthorized&#x60;, and requires creating a new installation token. By default the installation token has access to all repositories that the installation can access. To restrict the access to specific repositories, you can provide the &#x60;repository_ids&#x60; when creating the token. When you omit &#x60;repository_ids&#x60;, the response does not contain the &#x60;repositories&#x60; key.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="installationId">The unique identifier of the installation.</param>
        /// <param name="appsCreateInstallationAccessTokenRequest"></param>
        /// <returns>InstallationToken</returns>
        InstallationToken AppsCreateInstallationAccessToken (int? installationId, AppsCreateInstallationAccessTokenRequest appsCreateInstallationAccessTokenRequest);
        /// <summary>
        /// Delete an app authorization OAuth application owners can revoke a grant for their OAuth application and a specific user. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) when accessing this endpoint, using the OAuth application&#39;s &#x60;client_id&#x60; and &#x60;client_secret&#x60; as the username and password. You must also provide a valid OAuth &#x60;access_token&#x60; as an input parameter and the grant for the token&#39;s owner will be deleted. Deleting an OAuth application&#39;s grant will also delete all OAuth tokens associated with the application for the user. Once deleted, the application will have no access to the user&#39;s account and will no longer be listed on [the application authorizations settings screen within GitHub](https://github.com/settings/applications#authorized).
        /// </summary>
        /// <param name="clientId">The client ID of the GitHub app.</param>
        /// <param name="appsDeleteAuthorizationRequest"></param>
        /// <returns></returns>
        void AppsDeleteAuthorization (string clientId, AppsDeleteAuthorizationRequest appsDeleteAuthorizationRequest);
        /// <summary>
        /// Delete an installation for the authenticated app Uninstalls a GitHub App on a user, organization, or business account. If you prefer to temporarily suspend an app&#39;s access to your account&#39;s resources, then we recommend the \&quot;[Suspend an app installation](https://docs.github.com/rest/reference/apps/#suspend-an-app-installation)\&quot; endpoint.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="installationId">The unique identifier of the installation.</param>
        /// <returns></returns>
        void AppsDeleteInstallation (int? installationId);
        /// <summary>
        /// Delete an app token OAuth application owners can revoke a single token for an OAuth application. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) when accessing this endpoint, using the OAuth application&#39;s &#x60;client_id&#x60; and &#x60;client_secret&#x60; as the username and password.
        /// </summary>
        /// <param name="clientId">The client ID of the GitHub app.</param>
        /// <param name="appsDeleteAuthorizationRequest"></param>
        /// <returns></returns>
        void AppsDeleteToken (string clientId, AppsDeleteAuthorizationRequest appsDeleteAuthorizationRequest);
        /// <summary>
        /// Get the authenticated app Returns the GitHub App associated with the authentication credentials used. To see how many app installations are associated with this GitHub App, see the &#x60;installations_count&#x60; in the response. For more details about your app&#39;s installations, see the \&quot;[List installations for the authenticated app](https://docs.github.com/rest/reference/apps#list-installations-for-the-authenticated-app)\&quot; endpoint.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <returns>GitHubApp</returns>
        GitHubApp AppsGetAuthenticated ();
        /// <summary>
        /// Get an app **Note**: The &#x60;:app_slug&#x60; is just the URL-friendly name of your GitHub App. You can find this on the settings page for your GitHub App (e.g., &#x60;https://github.com/settings/apps/:app_slug&#x60;).  If the GitHub App you specify is public, you can access this endpoint without authenticating. If the GitHub App you specify is private, you must authenticate with a [personal access token](https://docs.github.com/articles/creating-a-personal-access-token-for-the-command-line/) or an [installation access token](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-an-installation) to access this endpoint.
        /// </summary>
        /// <param name="appSlug"></param>
        /// <returns>GitHubApp</returns>
        GitHubApp AppsGetBySlug (string appSlug);
        /// <summary>
        /// Get an installation for the authenticated app Enables an authenticated GitHub App to find an installation&#39;s information using the installation id.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="installationId">The unique identifier of the installation.</param>
        /// <returns>Installation</returns>
        Installation AppsGetInstallation (int? installationId);
        /// <summary>
        /// Get an organization installation for the authenticated app Enables an authenticated GitHub App to find the organization&#39;s installation information.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>Installation</returns>
        Installation AppsGetOrgInstallation (string org);
        /// <summary>
        /// Get a repository installation for the authenticated app Enables an authenticated GitHub App to find the repository&#39;s installation information. The installation&#39;s account type will be either an organization or a user account, depending which account the repository belongs to.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>Installation</returns>
        Installation AppsGetRepoInstallation (string owner, string repo);
        /// <summary>
        /// Get a subscription plan for an account Shows whether the user or organization account actively subscribes to a plan listed by the authenticated GitHub App. When someone submits a plan change that won&#39;t be processed until the end of their billing cycle, you will also see the upcoming pending change.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.
        /// </summary>
        /// <param name="accountId">account_id parameter</param>
        /// <returns>MarketplacePurchase</returns>
        MarketplacePurchase AppsGetSubscriptionPlanForAccount (int? accountId);
        /// <summary>
        /// Get a subscription plan for an account (stubbed) Shows whether the user or organization account actively subscribes to a plan listed by the authenticated GitHub App. When someone submits a plan change that won&#39;t be processed until the end of their billing cycle, you will also see the upcoming pending change.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.
        /// </summary>
        /// <param name="accountId">account_id parameter</param>
        /// <returns>MarketplacePurchase</returns>
        MarketplacePurchase AppsGetSubscriptionPlanForAccountStubbed (int? accountId);
        /// <summary>
        /// Get a user installation for the authenticated app Enables an authenticated GitHub App to find the user’s installation information.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>Installation</returns>
        Installation AppsGetUserInstallation (string username);
        /// <summary>
        /// Get a webhook configuration for an app Returns the webhook configuration for a GitHub App. For more information about configuring a webhook for your app, see \&quot;[Creating a GitHub App](/developers/apps/creating-a-github-app).\&quot;  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <returns>WebhookConfiguration</returns>
        WebhookConfiguration AppsGetWebhookConfigForApp ();
        /// <summary>
        /// Get a delivery for an app webhook Returns a delivery for the webhook configured for a GitHub App.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="deliveryId"></param>
        /// <returns>WebhookDelivery</returns>
        WebhookDelivery AppsGetWebhookDelivery (int? deliveryId);
        /// <summary>
        /// List accounts for a plan Returns user and organization accounts associated with the specified plan, including free plans. For per-seat pricing, you see the list of accounts that have purchased the plan, including the number of seats purchased. When someone submits a plan change that won&#39;t be processed until the end of their billing cycle, you will also see the upcoming pending change.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.
        /// </summary>
        /// <param name="planId">The unique identifier of the plan.</param>
        /// <param name="sort">The property to sort the results by. &#x60;created&#x60; means when the repository was starred. &#x60;updated&#x60; means when the repository was last pushed to.</param>
        /// <param name="direction">To return the oldest accounts first, set to &#x60;asc&#x60;. Ignored without the &#x60;sort&#x60; parameter.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MarketplacePurchase&gt;</returns>
        List<MarketplacePurchase> AppsListAccountsForPlan (int? planId, string sort, string direction, int? perPage, int? page);
        /// <summary>
        /// List accounts for a plan (stubbed) Returns repository and organization accounts associated with the specified plan, including free plans. For per-seat pricing, you see the list of accounts that have purchased the plan, including the number of seats purchased. When someone submits a plan change that won&#39;t be processed until the end of their billing cycle, you will also see the upcoming pending change.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.
        /// </summary>
        /// <param name="planId">The unique identifier of the plan.</param>
        /// <param name="sort">The property to sort the results by. &#x60;created&#x60; means when the repository was starred. &#x60;updated&#x60; means when the repository was last pushed to.</param>
        /// <param name="direction">To return the oldest accounts first, set to &#x60;asc&#x60;. Ignored without the &#x60;sort&#x60; parameter.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MarketplacePurchase&gt;</returns>
        List<MarketplacePurchase> AppsListAccountsForPlanStubbed (int? planId, string sort, string direction, int? perPage, int? page);
        /// <summary>
        /// List repositories accessible to the user access token List repositories that the authenticated user has explicit permission (&#x60;:read&#x60;, &#x60;:write&#x60;, or &#x60;:admin&#x60;) to access for an installation.  The authenticated user has explicit permission to access repositories they own, repositories where they are a collaborator, and repositories that they can access through an organization membership.  You must use a [user-to-server OAuth access token](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/#identifying-users-on-your-site), created for a user who has authorized your GitHub App, to access this endpoint.  The access the user has to each repository is included in the hash under the &#x60;permissions&#x60; key.
        /// </summary>
        /// <param name="installationId">The unique identifier of the installation.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>AppsListInstallationReposForAuthenticatedUser200Response</returns>
        AppsListInstallationReposForAuthenticatedUser200Response AppsListInstallationReposForAuthenticatedUser (int? installationId, int? perPage, int? page);
        /// <summary>
        /// List installations for the authenticated app You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.  The permissions the installation has are included under the &#x60;permissions&#x60; key.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="outdated"></param>
        /// <returns>List&lt;Installation&gt;</returns>
        List<Installation> AppsListInstallations (int? perPage, int? page, DateTime? since, string outdated);
        /// <summary>
        /// List app installations accessible to the user access token Lists installations of your GitHub App that the authenticated user has explicit permission (&#x60;:read&#x60;, &#x60;:write&#x60;, or &#x60;:admin&#x60;) to access.  You must use a [user-to-server OAuth access token](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/#identifying-users-on-your-site), created for a user who has authorized your GitHub App, to access this endpoint.  The authenticated user has explicit permission to access repositories they own, repositories where they are a collaborator, and repositories that they can access through an organization membership.  You can find the permissions for the installation under the &#x60;permissions&#x60; key.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>OrgsListAppInstallations200Response</returns>
        OrgsListAppInstallations200Response AppsListInstallationsForAuthenticatedUser (int? perPage, int? page);
        /// <summary>
        /// List plans Lists all plans that are part of your GitHub Marketplace listing.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MarketplaceListingPlan&gt;</returns>
        List<MarketplaceListingPlan> AppsListPlans (int? perPage, int? page);
        /// <summary>
        /// List plans (stubbed) Lists all plans that are part of your GitHub Marketplace listing.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MarketplaceListingPlan&gt;</returns>
        List<MarketplaceListingPlan> AppsListPlansStubbed (int? perPage, int? page);
        /// <summary>
        /// List repositories accessible to the app installation List repositories that an app installation can access.  You must use an [installation access token](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-an-installation) to access this endpoint.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>AppsListReposAccessibleToInstallation200Response</returns>
        AppsListReposAccessibleToInstallation200Response AppsListReposAccessibleToInstallation (int? perPage, int? page);
        /// <summary>
        /// List subscriptions for the authenticated user Lists the active subscriptions for the authenticated user. You must use a [user-to-server OAuth access token](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/#identifying-users-on-your-site), created for a user who has authorized your GitHub App, to access this endpoint. . OAuth Apps must authenticate using an [OAuth token](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/).
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;UserMarketplacePurchase&gt;</returns>
        List<UserMarketplacePurchase> AppsListSubscriptionsForAuthenticatedUser (int? perPage, int? page);
        /// <summary>
        /// List subscriptions for the authenticated user (stubbed) Lists the active subscriptions for the authenticated user. You must use a [user-to-server OAuth access token](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/#identifying-users-on-your-site), created for a user who has authorized your GitHub App, to access this endpoint. . OAuth Apps must authenticate using an [OAuth token](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/).
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;UserMarketplacePurchase&gt;</returns>
        List<UserMarketplacePurchase> AppsListSubscriptionsForAuthenticatedUserStubbed (int? perPage, int? page);
        /// <summary>
        /// List deliveries for an app webhook Returns a list of webhook deliveries for the webhook configured for a GitHub App.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="cursor">Used for pagination: the starting delivery from which the page of deliveries is fetched. Refer to the &#x60;link&#x60; header for the next and previous page cursors.</param>
        /// <returns>List&lt;SimpleWebhookDelivery&gt;</returns>
        List<SimpleWebhookDelivery> AppsListWebhookDeliveries (int? perPage, string cursor);
        /// <summary>
        /// Redeliver a delivery for an app webhook Redeliver a delivery for the webhook configured for a GitHub App.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="deliveryId"></param>
        /// <returns>Object</returns>
        Object AppsRedeliverWebhookDelivery (int? deliveryId);
        /// <summary>
        /// Remove a repository from an app installation Remove a single repository from an installation. The authenticated user must have admin access to the repository.  You must use a personal access token (which you can create via the [command line](https://docs.github.com/github/authenticating-to-github/creating-a-personal-access-token) or [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication)) to access this endpoint.
        /// </summary>
        /// <param name="installationId">The unique identifier of the installation.</param>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <returns></returns>
        void AppsRemoveRepoFromInstallationForAuthenticatedUser (int? installationId, int? repositoryId);
        /// <summary>
        /// Reset a token OAuth applications can use this API method to reset a valid OAuth token without end-user involvement. Applications must save the \&quot;token\&quot; property in the response because changes take effect immediately. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) when accessing this endpoint, using the OAuth application&#39;s &#x60;client_id&#x60; and &#x60;client_secret&#x60; as the username and password. Invalid tokens will return &#x60;404 NOT FOUND&#x60;.
        /// </summary>
        /// <param name="clientId">The client ID of the GitHub app.</param>
        /// <param name="appsCheckTokenRequest"></param>
        /// <returns>Authorization</returns>
        Authorization AppsResetToken (string clientId, AppsCheckTokenRequest appsCheckTokenRequest);
        /// <summary>
        /// Revoke an installation access token Revokes the installation token you&#39;re using to authenticate as an installation and access this endpoint.  Once an installation token is revoked, the token is invalidated and cannot be used. Other endpoints that require the revoked installation token must have a new installation token to work. You can create a new token using the \&quot;[Create an installation access token for an app](https://docs.github.com/rest/reference/apps#create-an-installation-access-token-for-an-app)\&quot; endpoint.  You must use an [installation access token](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-an-installation) to access this endpoint.
        /// </summary>
        /// <returns></returns>
        void AppsRevokeInstallationAccessToken ();
        /// <summary>
        /// Create a scoped access token Use a non-scoped user-to-server OAuth access token to create a repository scoped and/or permission scoped user-to-server OAuth access token. You can specify which repositories the token can access and which permissions are granted to the token. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) when accessing this endpoint, using the OAuth application&#39;s &#x60;client_id&#x60; and &#x60;client_secret&#x60; as the username and password. Invalid tokens will return &#x60;404 NOT FOUND&#x60;.
        /// </summary>
        /// <param name="clientId">The client ID of the GitHub app.</param>
        /// <param name="appsScopeTokenRequest"></param>
        /// <returns>Authorization</returns>
        Authorization AppsScopeToken (string clientId, AppsScopeTokenRequest appsScopeTokenRequest);
        /// <summary>
        /// Suspend an app installation Suspends a GitHub App on a user, organization, or business account, which blocks the app from accessing the account&#39;s resources. When a GitHub App is suspended, the app&#39;s access to the GitHub API or webhook events is blocked for that account.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="installationId">The unique identifier of the installation.</param>
        /// <returns></returns>
        void AppsSuspendInstallation (int? installationId);
        /// <summary>
        /// Unsuspend an app installation Removes a GitHub App installation suspension.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="installationId">The unique identifier of the installation.</param>
        /// <returns></returns>
        void AppsUnsuspendInstallation (int? installationId);
        /// <summary>
        /// Update a webhook configuration for an app Updates the webhook configuration for a GitHub App. For more information about configuring a webhook for your app, see \&quot;[Creating a GitHub App](/developers/apps/creating-a-github-app).\&quot;  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="appsUpdateWebhookConfigForAppRequest"></param>
        /// <returns>WebhookConfiguration</returns>
        WebhookConfiguration AppsUpdateWebhookConfigForApp (AppsUpdateWebhookConfigForAppRequest appsUpdateWebhookConfigForAppRequest);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AppsApi : IAppsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AppsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AppsApi(String basePath)
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
        /// Add a repository to an app installation Add a single repository to an installation. The authenticated user must have admin access to the repository.  You must use a personal access token (which you can create via the [command line](https://docs.github.com/github/authenticating-to-github/creating-a-personal-access-token) or [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication)) to access this endpoint.
        /// </summary>
        /// <param name="installationId">The unique identifier of the installation.</param>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <returns></returns>
        public void AppsAddRepoToInstallationForAuthenticatedUser (int? installationId, int? repositoryId)
        {
            
            // verify the required parameter 'installationId' is set
            if (installationId == null) throw new ApiException(400, "Missing required parameter 'installationId' when calling AppsAddRepoToInstallationForAuthenticatedUser");
            
            // verify the required parameter 'repositoryId' is set
            if (repositoryId == null) throw new ApiException(400, "Missing required parameter 'repositoryId' when calling AppsAddRepoToInstallationForAuthenticatedUser");
            

            var path = "/user/installations/{installation_id}/repositories/{repository_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "installation_id" + "}", ApiClient.ParameterToString(installationId));
path = path.Replace("{" + "repository_id" + "}", ApiClient.ParameterToString(repositoryId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsAddRepoToInstallationForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsAddRepoToInstallationForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Check a token OAuth applications can use a special API method for checking OAuth token validity without exceeding the normal rate limits for failed login attempts. Authentication works differently with this particular endpoint. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) to use this endpoint, where the username is the OAuth application &#x60;client_id&#x60; and the password is its &#x60;client_secret&#x60;. Invalid tokens will return &#x60;404 NOT FOUND&#x60;.
        /// </summary>
        /// <param name="clientId">The client ID of the GitHub app.</param>
        /// <param name="appsCheckTokenRequest"></param>
        /// <returns>Authorization</returns>
        public Authorization AppsCheckToken (string clientId, AppsCheckTokenRequest appsCheckTokenRequest)
        {
            
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling AppsCheckToken");
            
            // verify the required parameter 'appsCheckTokenRequest' is set
            if (appsCheckTokenRequest == null) throw new ApiException(400, "Missing required parameter 'appsCheckTokenRequest' when calling AppsCheckToken");
            

            var path = "/applications/{client_id}/token";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "client_id" + "}", ApiClient.ParameterToString(clientId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(appsCheckTokenRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsCheckToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsCheckToken: " + response.ErrorMessage, response.ErrorMessage);

            return (Authorization) ApiClient.Deserialize(response.Content, typeof(Authorization), response.Headers);
        }

        /// <summary>
        /// Create a GitHub App from a manifest Use this endpoint to complete the handshake necessary when implementing the [GitHub App Manifest flow](https://docs.github.com/apps/building-github-apps/creating-github-apps-from-a-manifest/). When you create a GitHub App with the manifest flow, you receive a temporary &#x60;code&#x60; used to retrieve the GitHub App&#39;s &#x60;id&#x60;, &#x60;pem&#x60; (private key), and &#x60;webhook_secret&#x60;.
        /// </summary>
        /// <param name="code"></param>
        /// <returns>AppsCreateFromManifest201Response</returns>
        public AppsCreateFromManifest201Response AppsCreateFromManifest (string code)
        {
            
            // verify the required parameter 'code' is set
            if (code == null) throw new ApiException(400, "Missing required parameter 'code' when calling AppsCreateFromManifest");
            

            var path = "/app-manifests/{code}/conversions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "code" + "}", ApiClient.ParameterToString(code));

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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsCreateFromManifest: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsCreateFromManifest: " + response.ErrorMessage, response.ErrorMessage);

            return (AppsCreateFromManifest201Response) ApiClient.Deserialize(response.Content, typeof(AppsCreateFromManifest201Response), response.Headers);
        }

        /// <summary>
        /// Create an installation access token for an app Creates an installation access token that enables a GitHub App to make authenticated API requests for the app&#39;s installation on an organization or individual account. Installation tokens expire one hour from the time you create them. Using an expired token produces a status code of &#x60;401 - Unauthorized&#x60;, and requires creating a new installation token. By default the installation token has access to all repositories that the installation can access. To restrict the access to specific repositories, you can provide the &#x60;repository_ids&#x60; when creating the token. When you omit &#x60;repository_ids&#x60;, the response does not contain the &#x60;repositories&#x60; key.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="installationId">The unique identifier of the installation.</param>
        /// <param name="appsCreateInstallationAccessTokenRequest"></param>
        /// <returns>InstallationToken</returns>
        public InstallationToken AppsCreateInstallationAccessToken (int? installationId, AppsCreateInstallationAccessTokenRequest appsCreateInstallationAccessTokenRequest)
        {
            
            // verify the required parameter 'installationId' is set
            if (installationId == null) throw new ApiException(400, "Missing required parameter 'installationId' when calling AppsCreateInstallationAccessToken");
            

            var path = "/app/installations/{installation_id}/access_tokens";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "installation_id" + "}", ApiClient.ParameterToString(installationId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(appsCreateInstallationAccessTokenRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsCreateInstallationAccessToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsCreateInstallationAccessToken: " + response.ErrorMessage, response.ErrorMessage);

            return (InstallationToken) ApiClient.Deserialize(response.Content, typeof(InstallationToken), response.Headers);
        }

        /// <summary>
        /// Delete an app authorization OAuth application owners can revoke a grant for their OAuth application and a specific user. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) when accessing this endpoint, using the OAuth application&#39;s &#x60;client_id&#x60; and &#x60;client_secret&#x60; as the username and password. You must also provide a valid OAuth &#x60;access_token&#x60; as an input parameter and the grant for the token&#39;s owner will be deleted. Deleting an OAuth application&#39;s grant will also delete all OAuth tokens associated with the application for the user. Once deleted, the application will have no access to the user&#39;s account and will no longer be listed on [the application authorizations settings screen within GitHub](https://github.com/settings/applications#authorized).
        /// </summary>
        /// <param name="clientId">The client ID of the GitHub app.</param>
        /// <param name="appsDeleteAuthorizationRequest"></param>
        /// <returns></returns>
        public void AppsDeleteAuthorization (string clientId, AppsDeleteAuthorizationRequest appsDeleteAuthorizationRequest)
        {
            
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling AppsDeleteAuthorization");
            
            // verify the required parameter 'appsDeleteAuthorizationRequest' is set
            if (appsDeleteAuthorizationRequest == null) throw new ApiException(400, "Missing required parameter 'appsDeleteAuthorizationRequest' when calling AppsDeleteAuthorization");
            

            var path = "/applications/{client_id}/grant";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "client_id" + "}", ApiClient.ParameterToString(clientId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(appsDeleteAuthorizationRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsDeleteAuthorization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsDeleteAuthorization: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete an installation for the authenticated app Uninstalls a GitHub App on a user, organization, or business account. If you prefer to temporarily suspend an app&#39;s access to your account&#39;s resources, then we recommend the \&quot;[Suspend an app installation](https://docs.github.com/rest/reference/apps/#suspend-an-app-installation)\&quot; endpoint.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="installationId">The unique identifier of the installation.</param>
        /// <returns></returns>
        public void AppsDeleteInstallation (int? installationId)
        {
            
            // verify the required parameter 'installationId' is set
            if (installationId == null) throw new ApiException(400, "Missing required parameter 'installationId' when calling AppsDeleteInstallation");
            

            var path = "/app/installations/{installation_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "installation_id" + "}", ApiClient.ParameterToString(installationId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsDeleteInstallation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsDeleteInstallation: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete an app token OAuth application owners can revoke a single token for an OAuth application. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) when accessing this endpoint, using the OAuth application&#39;s &#x60;client_id&#x60; and &#x60;client_secret&#x60; as the username and password.
        /// </summary>
        /// <param name="clientId">The client ID of the GitHub app.</param>
        /// <param name="appsDeleteAuthorizationRequest"></param>
        /// <returns></returns>
        public void AppsDeleteToken (string clientId, AppsDeleteAuthorizationRequest appsDeleteAuthorizationRequest)
        {
            
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling AppsDeleteToken");
            
            // verify the required parameter 'appsDeleteAuthorizationRequest' is set
            if (appsDeleteAuthorizationRequest == null) throw new ApiException(400, "Missing required parameter 'appsDeleteAuthorizationRequest' when calling AppsDeleteToken");
            

            var path = "/applications/{client_id}/token";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "client_id" + "}", ApiClient.ParameterToString(clientId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(appsDeleteAuthorizationRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsDeleteToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsDeleteToken: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get the authenticated app Returns the GitHub App associated with the authentication credentials used. To see how many app installations are associated with this GitHub App, see the &#x60;installations_count&#x60; in the response. For more details about your app&#39;s installations, see the \&quot;[List installations for the authenticated app](https://docs.github.com/rest/reference/apps#list-installations-for-the-authenticated-app)\&quot; endpoint.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <returns>GitHubApp</returns>
        public GitHubApp AppsGetAuthenticated ()
        {
            

            var path = "/app";
            path = path.Replace("{format}", "json");
            
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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsGetAuthenticated: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsGetAuthenticated: " + response.ErrorMessage, response.ErrorMessage);

            return (GitHubApp) ApiClient.Deserialize(response.Content, typeof(GitHubApp), response.Headers);
        }

        /// <summary>
        /// Get an app **Note**: The &#x60;:app_slug&#x60; is just the URL-friendly name of your GitHub App. You can find this on the settings page for your GitHub App (e.g., &#x60;https://github.com/settings/apps/:app_slug&#x60;).  If the GitHub App you specify is public, you can access this endpoint without authenticating. If the GitHub App you specify is private, you must authenticate with a [personal access token](https://docs.github.com/articles/creating-a-personal-access-token-for-the-command-line/) or an [installation access token](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-an-installation) to access this endpoint.
        /// </summary>
        /// <param name="appSlug"></param>
        /// <returns>GitHubApp</returns>
        public GitHubApp AppsGetBySlug (string appSlug)
        {
            
            // verify the required parameter 'appSlug' is set
            if (appSlug == null) throw new ApiException(400, "Missing required parameter 'appSlug' when calling AppsGetBySlug");
            

            var path = "/apps/{app_slug}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "app_slug" + "}", ApiClient.ParameterToString(appSlug));

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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsGetBySlug: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsGetBySlug: " + response.ErrorMessage, response.ErrorMessage);

            return (GitHubApp) ApiClient.Deserialize(response.Content, typeof(GitHubApp), response.Headers);
        }

        /// <summary>
        /// Get an installation for the authenticated app Enables an authenticated GitHub App to find an installation&#39;s information using the installation id.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="installationId">The unique identifier of the installation.</param>
        /// <returns>Installation</returns>
        public Installation AppsGetInstallation (int? installationId)
        {
            
            // verify the required parameter 'installationId' is set
            if (installationId == null) throw new ApiException(400, "Missing required parameter 'installationId' when calling AppsGetInstallation");
            

            var path = "/app/installations/{installation_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "installation_id" + "}", ApiClient.ParameterToString(installationId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsGetInstallation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsGetInstallation: " + response.ErrorMessage, response.ErrorMessage);

            return (Installation) ApiClient.Deserialize(response.Content, typeof(Installation), response.Headers);
        }

        /// <summary>
        /// Get an organization installation for the authenticated app Enables an authenticated GitHub App to find the organization&#39;s installation information.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>Installation</returns>
        public Installation AppsGetOrgInstallation (string org)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling AppsGetOrgInstallation");
            

            var path = "/orgs/{org}/installation";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsGetOrgInstallation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsGetOrgInstallation: " + response.ErrorMessage, response.ErrorMessage);

            return (Installation) ApiClient.Deserialize(response.Content, typeof(Installation), response.Headers);
        }

        /// <summary>
        /// Get a repository installation for the authenticated app Enables an authenticated GitHub App to find the repository&#39;s installation information. The installation&#39;s account type will be either an organization or a user account, depending which account the repository belongs to.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>Installation</returns>
        public Installation AppsGetRepoInstallation (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling AppsGetRepoInstallation");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling AppsGetRepoInstallation");
            

            var path = "/repos/{owner}/{repo}/installation";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsGetRepoInstallation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsGetRepoInstallation: " + response.ErrorMessage, response.ErrorMessage);

            return (Installation) ApiClient.Deserialize(response.Content, typeof(Installation), response.Headers);
        }

        /// <summary>
        /// Get a subscription plan for an account Shows whether the user or organization account actively subscribes to a plan listed by the authenticated GitHub App. When someone submits a plan change that won&#39;t be processed until the end of their billing cycle, you will also see the upcoming pending change.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.
        /// </summary>
        /// <param name="accountId">account_id parameter</param>
        /// <returns>MarketplacePurchase</returns>
        public MarketplacePurchase AppsGetSubscriptionPlanForAccount (int? accountId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling AppsGetSubscriptionPlanForAccount");
            

            var path = "/marketplace_listing/accounts/{account_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "account_id" + "}", ApiClient.ParameterToString(accountId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsGetSubscriptionPlanForAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsGetSubscriptionPlanForAccount: " + response.ErrorMessage, response.ErrorMessage);

            return (MarketplacePurchase) ApiClient.Deserialize(response.Content, typeof(MarketplacePurchase), response.Headers);
        }

        /// <summary>
        /// Get a subscription plan for an account (stubbed) Shows whether the user or organization account actively subscribes to a plan listed by the authenticated GitHub App. When someone submits a plan change that won&#39;t be processed until the end of their billing cycle, you will also see the upcoming pending change.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.
        /// </summary>
        /// <param name="accountId">account_id parameter</param>
        /// <returns>MarketplacePurchase</returns>
        public MarketplacePurchase AppsGetSubscriptionPlanForAccountStubbed (int? accountId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling AppsGetSubscriptionPlanForAccountStubbed");
            

            var path = "/marketplace_listing/stubbed/accounts/{account_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "account_id" + "}", ApiClient.ParameterToString(accountId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsGetSubscriptionPlanForAccountStubbed: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsGetSubscriptionPlanForAccountStubbed: " + response.ErrorMessage, response.ErrorMessage);

            return (MarketplacePurchase) ApiClient.Deserialize(response.Content, typeof(MarketplacePurchase), response.Headers);
        }

        /// <summary>
        /// Get a user installation for the authenticated app Enables an authenticated GitHub App to find the user’s installation information.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>Installation</returns>
        public Installation AppsGetUserInstallation (string username)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling AppsGetUserInstallation");
            

            var path = "/users/{username}/installation";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsGetUserInstallation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsGetUserInstallation: " + response.ErrorMessage, response.ErrorMessage);

            return (Installation) ApiClient.Deserialize(response.Content, typeof(Installation), response.Headers);
        }

        /// <summary>
        /// Get a webhook configuration for an app Returns the webhook configuration for a GitHub App. For more information about configuring a webhook for your app, see \&quot;[Creating a GitHub App](/developers/apps/creating-a-github-app).\&quot;  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <returns>WebhookConfiguration</returns>
        public WebhookConfiguration AppsGetWebhookConfigForApp ()
        {
            

            var path = "/app/hook/config";
            path = path.Replace("{format}", "json");
            
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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsGetWebhookConfigForApp: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsGetWebhookConfigForApp: " + response.ErrorMessage, response.ErrorMessage);

            return (WebhookConfiguration) ApiClient.Deserialize(response.Content, typeof(WebhookConfiguration), response.Headers);
        }

        /// <summary>
        /// Get a delivery for an app webhook Returns a delivery for the webhook configured for a GitHub App.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="deliveryId"></param>
        /// <returns>WebhookDelivery</returns>
        public WebhookDelivery AppsGetWebhookDelivery (int? deliveryId)
        {
            
            // verify the required parameter 'deliveryId' is set
            if (deliveryId == null) throw new ApiException(400, "Missing required parameter 'deliveryId' when calling AppsGetWebhookDelivery");
            

            var path = "/app/hook/deliveries/{delivery_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "delivery_id" + "}", ApiClient.ParameterToString(deliveryId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsGetWebhookDelivery: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsGetWebhookDelivery: " + response.ErrorMessage, response.ErrorMessage);

            return (WebhookDelivery) ApiClient.Deserialize(response.Content, typeof(WebhookDelivery), response.Headers);
        }

        /// <summary>
        /// List accounts for a plan Returns user and organization accounts associated with the specified plan, including free plans. For per-seat pricing, you see the list of accounts that have purchased the plan, including the number of seats purchased. When someone submits a plan change that won&#39;t be processed until the end of their billing cycle, you will also see the upcoming pending change.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.
        /// </summary>
        /// <param name="planId">The unique identifier of the plan.</param>
        /// <param name="sort">The property to sort the results by. &#x60;created&#x60; means when the repository was starred. &#x60;updated&#x60; means when the repository was last pushed to.</param>
        /// <param name="direction">To return the oldest accounts first, set to &#x60;asc&#x60;. Ignored without the &#x60;sort&#x60; parameter.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MarketplacePurchase&gt;</returns>
        public List<MarketplacePurchase> AppsListAccountsForPlan (int? planId, string sort, string direction, int? perPage, int? page)
        {
            
            // verify the required parameter 'planId' is set
            if (planId == null) throw new ApiException(400, "Missing required parameter 'planId' when calling AppsListAccountsForPlan");
            

            var path = "/marketplace_listing/plans/{plan_id}/accounts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "plan_id" + "}", ApiClient.ParameterToString(planId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListAccountsForPlan: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListAccountsForPlan: " + response.ErrorMessage, response.ErrorMessage);

            return (List<MarketplacePurchase>) ApiClient.Deserialize(response.Content, typeof(List<MarketplacePurchase>), response.Headers);
        }

        /// <summary>
        /// List accounts for a plan (stubbed) Returns repository and organization accounts associated with the specified plan, including free plans. For per-seat pricing, you see the list of accounts that have purchased the plan, including the number of seats purchased. When someone submits a plan change that won&#39;t be processed until the end of their billing cycle, you will also see the upcoming pending change.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.
        /// </summary>
        /// <param name="planId">The unique identifier of the plan.</param>
        /// <param name="sort">The property to sort the results by. &#x60;created&#x60; means when the repository was starred. &#x60;updated&#x60; means when the repository was last pushed to.</param>
        /// <param name="direction">To return the oldest accounts first, set to &#x60;asc&#x60;. Ignored without the &#x60;sort&#x60; parameter.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MarketplacePurchase&gt;</returns>
        public List<MarketplacePurchase> AppsListAccountsForPlanStubbed (int? planId, string sort, string direction, int? perPage, int? page)
        {
            
            // verify the required parameter 'planId' is set
            if (planId == null) throw new ApiException(400, "Missing required parameter 'planId' when calling AppsListAccountsForPlanStubbed");
            

            var path = "/marketplace_listing/stubbed/plans/{plan_id}/accounts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "plan_id" + "}", ApiClient.ParameterToString(planId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListAccountsForPlanStubbed: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListAccountsForPlanStubbed: " + response.ErrorMessage, response.ErrorMessage);

            return (List<MarketplacePurchase>) ApiClient.Deserialize(response.Content, typeof(List<MarketplacePurchase>), response.Headers);
        }

        /// <summary>
        /// List repositories accessible to the user access token List repositories that the authenticated user has explicit permission (&#x60;:read&#x60;, &#x60;:write&#x60;, or &#x60;:admin&#x60;) to access for an installation.  The authenticated user has explicit permission to access repositories they own, repositories where they are a collaborator, and repositories that they can access through an organization membership.  You must use a [user-to-server OAuth access token](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/#identifying-users-on-your-site), created for a user who has authorized your GitHub App, to access this endpoint.  The access the user has to each repository is included in the hash under the &#x60;permissions&#x60; key.
        /// </summary>
        /// <param name="installationId">The unique identifier of the installation.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>AppsListInstallationReposForAuthenticatedUser200Response</returns>
        public AppsListInstallationReposForAuthenticatedUser200Response AppsListInstallationReposForAuthenticatedUser (int? installationId, int? perPage, int? page)
        {
            
            // verify the required parameter 'installationId' is set
            if (installationId == null) throw new ApiException(400, "Missing required parameter 'installationId' when calling AppsListInstallationReposForAuthenticatedUser");
            

            var path = "/user/installations/{installation_id}/repositories";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "installation_id" + "}", ApiClient.ParameterToString(installationId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListInstallationReposForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListInstallationReposForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (AppsListInstallationReposForAuthenticatedUser200Response) ApiClient.Deserialize(response.Content, typeof(AppsListInstallationReposForAuthenticatedUser200Response), response.Headers);
        }

        /// <summary>
        /// List installations for the authenticated app You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.  The permissions the installation has are included under the &#x60;permissions&#x60; key.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="outdated"></param>
        /// <returns>List&lt;Installation&gt;</returns>
        public List<Installation> AppsListInstallations (int? perPage, int? page, DateTime? since, string outdated)
        {
            

            var path = "/app/installations";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
 if (outdated != null) queryParams.Add("outdated", ApiClient.ParameterToString(outdated)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListInstallations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListInstallations: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Installation>) ApiClient.Deserialize(response.Content, typeof(List<Installation>), response.Headers);
        }

        /// <summary>
        /// List app installations accessible to the user access token Lists installations of your GitHub App that the authenticated user has explicit permission (&#x60;:read&#x60;, &#x60;:write&#x60;, or &#x60;:admin&#x60;) to access.  You must use a [user-to-server OAuth access token](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/#identifying-users-on-your-site), created for a user who has authorized your GitHub App, to access this endpoint.  The authenticated user has explicit permission to access repositories they own, repositories where they are a collaborator, and repositories that they can access through an organization membership.  You can find the permissions for the installation under the &#x60;permissions&#x60; key.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>OrgsListAppInstallations200Response</returns>
        public OrgsListAppInstallations200Response AppsListInstallationsForAuthenticatedUser (int? perPage, int? page)
        {
            

            var path = "/user/installations";
            path = path.Replace("{format}", "json");
            
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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListInstallationsForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListInstallationsForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (OrgsListAppInstallations200Response) ApiClient.Deserialize(response.Content, typeof(OrgsListAppInstallations200Response), response.Headers);
        }

        /// <summary>
        /// List plans Lists all plans that are part of your GitHub Marketplace listing.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MarketplaceListingPlan&gt;</returns>
        public List<MarketplaceListingPlan> AppsListPlans (int? perPage, int? page)
        {
            

            var path = "/marketplace_listing/plans";
            path = path.Replace("{format}", "json");
            
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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListPlans: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListPlans: " + response.ErrorMessage, response.ErrorMessage);

            return (List<MarketplaceListingPlan>) ApiClient.Deserialize(response.Content, typeof(List<MarketplaceListingPlan>), response.Headers);
        }

        /// <summary>
        /// List plans (stubbed) Lists all plans that are part of your GitHub Marketplace listing.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MarketplaceListingPlan&gt;</returns>
        public List<MarketplaceListingPlan> AppsListPlansStubbed (int? perPage, int? page)
        {
            

            var path = "/marketplace_listing/stubbed/plans";
            path = path.Replace("{format}", "json");
            
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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListPlansStubbed: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListPlansStubbed: " + response.ErrorMessage, response.ErrorMessage);

            return (List<MarketplaceListingPlan>) ApiClient.Deserialize(response.Content, typeof(List<MarketplaceListingPlan>), response.Headers);
        }

        /// <summary>
        /// List repositories accessible to the app installation List repositories that an app installation can access.  You must use an [installation access token](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-an-installation) to access this endpoint.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>AppsListReposAccessibleToInstallation200Response</returns>
        public AppsListReposAccessibleToInstallation200Response AppsListReposAccessibleToInstallation (int? perPage, int? page)
        {
            

            var path = "/installation/repositories";
            path = path.Replace("{format}", "json");
            
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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListReposAccessibleToInstallation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListReposAccessibleToInstallation: " + response.ErrorMessage, response.ErrorMessage);

            return (AppsListReposAccessibleToInstallation200Response) ApiClient.Deserialize(response.Content, typeof(AppsListReposAccessibleToInstallation200Response), response.Headers);
        }

        /// <summary>
        /// List subscriptions for the authenticated user Lists the active subscriptions for the authenticated user. You must use a [user-to-server OAuth access token](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/#identifying-users-on-your-site), created for a user who has authorized your GitHub App, to access this endpoint. . OAuth Apps must authenticate using an [OAuth token](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/).
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;UserMarketplacePurchase&gt;</returns>
        public List<UserMarketplacePurchase> AppsListSubscriptionsForAuthenticatedUser (int? perPage, int? page)
        {
            

            var path = "/user/marketplace_purchases";
            path = path.Replace("{format}", "json");
            
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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListSubscriptionsForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListSubscriptionsForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<UserMarketplacePurchase>) ApiClient.Deserialize(response.Content, typeof(List<UserMarketplacePurchase>), response.Headers);
        }

        /// <summary>
        /// List subscriptions for the authenticated user (stubbed) Lists the active subscriptions for the authenticated user. You must use a [user-to-server OAuth access token](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/#identifying-users-on-your-site), created for a user who has authorized your GitHub App, to access this endpoint. . OAuth Apps must authenticate using an [OAuth token](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/).
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;UserMarketplacePurchase&gt;</returns>
        public List<UserMarketplacePurchase> AppsListSubscriptionsForAuthenticatedUserStubbed (int? perPage, int? page)
        {
            

            var path = "/user/marketplace_purchases/stubbed";
            path = path.Replace("{format}", "json");
            
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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListSubscriptionsForAuthenticatedUserStubbed: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListSubscriptionsForAuthenticatedUserStubbed: " + response.ErrorMessage, response.ErrorMessage);

            return (List<UserMarketplacePurchase>) ApiClient.Deserialize(response.Content, typeof(List<UserMarketplacePurchase>), response.Headers);
        }

        /// <summary>
        /// List deliveries for an app webhook Returns a list of webhook deliveries for the webhook configured for a GitHub App.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="cursor">Used for pagination: the starting delivery from which the page of deliveries is fetched. Refer to the &#x60;link&#x60; header for the next and previous page cursors.</param>
        /// <returns>List&lt;SimpleWebhookDelivery&gt;</returns>
        public List<SimpleWebhookDelivery> AppsListWebhookDeliveries (int? perPage, string cursor)
        {
            

            var path = "/app/hook/deliveries";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListWebhookDeliveries: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsListWebhookDeliveries: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleWebhookDelivery>) ApiClient.Deserialize(response.Content, typeof(List<SimpleWebhookDelivery>), response.Headers);
        }

        /// <summary>
        /// Redeliver a delivery for an app webhook Redeliver a delivery for the webhook configured for a GitHub App.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="deliveryId"></param>
        /// <returns>Object</returns>
        public Object AppsRedeliverWebhookDelivery (int? deliveryId)
        {
            
            // verify the required parameter 'deliveryId' is set
            if (deliveryId == null) throw new ApiException(400, "Missing required parameter 'deliveryId' when calling AppsRedeliverWebhookDelivery");
            

            var path = "/app/hook/deliveries/{delivery_id}/attempts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "delivery_id" + "}", ApiClient.ParameterToString(deliveryId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsRedeliverWebhookDelivery: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsRedeliverWebhookDelivery: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Remove a repository from an app installation Remove a single repository from an installation. The authenticated user must have admin access to the repository.  You must use a personal access token (which you can create via the [command line](https://docs.github.com/github/authenticating-to-github/creating-a-personal-access-token) or [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication)) to access this endpoint.
        /// </summary>
        /// <param name="installationId">The unique identifier of the installation.</param>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <returns></returns>
        public void AppsRemoveRepoFromInstallationForAuthenticatedUser (int? installationId, int? repositoryId)
        {
            
            // verify the required parameter 'installationId' is set
            if (installationId == null) throw new ApiException(400, "Missing required parameter 'installationId' when calling AppsRemoveRepoFromInstallationForAuthenticatedUser");
            
            // verify the required parameter 'repositoryId' is set
            if (repositoryId == null) throw new ApiException(400, "Missing required parameter 'repositoryId' when calling AppsRemoveRepoFromInstallationForAuthenticatedUser");
            

            var path = "/user/installations/{installation_id}/repositories/{repository_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "installation_id" + "}", ApiClient.ParameterToString(installationId));
path = path.Replace("{" + "repository_id" + "}", ApiClient.ParameterToString(repositoryId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsRemoveRepoFromInstallationForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsRemoveRepoFromInstallationForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Reset a token OAuth applications can use this API method to reset a valid OAuth token without end-user involvement. Applications must save the \&quot;token\&quot; property in the response because changes take effect immediately. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) when accessing this endpoint, using the OAuth application&#39;s &#x60;client_id&#x60; and &#x60;client_secret&#x60; as the username and password. Invalid tokens will return &#x60;404 NOT FOUND&#x60;.
        /// </summary>
        /// <param name="clientId">The client ID of the GitHub app.</param>
        /// <param name="appsCheckTokenRequest"></param>
        /// <returns>Authorization</returns>
        public Authorization AppsResetToken (string clientId, AppsCheckTokenRequest appsCheckTokenRequest)
        {
            
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling AppsResetToken");
            
            // verify the required parameter 'appsCheckTokenRequest' is set
            if (appsCheckTokenRequest == null) throw new ApiException(400, "Missing required parameter 'appsCheckTokenRequest' when calling AppsResetToken");
            

            var path = "/applications/{client_id}/token";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "client_id" + "}", ApiClient.ParameterToString(clientId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(appsCheckTokenRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsResetToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsResetToken: " + response.ErrorMessage, response.ErrorMessage);

            return (Authorization) ApiClient.Deserialize(response.Content, typeof(Authorization), response.Headers);
        }

        /// <summary>
        /// Revoke an installation access token Revokes the installation token you&#39;re using to authenticate as an installation and access this endpoint.  Once an installation token is revoked, the token is invalidated and cannot be used. Other endpoints that require the revoked installation token must have a new installation token to work. You can create a new token using the \&quot;[Create an installation access token for an app](https://docs.github.com/rest/reference/apps#create-an-installation-access-token-for-an-app)\&quot; endpoint.  You must use an [installation access token](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-an-installation) to access this endpoint.
        /// </summary>
        /// <returns></returns>
        public void AppsRevokeInstallationAccessToken ()
        {
            

            var path = "/installation/token";
            path = path.Replace("{format}", "json");
            
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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsRevokeInstallationAccessToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsRevokeInstallationAccessToken: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Create a scoped access token Use a non-scoped user-to-server OAuth access token to create a repository scoped and/or permission scoped user-to-server OAuth access token. You can specify which repositories the token can access and which permissions are granted to the token. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) when accessing this endpoint, using the OAuth application&#39;s &#x60;client_id&#x60; and &#x60;client_secret&#x60; as the username and password. Invalid tokens will return &#x60;404 NOT FOUND&#x60;.
        /// </summary>
        /// <param name="clientId">The client ID of the GitHub app.</param>
        /// <param name="appsScopeTokenRequest"></param>
        /// <returns>Authorization</returns>
        public Authorization AppsScopeToken (string clientId, AppsScopeTokenRequest appsScopeTokenRequest)
        {
            
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling AppsScopeToken");
            
            // verify the required parameter 'appsScopeTokenRequest' is set
            if (appsScopeTokenRequest == null) throw new ApiException(400, "Missing required parameter 'appsScopeTokenRequest' when calling AppsScopeToken");
            

            var path = "/applications/{client_id}/token/scoped";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "client_id" + "}", ApiClient.ParameterToString(clientId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(appsScopeTokenRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsScopeToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsScopeToken: " + response.ErrorMessage, response.ErrorMessage);

            return (Authorization) ApiClient.Deserialize(response.Content, typeof(Authorization), response.Headers);
        }

        /// <summary>
        /// Suspend an app installation Suspends a GitHub App on a user, organization, or business account, which blocks the app from accessing the account&#39;s resources. When a GitHub App is suspended, the app&#39;s access to the GitHub API or webhook events is blocked for that account.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="installationId">The unique identifier of the installation.</param>
        /// <returns></returns>
        public void AppsSuspendInstallation (int? installationId)
        {
            
            // verify the required parameter 'installationId' is set
            if (installationId == null) throw new ApiException(400, "Missing required parameter 'installationId' when calling AppsSuspendInstallation");
            

            var path = "/app/installations/{installation_id}/suspended";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "installation_id" + "}", ApiClient.ParameterToString(installationId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsSuspendInstallation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsSuspendInstallation: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Unsuspend an app installation Removes a GitHub App installation suspension.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="installationId">The unique identifier of the installation.</param>
        /// <returns></returns>
        public void AppsUnsuspendInstallation (int? installationId)
        {
            
            // verify the required parameter 'installationId' is set
            if (installationId == null) throw new ApiException(400, "Missing required parameter 'installationId' when calling AppsUnsuspendInstallation");
            

            var path = "/app/installations/{installation_id}/suspended";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "installation_id" + "}", ApiClient.ParameterToString(installationId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling AppsUnsuspendInstallation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsUnsuspendInstallation: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Update a webhook configuration for an app Updates the webhook configuration for a GitHub App. For more information about configuring a webhook for your app, see \&quot;[Creating a GitHub App](/developers/apps/creating-a-github-app).\&quot;  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="appsUpdateWebhookConfigForAppRequest"></param>
        /// <returns>WebhookConfiguration</returns>
        public WebhookConfiguration AppsUpdateWebhookConfigForApp (AppsUpdateWebhookConfigForAppRequest appsUpdateWebhookConfigForAppRequest)
        {
            
            // verify the required parameter 'appsUpdateWebhookConfigForAppRequest' is set
            if (appsUpdateWebhookConfigForAppRequest == null) throw new ApiException(400, "Missing required parameter 'appsUpdateWebhookConfigForAppRequest' when calling AppsUpdateWebhookConfigForApp");
            

            var path = "/app/hook/config";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(appsUpdateWebhookConfigForAppRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsUpdateWebhookConfigForApp: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppsUpdateWebhookConfigForApp: " + response.ErrorMessage, response.ErrorMessage);

            return (WebhookConfiguration) ApiClient.Deserialize(response.Content, typeof(WebhookConfiguration), response.Headers);
        }

    }
}
