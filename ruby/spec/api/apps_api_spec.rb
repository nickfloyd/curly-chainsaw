=begin
#GitHub v3 REST API

#GitHub's v3 REST API.

The version of the OpenAPI document: 1.1.4

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 6.0.1

=end

require 'spec_helper'
require 'json'

# Unit tests for OpenapiClient::AppsApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'AppsApi' do
  before do
    # run before each test
    @api_instance = OpenapiClient::AppsApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of AppsApi' do
    it 'should create an instance of AppsApi' do
      expect(@api_instance).to be_instance_of(OpenapiClient::AppsApi)
    end
  end

  # unit tests for apps_add_repo_to_installation_for_authenticated_user
  # Add a repository to an app installation
  # Add a single repository to an installation. The authenticated user must have admin access to the repository.  You must use a personal access token (which you can create via the [command line](https://docs.github.com/github/authenticating-to-github/creating-a-personal-access-token) or [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication)) to access this endpoint.
  # @param installation_id The unique identifier of the installation.
  # @param repository_id The unique identifier of the repository.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'apps_add_repo_to_installation_for_authenticated_user test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_check_token
  # Check a token
  # OAuth applications can use a special API method for checking OAuth token validity without exceeding the normal rate limits for failed login attempts. Authentication works differently with this particular endpoint. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) to use this endpoint, where the username is the OAuth application &#x60;client_id&#x60; and the password is its &#x60;client_secret&#x60;. Invalid tokens will return &#x60;404 NOT FOUND&#x60;.
  # @param client_id The client ID of the GitHub app.
  # @param apps_check_token_request 
  # @param [Hash] opts the optional parameters
  # @return [Authorization]
  describe 'apps_check_token test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_create_from_manifest
  # Create a GitHub App from a manifest
  # Use this endpoint to complete the handshake necessary when implementing the [GitHub App Manifest flow](https://docs.github.com/apps/building-github-apps/creating-github-apps-from-a-manifest/). When you create a GitHub App with the manifest flow, you receive a temporary &#x60;code&#x60; used to retrieve the GitHub App&#39;s &#x60;id&#x60;, &#x60;pem&#x60; (private key), and &#x60;webhook_secret&#x60;.
  # @param code 
  # @param [Hash] opts the optional parameters
  # @return [AppsCreateFromManifest201Response]
  describe 'apps_create_from_manifest test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_create_installation_access_token
  # Create an installation access token for an app
  # Creates an installation access token that enables a GitHub App to make authenticated API requests for the app&#39;s installation on an organization or individual account. Installation tokens expire one hour from the time you create them. Using an expired token produces a status code of &#x60;401 - Unauthorized&#x60;, and requires creating a new installation token. By default the installation token has access to all repositories that the installation can access. To restrict the access to specific repositories, you can provide the &#x60;repository_ids&#x60; when creating the token. When you omit &#x60;repository_ids&#x60;, the response does not contain the &#x60;repositories&#x60; key.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
  # @param installation_id The unique identifier of the installation.
  # @param [Hash] opts the optional parameters
  # @option opts [AppsCreateInstallationAccessTokenRequest] :apps_create_installation_access_token_request 
  # @return [InstallationToken]
  describe 'apps_create_installation_access_token test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_delete_authorization
  # Delete an app authorization
  # OAuth application owners can revoke a grant for their OAuth application and a specific user. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) when accessing this endpoint, using the OAuth application&#39;s &#x60;client_id&#x60; and &#x60;client_secret&#x60; as the username and password. You must also provide a valid OAuth &#x60;access_token&#x60; as an input parameter and the grant for the token&#39;s owner will be deleted. Deleting an OAuth application&#39;s grant will also delete all OAuth tokens associated with the application for the user. Once deleted, the application will have no access to the user&#39;s account and will no longer be listed on [the application authorizations settings screen within GitHub](https://github.com/settings/applications#authorized).
  # @param client_id The client ID of the GitHub app.
  # @param apps_delete_authorization_request 
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'apps_delete_authorization test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_delete_installation
  # Delete an installation for the authenticated app
  # Uninstalls a GitHub App on a user, organization, or business account. If you prefer to temporarily suspend an app&#39;s access to your account&#39;s resources, then we recommend the \&quot;[Suspend an app installation](https://docs.github.com/rest/reference/apps/#suspend-an-app-installation)\&quot; endpoint.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
  # @param installation_id The unique identifier of the installation.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'apps_delete_installation test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_delete_token
  # Delete an app token
  # OAuth application owners can revoke a single token for an OAuth application. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) when accessing this endpoint, using the OAuth application&#39;s &#x60;client_id&#x60; and &#x60;client_secret&#x60; as the username and password.
  # @param client_id The client ID of the GitHub app.
  # @param apps_delete_authorization_request 
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'apps_delete_token test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_get_authenticated
  # Get the authenticated app
  # Returns the GitHub App associated with the authentication credentials used. To see how many app installations are associated with this GitHub App, see the &#x60;installations_count&#x60; in the response. For more details about your app&#39;s installations, see the \&quot;[List installations for the authenticated app](https://docs.github.com/rest/reference/apps#list-installations-for-the-authenticated-app)\&quot; endpoint.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
  # @param [Hash] opts the optional parameters
  # @return [GitHubApp]
  describe 'apps_get_authenticated test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_get_by_slug
  # Get an app
  # **Note**: The &#x60;:app_slug&#x60; is just the URL-friendly name of your GitHub App. You can find this on the settings page for your GitHub App (e.g., &#x60;https://github.com/settings/apps/:app_slug&#x60;).  If the GitHub App you specify is public, you can access this endpoint without authenticating. If the GitHub App you specify is private, you must authenticate with a [personal access token](https://docs.github.com/articles/creating-a-personal-access-token-for-the-command-line/) or an [installation access token](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-an-installation) to access this endpoint.
  # @param app_slug 
  # @param [Hash] opts the optional parameters
  # @return [GitHubApp]
  describe 'apps_get_by_slug test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_get_installation
  # Get an installation for the authenticated app
  # Enables an authenticated GitHub App to find an installation&#39;s information using the installation id.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
  # @param installation_id The unique identifier of the installation.
  # @param [Hash] opts the optional parameters
  # @return [Installation]
  describe 'apps_get_installation test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_get_org_installation
  # Get an organization installation for the authenticated app
  # Enables an authenticated GitHub App to find the organization&#39;s installation information.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
  # @param org The organization name. The name is not case sensitive.
  # @param [Hash] opts the optional parameters
  # @return [Installation]
  describe 'apps_get_org_installation test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_get_repo_installation
  # Get a repository installation for the authenticated app
  # Enables an authenticated GitHub App to find the repository&#39;s installation information. The installation&#39;s account type will be either an organization or a user account, depending which account the repository belongs to.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
  # @param owner The account owner of the repository. The name is not case sensitive.
  # @param repo The name of the repository. The name is not case sensitive.
  # @param [Hash] opts the optional parameters
  # @return [Installation]
  describe 'apps_get_repo_installation test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_get_subscription_plan_for_account
  # Get a subscription plan for an account
  # Shows whether the user or organization account actively subscribes to a plan listed by the authenticated GitHub App. When someone submits a plan change that won&#39;t be processed until the end of their billing cycle, you will also see the upcoming pending change.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.
  # @param account_id account_id parameter
  # @param [Hash] opts the optional parameters
  # @return [MarketplacePurchase]
  describe 'apps_get_subscription_plan_for_account test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_get_subscription_plan_for_account_stubbed
  # Get a subscription plan for an account (stubbed)
  # Shows whether the user or organization account actively subscribes to a plan listed by the authenticated GitHub App. When someone submits a plan change that won&#39;t be processed until the end of their billing cycle, you will also see the upcoming pending change.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.
  # @param account_id account_id parameter
  # @param [Hash] opts the optional parameters
  # @return [MarketplacePurchase]
  describe 'apps_get_subscription_plan_for_account_stubbed test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_get_user_installation
  # Get a user installation for the authenticated app
  # Enables an authenticated GitHub App to find the user???s installation information.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
  # @param username The handle for the GitHub user account.
  # @param [Hash] opts the optional parameters
  # @return [Installation]
  describe 'apps_get_user_installation test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_get_webhook_config_for_app
  # Get a webhook configuration for an app
  # Returns the webhook configuration for a GitHub App. For more information about configuring a webhook for your app, see \&quot;[Creating a GitHub App](/developers/apps/creating-a-github-app).\&quot;  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
  # @param [Hash] opts the optional parameters
  # @return [WebhookConfiguration]
  describe 'apps_get_webhook_config_for_app test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_get_webhook_delivery
  # Get a delivery for an app webhook
  # Returns a delivery for the webhook configured for a GitHub App.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
  # @param delivery_id 
  # @param [Hash] opts the optional parameters
  # @return [WebhookDelivery]
  describe 'apps_get_webhook_delivery test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_list_accounts_for_plan
  # List accounts for a plan
  # Returns user and organization accounts associated with the specified plan, including free plans. For per-seat pricing, you see the list of accounts that have purchased the plan, including the number of seats purchased. When someone submits a plan change that won&#39;t be processed until the end of their billing cycle, you will also see the upcoming pending change.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.
  # @param plan_id The unique identifier of the plan.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :sort The property to sort the results by. &#x60;created&#x60; means when the repository was starred. &#x60;updated&#x60; means when the repository was last pushed to.
  # @option opts [String] :direction To return the oldest accounts first, set to &#x60;asc&#x60;. Ignored without the &#x60;sort&#x60; parameter.
  # @option opts [Integer] :per_page The number of results per page (max 100).
  # @option opts [Integer] :page Page number of the results to fetch.
  # @return [Array<MarketplacePurchase>]
  describe 'apps_list_accounts_for_plan test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_list_accounts_for_plan_stubbed
  # List accounts for a plan (stubbed)
  # Returns repository and organization accounts associated with the specified plan, including free plans. For per-seat pricing, you see the list of accounts that have purchased the plan, including the number of seats purchased. When someone submits a plan change that won&#39;t be processed until the end of their billing cycle, you will also see the upcoming pending change.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.
  # @param plan_id The unique identifier of the plan.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :sort The property to sort the results by. &#x60;created&#x60; means when the repository was starred. &#x60;updated&#x60; means when the repository was last pushed to.
  # @option opts [String] :direction To return the oldest accounts first, set to &#x60;asc&#x60;. Ignored without the &#x60;sort&#x60; parameter.
  # @option opts [Integer] :per_page The number of results per page (max 100).
  # @option opts [Integer] :page Page number of the results to fetch.
  # @return [Array<MarketplacePurchase>]
  describe 'apps_list_accounts_for_plan_stubbed test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_list_installation_repos_for_authenticated_user
  # List repositories accessible to the user access token
  # List repositories that the authenticated user has explicit permission (&#x60;:read&#x60;, &#x60;:write&#x60;, or &#x60;:admin&#x60;) to access for an installation.  The authenticated user has explicit permission to access repositories they own, repositories where they are a collaborator, and repositories that they can access through an organization membership.  You must use a [user-to-server OAuth access token](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/#identifying-users-on-your-site), created for a user who has authorized your GitHub App, to access this endpoint.  The access the user has to each repository is included in the hash under the &#x60;permissions&#x60; key.
  # @param installation_id The unique identifier of the installation.
  # @param [Hash] opts the optional parameters
  # @option opts [Integer] :per_page The number of results per page (max 100).
  # @option opts [Integer] :page Page number of the results to fetch.
  # @return [AppsListInstallationReposForAuthenticatedUser200Response]
  describe 'apps_list_installation_repos_for_authenticated_user test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_list_installations
  # List installations for the authenticated app
  # You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.  The permissions the installation has are included under the &#x60;permissions&#x60; key.
  # @param [Hash] opts the optional parameters
  # @option opts [Integer] :per_page The number of results per page (max 100).
  # @option opts [Integer] :page Page number of the results to fetch.
  # @option opts [Time] :since Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.
  # @option opts [String] :outdated 
  # @return [Array<Installation>]
  describe 'apps_list_installations test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_list_installations_for_authenticated_user
  # List app installations accessible to the user access token
  # Lists installations of your GitHub App that the authenticated user has explicit permission (&#x60;:read&#x60;, &#x60;:write&#x60;, or &#x60;:admin&#x60;) to access.  You must use a [user-to-server OAuth access token](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/#identifying-users-on-your-site), created for a user who has authorized your GitHub App, to access this endpoint.  The authenticated user has explicit permission to access repositories they own, repositories where they are a collaborator, and repositories that they can access through an organization membership.  You can find the permissions for the installation under the &#x60;permissions&#x60; key.
  # @param [Hash] opts the optional parameters
  # @option opts [Integer] :per_page The number of results per page (max 100).
  # @option opts [Integer] :page Page number of the results to fetch.
  # @return [OrgsListAppInstallations200Response]
  describe 'apps_list_installations_for_authenticated_user test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_list_plans
  # List plans
  # Lists all plans that are part of your GitHub Marketplace listing.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.
  # @param [Hash] opts the optional parameters
  # @option opts [Integer] :per_page The number of results per page (max 100).
  # @option opts [Integer] :page Page number of the results to fetch.
  # @return [Array<MarketplaceListingPlan>]
  describe 'apps_list_plans test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_list_plans_stubbed
  # List plans (stubbed)
  # Lists all plans that are part of your GitHub Marketplace listing.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.
  # @param [Hash] opts the optional parameters
  # @option opts [Integer] :per_page The number of results per page (max 100).
  # @option opts [Integer] :page Page number of the results to fetch.
  # @return [Array<MarketplaceListingPlan>]
  describe 'apps_list_plans_stubbed test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_list_repos_accessible_to_installation
  # List repositories accessible to the app installation
  # List repositories that an app installation can access.  You must use an [installation access token](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-an-installation) to access this endpoint.
  # @param [Hash] opts the optional parameters
  # @option opts [Integer] :per_page The number of results per page (max 100).
  # @option opts [Integer] :page Page number of the results to fetch.
  # @return [AppsListReposAccessibleToInstallation200Response]
  describe 'apps_list_repos_accessible_to_installation test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_list_subscriptions_for_authenticated_user
  # List subscriptions for the authenticated user
  # Lists the active subscriptions for the authenticated user. You must use a [user-to-server OAuth access token](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/#identifying-users-on-your-site), created for a user who has authorized your GitHub App, to access this endpoint. . OAuth Apps must authenticate using an [OAuth token](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/).
  # @param [Hash] opts the optional parameters
  # @option opts [Integer] :per_page The number of results per page (max 100).
  # @option opts [Integer] :page Page number of the results to fetch.
  # @return [Array<UserMarketplacePurchase>]
  describe 'apps_list_subscriptions_for_authenticated_user test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_list_subscriptions_for_authenticated_user_stubbed
  # List subscriptions for the authenticated user (stubbed)
  # Lists the active subscriptions for the authenticated user. You must use a [user-to-server OAuth access token](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/#identifying-users-on-your-site), created for a user who has authorized your GitHub App, to access this endpoint. . OAuth Apps must authenticate using an [OAuth token](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/).
  # @param [Hash] opts the optional parameters
  # @option opts [Integer] :per_page The number of results per page (max 100).
  # @option opts [Integer] :page Page number of the results to fetch.
  # @return [Array<UserMarketplacePurchase>]
  describe 'apps_list_subscriptions_for_authenticated_user_stubbed test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_list_webhook_deliveries
  # List deliveries for an app webhook
  # Returns a list of webhook deliveries for the webhook configured for a GitHub App.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
  # @param [Hash] opts the optional parameters
  # @option opts [Integer] :per_page The number of results per page (max 100).
  # @option opts [String] :cursor Used for pagination: the starting delivery from which the page of deliveries is fetched. Refer to the &#x60;link&#x60; header for the next and previous page cursors.
  # @return [Array<SimpleWebhookDelivery>]
  describe 'apps_list_webhook_deliveries test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_redeliver_webhook_delivery
  # Redeliver a delivery for an app webhook
  # Redeliver a delivery for the webhook configured for a GitHub App.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
  # @param delivery_id 
  # @param [Hash] opts the optional parameters
  # @return [Object]
  describe 'apps_redeliver_webhook_delivery test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_remove_repo_from_installation_for_authenticated_user
  # Remove a repository from an app installation
  # Remove a single repository from an installation. The authenticated user must have admin access to the repository.  You must use a personal access token (which you can create via the [command line](https://docs.github.com/github/authenticating-to-github/creating-a-personal-access-token) or [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication)) to access this endpoint.
  # @param installation_id The unique identifier of the installation.
  # @param repository_id The unique identifier of the repository.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'apps_remove_repo_from_installation_for_authenticated_user test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_reset_token
  # Reset a token
  # OAuth applications can use this API method to reset a valid OAuth token without end-user involvement. Applications must save the \&quot;token\&quot; property in the response because changes take effect immediately. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) when accessing this endpoint, using the OAuth application&#39;s &#x60;client_id&#x60; and &#x60;client_secret&#x60; as the username and password. Invalid tokens will return &#x60;404 NOT FOUND&#x60;.
  # @param client_id The client ID of the GitHub app.
  # @param apps_check_token_request 
  # @param [Hash] opts the optional parameters
  # @return [Authorization]
  describe 'apps_reset_token test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_revoke_installation_access_token
  # Revoke an installation access token
  # Revokes the installation token you&#39;re using to authenticate as an installation and access this endpoint.  Once an installation token is revoked, the token is invalidated and cannot be used. Other endpoints that require the revoked installation token must have a new installation token to work. You can create a new token using the \&quot;[Create an installation access token for an app](https://docs.github.com/rest/reference/apps#create-an-installation-access-token-for-an-app)\&quot; endpoint.  You must use an [installation access token](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-an-installation) to access this endpoint.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'apps_revoke_installation_access_token test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_scope_token
  # Create a scoped access token
  # Use a non-scoped user-to-server OAuth access token to create a repository scoped and/or permission scoped user-to-server OAuth access token. You can specify which repositories the token can access and which permissions are granted to the token. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) when accessing this endpoint, using the OAuth application&#39;s &#x60;client_id&#x60; and &#x60;client_secret&#x60; as the username and password. Invalid tokens will return &#x60;404 NOT FOUND&#x60;.
  # @param client_id The client ID of the GitHub app.
  # @param apps_scope_token_request 
  # @param [Hash] opts the optional parameters
  # @return [Authorization]
  describe 'apps_scope_token test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_suspend_installation
  # Suspend an app installation
  # Suspends a GitHub App on a user, organization, or business account, which blocks the app from accessing the account&#39;s resources. When a GitHub App is suspended, the app&#39;s access to the GitHub API or webhook events is blocked for that account.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
  # @param installation_id The unique identifier of the installation.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'apps_suspend_installation test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_unsuspend_installation
  # Unsuspend an app installation
  # Removes a GitHub App installation suspension.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
  # @param installation_id The unique identifier of the installation.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'apps_unsuspend_installation test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for apps_update_webhook_config_for_app
  # Update a webhook configuration for an app
  # Updates the webhook configuration for a GitHub App. For more information about configuring a webhook for your app, see \&quot;[Creating a GitHub App](/developers/apps/creating-a-github-app).\&quot;  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
  # @param apps_update_webhook_config_for_app_request 
  # @param [Hash] opts the optional parameters
  # @return [WebhookConfiguration]
  describe 'apps_update_webhook_config_for_app test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
