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

# Unit tests for OpenapiClient::InteractionRestrictions
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe OpenapiClient::InteractionRestrictions do
  let(:instance) { OpenapiClient::InteractionRestrictions.new }

  describe 'test an instance of InteractionRestrictions' do
    it 'should create an instance of InteractionRestrictions' do
      expect(instance).to be_instance_of(OpenapiClient::InteractionRestrictions)
    end
  end
  describe 'test attribute "limit"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
      # validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["existing_users", "contributors_only", "collaborators_only"])
      # validator.allowable_values.each do |value|
      #   expect { instance.limit = value }.not_to raise_error
      # end
    end
  end

  describe 'test attribute "expiry"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
      # validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["one_day", "three_days", "one_week", "one_month", "six_months"])
      # validator.allowable_values.each do |value|
      #   expect { instance.expiry = value }.not_to raise_error
      # end
    end
  end

end
