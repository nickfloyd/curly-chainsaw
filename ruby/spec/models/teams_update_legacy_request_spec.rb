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

# Unit tests for OpenapiClient::TeamsUpdateLegacyRequest
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe OpenapiClient::TeamsUpdateLegacyRequest do
  let(:instance) { OpenapiClient::TeamsUpdateLegacyRequest.new }

  describe 'test an instance of TeamsUpdateLegacyRequest' do
    it 'should create an instance of TeamsUpdateLegacyRequest' do
      expect(instance).to be_instance_of(OpenapiClient::TeamsUpdateLegacyRequest)
    end
  end
  describe 'test attribute "name"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "description"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "privacy"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
      # validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["secret", "closed"])
      # validator.allowable_values.each do |value|
      #   expect { instance.privacy = value }.not_to raise_error
      # end
    end
  end

  describe 'test attribute "permission"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
      # validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["pull", "push", "admin"])
      # validator.allowable_values.each do |value|
      #   expect { instance.permission = value }.not_to raise_error
      # end
    end
  end

  describe 'test attribute "parent_team_id"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end