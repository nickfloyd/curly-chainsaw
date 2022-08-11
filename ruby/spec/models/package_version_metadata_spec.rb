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

# Unit tests for OpenapiClient::PackageVersionMetadata
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe OpenapiClient::PackageVersionMetadata do
  let(:instance) { OpenapiClient::PackageVersionMetadata.new }

  describe 'test an instance of PackageVersionMetadata' do
    it 'should create an instance of PackageVersionMetadata' do
      expect(instance).to be_instance_of(OpenapiClient::PackageVersionMetadata)
    end
  end
  describe 'test attribute "package_type"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
      # validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["npm", "maven", "rubygems", "docker", "nuget", "container"])
      # validator.allowable_values.each do |value|
      #   expect { instance.package_type = value }.not_to raise_error
      # end
    end
  end

  describe 'test attribute "container"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "docker"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
