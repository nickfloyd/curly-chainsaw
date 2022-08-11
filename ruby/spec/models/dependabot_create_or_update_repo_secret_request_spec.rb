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

# Unit tests for OpenapiClient::DependabotCreateOrUpdateRepoSecretRequest
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe OpenapiClient::DependabotCreateOrUpdateRepoSecretRequest do
  let(:instance) { OpenapiClient::DependabotCreateOrUpdateRepoSecretRequest.new }

  describe 'test an instance of DependabotCreateOrUpdateRepoSecretRequest' do
    it 'should create an instance of DependabotCreateOrUpdateRepoSecretRequest' do
      expect(instance).to be_instance_of(OpenapiClient::DependabotCreateOrUpdateRepoSecretRequest)
    end
  end
  describe 'test attribute "encrypted_value"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "key_id"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
