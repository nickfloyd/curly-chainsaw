=begin
#GitHub v3 REST API

#GitHub's v3 REST API.

The version of the OpenAPI document: 1.1.4

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 6.0.1

=end

require 'spec_helper'
require 'json'

# Unit tests for OpenapiClient::DependencyGraphApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'DependencyGraphApi' do
  before do
    # run before each test
    @api_instance = OpenapiClient::DependencyGraphApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of DependencyGraphApi' do
    it 'should create an instance of DependencyGraphApi' do
      expect(@api_instance).to be_instance_of(OpenapiClient::DependencyGraphApi)
    end
  end

  # unit tests for dependency_graph_create_repository_snapshot
  # Create a snapshot of dependencies for a repository
  # Create a new snapshot of a repository&#39;s dependencies. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint for a repository that the requesting user has access to.
  # @param owner The account owner of the repository. The name is not case sensitive.
  # @param repo The name of the repository. The name is not case sensitive.
  # @param snapshot 
  # @param [Hash] opts the optional parameters
  # @return [DependencyGraphCreateRepositorySnapshot201Response]
  describe 'dependency_graph_create_repository_snapshot test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for dependency_graph_diff_range
  # Get a diff of the dependencies between commits
  # Gets the diff of the dependency changes between two commits of a repository, based on the changes to the dependency manifests made in those commits.
  # @param owner The account owner of the repository. The name is not case sensitive.
  # @param repo The name of the repository. The name is not case sensitive.
  # @param basehead The base and head Git revisions to compare. The Git revisions will be resolved to commit SHAs. Named revisions will be resolved to their corresponding HEAD commits, and an appropriate merge base will be determined. This parameter expects the format &#x60;{base}...{head}&#x60;.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :name The full path, relative to the repository root, of the dependency manifest file.
  # @return [Array<DependencyGraphDiffInner>]
  describe 'dependency_graph_diff_range test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end