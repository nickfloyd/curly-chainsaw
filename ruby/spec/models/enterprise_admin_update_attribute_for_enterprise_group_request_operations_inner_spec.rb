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

# Unit tests for OpenapiClient::EnterpriseAdminUpdateAttributeForEnterpriseGroupRequestOperationsInner
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe OpenapiClient::EnterpriseAdminUpdateAttributeForEnterpriseGroupRequestOperationsInner do
  let(:instance) { OpenapiClient::EnterpriseAdminUpdateAttributeForEnterpriseGroupRequestOperationsInner.new }

  describe 'test an instance of EnterpriseAdminUpdateAttributeForEnterpriseGroupRequestOperationsInner' do
    it 'should create an instance of EnterpriseAdminUpdateAttributeForEnterpriseGroupRequestOperationsInner' do
      expect(instance).to be_instance_of(OpenapiClient::EnterpriseAdminUpdateAttributeForEnterpriseGroupRequestOperationsInner)
    end
  end
  describe 'test attribute "op"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
      # validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["add", "Add", "remove", "Remove", "replace", "Replace"])
      # validator.allowable_values.each do |value|
      #   expect { instance.op = value }.not_to raise_error
      # end
    end
  end

  describe 'test attribute "path"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "value"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
