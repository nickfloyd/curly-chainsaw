=begin
#GitHub v3 REST API

#GitHub's v3 REST API.

The version of the OpenAPI document: 1.1.4

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 6.0.1

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for OpenapiClient::ActionsGetGithubActionsPermissionsOrganization200Response
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe OpenapiClient::ActionsGetGithubActionsPermissionsOrganization200Response do
  let(:instance) { OpenapiClient::ActionsGetGithubActionsPermissionsOrganization200Response.new }

  describe 'test an instance of ActionsGetGithubActionsPermissionsOrganization200Response' do
    it 'should create an instance of ActionsGetGithubActionsPermissionsOrganization200Response' do
      expect(instance).to be_instance_of(OpenapiClient::ActionsGetGithubActionsPermissionsOrganization200Response)
    end
  end
  describe 'test attribute "enabled_repositories"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
      # validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["all", "none", "selected"])
      # validator.allowable_values.each do |value|
      #   expect { instance.enabled_repositories = value }.not_to raise_error
      # end
    end
  end

  describe 'test attribute "selected_repositories_url"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "allowed_actions"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
      # validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["all", "local_only", "selected"])
      # validator.allowable_values.each do |value|
      #   expect { instance.allowed_actions = value }.not_to raise_error
      # end
    end
  end

  describe 'test attribute "selected_actions_url"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
