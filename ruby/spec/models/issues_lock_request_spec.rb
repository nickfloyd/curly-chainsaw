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

# Unit tests for OpenapiClient::IssuesLockRequest
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe OpenapiClient::IssuesLockRequest do
  let(:instance) { OpenapiClient::IssuesLockRequest.new }

  describe 'test an instance of IssuesLockRequest' do
    it 'should create an instance of IssuesLockRequest' do
      expect(instance).to be_instance_of(OpenapiClient::IssuesLockRequest)
    end
  end
  describe 'test attribute "lock_reason"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
      # validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["off-topic", "too heated", "resolved", "spam"])
      # validator.allowable_values.each do |value|
      #   expect { instance.lock_reason = value }.not_to raise_error
      # end
    end
  end

end
