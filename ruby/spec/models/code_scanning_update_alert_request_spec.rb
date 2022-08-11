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

# Unit tests for OpenapiClient::CodeScanningUpdateAlertRequest
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe OpenapiClient::CodeScanningUpdateAlertRequest do
  let(:instance) { OpenapiClient::CodeScanningUpdateAlertRequest.new }

  describe 'test an instance of CodeScanningUpdateAlertRequest' do
    it 'should create an instance of CodeScanningUpdateAlertRequest' do
      expect(instance).to be_instance_of(OpenapiClient::CodeScanningUpdateAlertRequest)
    end
  end
  describe 'test attribute "state"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
      # validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["open", "dismissed"])
      # validator.allowable_values.each do |value|
      #   expect { instance.state = value }.not_to raise_error
      # end
    end
  end

  describe 'test attribute "dismissed_reason"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
      # validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["null", "false positive", "won't fix", "used in tests"])
      # validator.allowable_values.each do |value|
      #   expect { instance.dismissed_reason = value }.not_to raise_error
      # end
    end
  end

  describe 'test attribute "dismissed_comment"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end