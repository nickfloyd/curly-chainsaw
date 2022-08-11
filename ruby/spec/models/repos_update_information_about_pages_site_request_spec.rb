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

# Unit tests for OpenapiClient::ReposUpdateInformationAboutPagesSiteRequest
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe OpenapiClient::ReposUpdateInformationAboutPagesSiteRequest do
  let(:instance) { OpenapiClient::ReposUpdateInformationAboutPagesSiteRequest.new }

  describe 'test an instance of ReposUpdateInformationAboutPagesSiteRequest' do
    it 'should create an instance of ReposUpdateInformationAboutPagesSiteRequest' do
      expect(instance).to be_instance_of(OpenapiClient::ReposUpdateInformationAboutPagesSiteRequest)
    end
  end
  describe 'test attribute "cname"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "https_enforced"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "public"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "build_type"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
      # validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["legacy", "workflow"])
      # validator.allowable_values.each do |value|
      #   expect { instance.build_type = value }.not_to raise_error
      # end
    end
  end

  describe 'test attribute "source"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
