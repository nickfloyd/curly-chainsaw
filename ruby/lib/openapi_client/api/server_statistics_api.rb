=begin
#GitHub v3 REST API

#GitHub's v3 REST API.

The version of the OpenAPI document: 1.1.4

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 6.0.1

=end

require 'cgi'

module OpenapiClient
  class ServerStatisticsApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Get GitHub Enterprise Server statistics
    # Returns aggregate usage metrics for your GitHub Enterprise Server 3.5+ instance for a specified time period up to 365 days.  To use this endpoint, your GitHub Enterprise Server instance must be connected to GitHub Enterprise Cloud using GitHub Connect. You must enable Server Statistics, and for the API request provide your enterprise account name or organization name connected to the GitHub Enterprise Server. For more information, see \"[Enabling Server Statistics for your enterprise](/admin/configuration/configuring-github-connect/enabling-server-statistics-for-your-enterprise)\" in the GitHub Enterprise Server documentation.  You'll need to use a personal access token:   - If you connected your GitHub Enterprise Server to an enterprise account and enabled Server Statistics, you'll need a personal access token with the `read:enterprise` permission.   - If you connected your GitHub Enterprise Server to an organization account and enabled Server Statistics, you'll need a personal access token with the `read:org` permission.  For more information on creating a personal access token, see \"[Creating a personal access token](/authentication/keeping-your-account-and-data-secure/creating-a-personal-access-token).\"
    # @param enterprise_or_org [String] The slug version of the enterprise name or the login of an organization.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :date_start A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.
    # @option opts [String] :date_end A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor.
    # @return [Array<ServerStatisticsProxyEndpointInner>]
    def enterprise_admin_get_server_statistics(enterprise_or_org, opts = {})
      data, _status_code, _headers = enterprise_admin_get_server_statistics_with_http_info(enterprise_or_org, opts)
      data
    end

    # Get GitHub Enterprise Server statistics
    # Returns aggregate usage metrics for your GitHub Enterprise Server 3.5+ instance for a specified time period up to 365 days.  To use this endpoint, your GitHub Enterprise Server instance must be connected to GitHub Enterprise Cloud using GitHub Connect. You must enable Server Statistics, and for the API request provide your enterprise account name or organization name connected to the GitHub Enterprise Server. For more information, see \&quot;[Enabling Server Statistics for your enterprise](/admin/configuration/configuring-github-connect/enabling-server-statistics-for-your-enterprise)\&quot; in the GitHub Enterprise Server documentation.  You&#39;ll need to use a personal access token:   - If you connected your GitHub Enterprise Server to an enterprise account and enabled Server Statistics, you&#39;ll need a personal access token with the &#x60;read:enterprise&#x60; permission.   - If you connected your GitHub Enterprise Server to an organization account and enabled Server Statistics, you&#39;ll need a personal access token with the &#x60;read:org&#x60; permission.  For more information on creating a personal access token, see \&quot;[Creating a personal access token](/authentication/keeping-your-account-and-data-secure/creating-a-personal-access-token).\&quot;
    # @param enterprise_or_org [String] The slug version of the enterprise name or the login of an organization.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :date_start A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.
    # @option opts [String] :date_end A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor.
    # @return [Array<(Array<ServerStatisticsProxyEndpointInner>, Integer, Hash)>] Array<ServerStatisticsProxyEndpointInner> data, response status code and response headers
    def enterprise_admin_get_server_statistics_with_http_info(enterprise_or_org, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ServerStatisticsApi.enterprise_admin_get_server_statistics ...'
      end
      # verify the required parameter 'enterprise_or_org' is set
      if @api_client.config.client_side_validation && enterprise_or_org.nil?
        fail ArgumentError, "Missing the required parameter 'enterprise_or_org' when calling ServerStatisticsApi.enterprise_admin_get_server_statistics"
      end
      # resource path
      local_var_path = '/enterprise-installation/{enterprise_or_org}/server-statistics'.sub('{' + 'enterprise_or_org' + '}', CGI.escape(enterprise_or_org.to_s))

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'date_start'] = opts[:'date_start'] if !opts[:'date_start'].nil?
      query_params[:'date_end'] = opts[:'date_end'] if !opts[:'date_end'].nil?

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body]

      # return_type
      return_type = opts[:debug_return_type] || 'Array<ServerStatisticsProxyEndpointInner>'

      # auth_names
      auth_names = opts[:debug_auth_names] || []

      new_options = opts.merge(
        :operation => :"ServerStatisticsApi.enterprise_admin_get_server_statistics",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: ServerStatisticsApi#enterprise_admin_get_server_statistics\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end
