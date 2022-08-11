=begin
#GitHub v3 REST API

#GitHub's v3 REST API.

The version of the OpenAPI document: 1.1.4

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 6.0.1

=end

require 'cgi'

module OpenapiClient
  class ScimApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Delete a SCIM user from an organization
    # 
    # @param org [String] The organization name. The name is not case sensitive.
    # @param scim_user_id [String] The unique identifier of the SCIM user.
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def scim_delete_user_from_org(org, scim_user_id, opts = {})
      scim_delete_user_from_org_with_http_info(org, scim_user_id, opts)
      nil
    end

    # Delete a SCIM user from an organization
    # 
    # @param org [String] The organization name. The name is not case sensitive.
    # @param scim_user_id [String] The unique identifier of the SCIM user.
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def scim_delete_user_from_org_with_http_info(org, scim_user_id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ScimApi.scim_delete_user_from_org ...'
      end
      # verify the required parameter 'org' is set
      if @api_client.config.client_side_validation && org.nil?
        fail ArgumentError, "Missing the required parameter 'org' when calling ScimApi.scim_delete_user_from_org"
      end
      # verify the required parameter 'scim_user_id' is set
      if @api_client.config.client_side_validation && scim_user_id.nil?
        fail ArgumentError, "Missing the required parameter 'scim_user_id' when calling ScimApi.scim_delete_user_from_org"
      end
      # resource path
      local_var_path = '/scim/v2/organizations/{org}/Users/{scim_user_id}'.sub('{' + 'org' + '}', CGI.escape(org.to_s)).sub('{' + 'scim_user_id' + '}', CGI.escape(scim_user_id.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json', 'application/scim+json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body]

      # return_type
      return_type = opts[:debug_return_type]

      # auth_names
      auth_names = opts[:debug_auth_names] || []

      new_options = opts.merge(
        :operation => :"ScimApi.scim_delete_user_from_org",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:DELETE, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: ScimApi#scim_delete_user_from_org\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Get SCIM provisioning information for a user
    # 
    # @param org [String] The organization name. The name is not case sensitive.
    # @param scim_user_id [String] The unique identifier of the SCIM user.
    # @param [Hash] opts the optional parameters
    # @return [SCIMUsers]
    def scim_get_provisioning_information_for_user(org, scim_user_id, opts = {})
      data, _status_code, _headers = scim_get_provisioning_information_for_user_with_http_info(org, scim_user_id, opts)
      data
    end

    # Get SCIM provisioning information for a user
    # 
    # @param org [String] The organization name. The name is not case sensitive.
    # @param scim_user_id [String] The unique identifier of the SCIM user.
    # @param [Hash] opts the optional parameters
    # @return [Array<(SCIMUsers, Integer, Hash)>] SCIMUsers data, response status code and response headers
    def scim_get_provisioning_information_for_user_with_http_info(org, scim_user_id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ScimApi.scim_get_provisioning_information_for_user ...'
      end
      # verify the required parameter 'org' is set
      if @api_client.config.client_side_validation && org.nil?
        fail ArgumentError, "Missing the required parameter 'org' when calling ScimApi.scim_get_provisioning_information_for_user"
      end
      # verify the required parameter 'scim_user_id' is set
      if @api_client.config.client_side_validation && scim_user_id.nil?
        fail ArgumentError, "Missing the required parameter 'scim_user_id' when calling ScimApi.scim_get_provisioning_information_for_user"
      end
      # resource path
      local_var_path = '/scim/v2/organizations/{org}/Users/{scim_user_id}'.sub('{' + 'org' + '}', CGI.escape(org.to_s)).sub('{' + 'scim_user_id' + '}', CGI.escape(scim_user_id.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/scim+json', 'application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body]

      # return_type
      return_type = opts[:debug_return_type] || 'SCIMUsers'

      # auth_names
      auth_names = opts[:debug_auth_names] || []

      new_options = opts.merge(
        :operation => :"ScimApi.scim_get_provisioning_information_for_user",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: ScimApi#scim_get_provisioning_information_for_user\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # List SCIM provisioned identities
    # Retrieves a paginated list of all provisioned organization members, including pending invitations. If you provide the `filter` parameter, the resources for all matching provisions members are returned.  When a user with a SAML-provisioned external identity leaves (or is removed from) an organization, the account's metadata is immediately removed. However, the returned list of user accounts might not always match the organization or enterprise member list you see on GitHub. This can happen in certain cases where an external identity associated with an organization will not match an organization member:   - When a user with a SCIM-provisioned external identity is removed from an organization, the account's metadata is preserved to allow the user to re-join the organization in the future.   - When inviting a user to join an organization, you can expect to see their external identity in the results before they accept the invitation, or if the invitation is cancelled (or never accepted).   - When a user is invited over SCIM, an external identity is created that matches with the invitee's email address. However, this identity is only linked to a user account when the user accepts the invitation by going through SAML SSO.  The returned list of external identities can include an entry for a `null` user. These are unlinked SAML identities that are created when a user goes through the following Single Sign-On (SSO) process but does not sign in to their GitHub account after completing SSO:  1. The user is granted access by the IdP and is not a member of the GitHub organization.  1. The user attempts to access the GitHub organization and initiates the SAML SSO process, and is not currently signed in to their GitHub account.  1. After successfully authenticating with the SAML SSO IdP, the `null` external identity entry is created and the user is prompted to sign in to their GitHub account:    - If the user signs in, their GitHub account is linked to this entry.    - If the user does not sign in (or does not create a new account when prompted), they are not added to the GitHub organization, and the external identity `null` entry remains in place.
    # @param org [String] The organization name. The name is not case sensitive.
    # @param [Hash] opts the optional parameters
    # @option opts [Integer] :start_index Used for pagination: the index of the first result to return.
    # @option opts [Integer] :count Used for pagination: the number of results to return.
    # @option opts [String] :filter Filters results using the equals query parameter operator (&#x60;eq&#x60;). You can filter results that are equal to &#x60;id&#x60;, &#x60;userName&#x60;, &#x60;emails&#x60;, and &#x60;external_id&#x60;. For example, to search for an identity with the &#x60;userName&#x60; Octocat, you would use this query:  &#x60;?filter&#x3D;userName%20eq%20\\\&quot;Octocat\\\&quot;&#x60;.  To filter results for the identity with the email &#x60;octocat@github.com&#x60;, you would use this query:  &#x60;?filter&#x3D;emails%20eq%20\\\&quot;octocat@github.com\\\&quot;&#x60;.
    # @return [SCIMUserList]
    def scim_list_provisioned_identities(org, opts = {})
      data, _status_code, _headers = scim_list_provisioned_identities_with_http_info(org, opts)
      data
    end

    # List SCIM provisioned identities
    # Retrieves a paginated list of all provisioned organization members, including pending invitations. If you provide the &#x60;filter&#x60; parameter, the resources for all matching provisions members are returned.  When a user with a SAML-provisioned external identity leaves (or is removed from) an organization, the account&#39;s metadata is immediately removed. However, the returned list of user accounts might not always match the organization or enterprise member list you see on GitHub. This can happen in certain cases where an external identity associated with an organization will not match an organization member:   - When a user with a SCIM-provisioned external identity is removed from an organization, the account&#39;s metadata is preserved to allow the user to re-join the organization in the future.   - When inviting a user to join an organization, you can expect to see their external identity in the results before they accept the invitation, or if the invitation is cancelled (or never accepted).   - When a user is invited over SCIM, an external identity is created that matches with the invitee&#39;s email address. However, this identity is only linked to a user account when the user accepts the invitation by going through SAML SSO.  The returned list of external identities can include an entry for a &#x60;null&#x60; user. These are unlinked SAML identities that are created when a user goes through the following Single Sign-On (SSO) process but does not sign in to their GitHub account after completing SSO:  1. The user is granted access by the IdP and is not a member of the GitHub organization.  1. The user attempts to access the GitHub organization and initiates the SAML SSO process, and is not currently signed in to their GitHub account.  1. After successfully authenticating with the SAML SSO IdP, the &#x60;null&#x60; external identity entry is created and the user is prompted to sign in to their GitHub account:    - If the user signs in, their GitHub account is linked to this entry.    - If the user does not sign in (or does not create a new account when prompted), they are not added to the GitHub organization, and the external identity &#x60;null&#x60; entry remains in place.
    # @param org [String] The organization name. The name is not case sensitive.
    # @param [Hash] opts the optional parameters
    # @option opts [Integer] :start_index Used for pagination: the index of the first result to return.
    # @option opts [Integer] :count Used for pagination: the number of results to return.
    # @option opts [String] :filter Filters results using the equals query parameter operator (&#x60;eq&#x60;). You can filter results that are equal to &#x60;id&#x60;, &#x60;userName&#x60;, &#x60;emails&#x60;, and &#x60;external_id&#x60;. For example, to search for an identity with the &#x60;userName&#x60; Octocat, you would use this query:  &#x60;?filter&#x3D;userName%20eq%20\\\&quot;Octocat\\\&quot;&#x60;.  To filter results for the identity with the email &#x60;octocat@github.com&#x60;, you would use this query:  &#x60;?filter&#x3D;emails%20eq%20\\\&quot;octocat@github.com\\\&quot;&#x60;.
    # @return [Array<(SCIMUserList, Integer, Hash)>] SCIMUserList data, response status code and response headers
    def scim_list_provisioned_identities_with_http_info(org, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ScimApi.scim_list_provisioned_identities ...'
      end
      # verify the required parameter 'org' is set
      if @api_client.config.client_side_validation && org.nil?
        fail ArgumentError, "Missing the required parameter 'org' when calling ScimApi.scim_list_provisioned_identities"
      end
      # resource path
      local_var_path = '/scim/v2/organizations/{org}/Users'.sub('{' + 'org' + '}', CGI.escape(org.to_s))

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'startIndex'] = opts[:'start_index'] if !opts[:'start_index'].nil?
      query_params[:'count'] = opts[:'count'] if !opts[:'count'].nil?
      query_params[:'filter'] = opts[:'filter'] if !opts[:'filter'].nil?

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/scim+json', 'application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body]

      # return_type
      return_type = opts[:debug_return_type] || 'SCIMUserList'

      # auth_names
      auth_names = opts[:debug_auth_names] || []

      new_options = opts.merge(
        :operation => :"ScimApi.scim_list_provisioned_identities",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: ScimApi#scim_list_provisioned_identities\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Provision and invite a SCIM user
    # Provision organization membership for a user, and send an activation email to the email address.
    # @param org [String] The organization name. The name is not case sensitive.
    # @param scim_provision_and_invite_user_request [ScimProvisionAndInviteUserRequest] 
    # @param [Hash] opts the optional parameters
    # @return [SCIMUsers]
    def scim_provision_and_invite_user(org, scim_provision_and_invite_user_request, opts = {})
      data, _status_code, _headers = scim_provision_and_invite_user_with_http_info(org, scim_provision_and_invite_user_request, opts)
      data
    end

    # Provision and invite a SCIM user
    # Provision organization membership for a user, and send an activation email to the email address.
    # @param org [String] The organization name. The name is not case sensitive.
    # @param scim_provision_and_invite_user_request [ScimProvisionAndInviteUserRequest] 
    # @param [Hash] opts the optional parameters
    # @return [Array<(SCIMUsers, Integer, Hash)>] SCIMUsers data, response status code and response headers
    def scim_provision_and_invite_user_with_http_info(org, scim_provision_and_invite_user_request, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ScimApi.scim_provision_and_invite_user ...'
      end
      # verify the required parameter 'org' is set
      if @api_client.config.client_side_validation && org.nil?
        fail ArgumentError, "Missing the required parameter 'org' when calling ScimApi.scim_provision_and_invite_user"
      end
      # verify the required parameter 'scim_provision_and_invite_user_request' is set
      if @api_client.config.client_side_validation && scim_provision_and_invite_user_request.nil?
        fail ArgumentError, "Missing the required parameter 'scim_provision_and_invite_user_request' when calling ScimApi.scim_provision_and_invite_user"
      end
      # resource path
      local_var_path = '/scim/v2/organizations/{org}/Users'.sub('{' + 'org' + '}', CGI.escape(org.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/scim+json', 'application/json'])
      # HTTP header 'Content-Type'
      content_type = @api_client.select_header_content_type(['application/json'])
      if !content_type.nil?
          header_params['Content-Type'] = content_type
      end

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body] || @api_client.object_to_http_body(scim_provision_and_invite_user_request)

      # return_type
      return_type = opts[:debug_return_type] || 'SCIMUsers'

      # auth_names
      auth_names = opts[:debug_auth_names] || []

      new_options = opts.merge(
        :operation => :"ScimApi.scim_provision_and_invite_user",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:POST, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: ScimApi#scim_provision_and_invite_user\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Update a provisioned organization membership
    # Replaces an existing provisioned user's information. You must provide all the information required for the user as if you were provisioning them for the first time. Any existing user information that you don't provide will be removed. If you want to only update a specific attribute, use the [Update an attribute for a SCIM user](https://docs.github.com/rest/reference/scim#update-an-attribute-for-a-scim-user) endpoint instead.  You must at least provide the required values for the user: `userName`, `name`, and `emails`.  **Warning:** Setting `active: false` removes the user from the organization, deletes the external identity, and deletes the associated `{scim_user_id}`.
    # @param org [String] The organization name. The name is not case sensitive.
    # @param scim_user_id [String] The unique identifier of the SCIM user.
    # @param scim_set_information_for_provisioned_user_request [ScimSetInformationForProvisionedUserRequest] 
    # @param [Hash] opts the optional parameters
    # @return [SCIMUsers]
    def scim_set_information_for_provisioned_user(org, scim_user_id, scim_set_information_for_provisioned_user_request, opts = {})
      data, _status_code, _headers = scim_set_information_for_provisioned_user_with_http_info(org, scim_user_id, scim_set_information_for_provisioned_user_request, opts)
      data
    end

    # Update a provisioned organization membership
    # Replaces an existing provisioned user&#39;s information. You must provide all the information required for the user as if you were provisioning them for the first time. Any existing user information that you don&#39;t provide will be removed. If you want to only update a specific attribute, use the [Update an attribute for a SCIM user](https://docs.github.com/rest/reference/scim#update-an-attribute-for-a-scim-user) endpoint instead.  You must at least provide the required values for the user: &#x60;userName&#x60;, &#x60;name&#x60;, and &#x60;emails&#x60;.  **Warning:** Setting &#x60;active: false&#x60; removes the user from the organization, deletes the external identity, and deletes the associated &#x60;{scim_user_id}&#x60;.
    # @param org [String] The organization name. The name is not case sensitive.
    # @param scim_user_id [String] The unique identifier of the SCIM user.
    # @param scim_set_information_for_provisioned_user_request [ScimSetInformationForProvisionedUserRequest] 
    # @param [Hash] opts the optional parameters
    # @return [Array<(SCIMUsers, Integer, Hash)>] SCIMUsers data, response status code and response headers
    def scim_set_information_for_provisioned_user_with_http_info(org, scim_user_id, scim_set_information_for_provisioned_user_request, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ScimApi.scim_set_information_for_provisioned_user ...'
      end
      # verify the required parameter 'org' is set
      if @api_client.config.client_side_validation && org.nil?
        fail ArgumentError, "Missing the required parameter 'org' when calling ScimApi.scim_set_information_for_provisioned_user"
      end
      # verify the required parameter 'scim_user_id' is set
      if @api_client.config.client_side_validation && scim_user_id.nil?
        fail ArgumentError, "Missing the required parameter 'scim_user_id' when calling ScimApi.scim_set_information_for_provisioned_user"
      end
      # verify the required parameter 'scim_set_information_for_provisioned_user_request' is set
      if @api_client.config.client_side_validation && scim_set_information_for_provisioned_user_request.nil?
        fail ArgumentError, "Missing the required parameter 'scim_set_information_for_provisioned_user_request' when calling ScimApi.scim_set_information_for_provisioned_user"
      end
      # resource path
      local_var_path = '/scim/v2/organizations/{org}/Users/{scim_user_id}'.sub('{' + 'org' + '}', CGI.escape(org.to_s)).sub('{' + 'scim_user_id' + '}', CGI.escape(scim_user_id.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/scim+json', 'application/json'])
      # HTTP header 'Content-Type'
      content_type = @api_client.select_header_content_type(['application/json'])
      if !content_type.nil?
          header_params['Content-Type'] = content_type
      end

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body] || @api_client.object_to_http_body(scim_set_information_for_provisioned_user_request)

      # return_type
      return_type = opts[:debug_return_type] || 'SCIMUsers'

      # auth_names
      auth_names = opts[:debug_auth_names] || []

      new_options = opts.merge(
        :operation => :"ScimApi.scim_set_information_for_provisioned_user",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:PUT, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: ScimApi#scim_set_information_for_provisioned_user\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Update an attribute for a SCIM user
    # Allows you to change a provisioned user's individual attributes. To change a user's values, you must provide a specific `Operations` JSON format that contains at least one of the `add`, `remove`, or `replace` operations. For examples and more information on the SCIM operations format, see the [SCIM specification](https://tools.ietf.org/html/rfc7644#section-3.5.2).  **Note:** Complicated SCIM `path` selectors that include filters are not supported. For example, a `path` selector defined as `\"path\": \"emails[type eq \\\"work\\\"]\"` will not work.  **Warning:** If you set `active:false` using the `replace` operation (as shown in the JSON example below), it removes the user from the organization, deletes the external identity, and deletes the associated `:scim_user_id`.  ``` {   \"Operations\":[{     \"op\":\"replace\",     \"value\":{       \"active\":false     }   }] } ```
    # @param org [String] The organization name. The name is not case sensitive.
    # @param scim_user_id [String] The unique identifier of the SCIM user.
    # @param scim_update_attribute_for_user_request [ScimUpdateAttributeForUserRequest] 
    # @param [Hash] opts the optional parameters
    # @return [SCIMUsers]
    def scim_update_attribute_for_user(org, scim_user_id, scim_update_attribute_for_user_request, opts = {})
      data, _status_code, _headers = scim_update_attribute_for_user_with_http_info(org, scim_user_id, scim_update_attribute_for_user_request, opts)
      data
    end

    # Update an attribute for a SCIM user
    # Allows you to change a provisioned user&#39;s individual attributes. To change a user&#39;s values, you must provide a specific &#x60;Operations&#x60; JSON format that contains at least one of the &#x60;add&#x60;, &#x60;remove&#x60;, or &#x60;replace&#x60; operations. For examples and more information on the SCIM operations format, see the [SCIM specification](https://tools.ietf.org/html/rfc7644#section-3.5.2).  **Note:** Complicated SCIM &#x60;path&#x60; selectors that include filters are not supported. For example, a &#x60;path&#x60; selector defined as &#x60;\&quot;path\&quot;: \&quot;emails[type eq \\\&quot;work\\\&quot;]\&quot;&#x60; will not work.  **Warning:** If you set &#x60;active:false&#x60; using the &#x60;replace&#x60; operation (as shown in the JSON example below), it removes the user from the organization, deletes the external identity, and deletes the associated &#x60;:scim_user_id&#x60;.  &#x60;&#x60;&#x60; {   \&quot;Operations\&quot;:[{     \&quot;op\&quot;:\&quot;replace\&quot;,     \&quot;value\&quot;:{       \&quot;active\&quot;:false     }   }] } &#x60;&#x60;&#x60;
    # @param org [String] The organization name. The name is not case sensitive.
    # @param scim_user_id [String] The unique identifier of the SCIM user.
    # @param scim_update_attribute_for_user_request [ScimUpdateAttributeForUserRequest] 
    # @param [Hash] opts the optional parameters
    # @return [Array<(SCIMUsers, Integer, Hash)>] SCIMUsers data, response status code and response headers
    def scim_update_attribute_for_user_with_http_info(org, scim_user_id, scim_update_attribute_for_user_request, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ScimApi.scim_update_attribute_for_user ...'
      end
      # verify the required parameter 'org' is set
      if @api_client.config.client_side_validation && org.nil?
        fail ArgumentError, "Missing the required parameter 'org' when calling ScimApi.scim_update_attribute_for_user"
      end
      # verify the required parameter 'scim_user_id' is set
      if @api_client.config.client_side_validation && scim_user_id.nil?
        fail ArgumentError, "Missing the required parameter 'scim_user_id' when calling ScimApi.scim_update_attribute_for_user"
      end
      # verify the required parameter 'scim_update_attribute_for_user_request' is set
      if @api_client.config.client_side_validation && scim_update_attribute_for_user_request.nil?
        fail ArgumentError, "Missing the required parameter 'scim_update_attribute_for_user_request' when calling ScimApi.scim_update_attribute_for_user"
      end
      # resource path
      local_var_path = '/scim/v2/organizations/{org}/Users/{scim_user_id}'.sub('{' + 'org' + '}', CGI.escape(org.to_s)).sub('{' + 'scim_user_id' + '}', CGI.escape(scim_user_id.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/scim+json', 'application/json'])
      # HTTP header 'Content-Type'
      content_type = @api_client.select_header_content_type(['application/json'])
      if !content_type.nil?
          header_params['Content-Type'] = content_type
      end

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body] || @api_client.object_to_http_body(scim_update_attribute_for_user_request)

      # return_type
      return_type = opts[:debug_return_type] || 'SCIMUsers'

      # auth_names
      auth_names = opts[:debug_auth_names] || []

      new_options = opts.merge(
        :operation => :"ScimApi.scim_update_attribute_for_user",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:PATCH, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: ScimApi#scim_update_attribute_for_user\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end
