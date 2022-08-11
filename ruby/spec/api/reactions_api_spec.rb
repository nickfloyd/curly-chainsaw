=begin
#GitHub v3 REST API

#GitHub's v3 REST API.

The version of the OpenAPI document: 1.1.4

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 6.0.1

=end

require 'spec_helper'
require 'json'

# Unit tests for OpenapiClient::ReactionsApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'ReactionsApi' do
  before do
    # run before each test
    @api_instance = OpenapiClient::ReactionsApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of ReactionsApi' do
    it 'should create an instance of ReactionsApi' do
      expect(@api_instance).to be_instance_of(OpenapiClient::ReactionsApi)
    end
  end

  # unit tests for reactions_create_for_commit_comment
  # Create reaction for a commit comment
  # Create a reaction to a [commit comment](https://docs.github.com/rest/reference/repos#comments). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this commit comment.
  # @param owner The account owner of the repository. The name is not case sensitive.
  # @param repo The name of the repository. The name is not case sensitive.
  # @param comment_id The unique identifier of the comment.
  # @param reactions_create_for_commit_comment_request 
  # @param [Hash] opts the optional parameters
  # @return [Reaction]
  describe 'reactions_create_for_commit_comment test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_create_for_issue
  # Create reaction for an issue
  # Create a reaction to an [issue](https://docs.github.com/rest/reference/issues/). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this issue.
  # @param owner The account owner of the repository. The name is not case sensitive.
  # @param repo The name of the repository. The name is not case sensitive.
  # @param issue_number The number that identifies the issue.
  # @param reactions_create_for_issue_request 
  # @param [Hash] opts the optional parameters
  # @return [Reaction]
  describe 'reactions_create_for_issue test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_create_for_issue_comment
  # Create reaction for an issue comment
  # Create a reaction to an [issue comment](https://docs.github.com/rest/reference/issues#comments). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this issue comment.
  # @param owner The account owner of the repository. The name is not case sensitive.
  # @param repo The name of the repository. The name is not case sensitive.
  # @param comment_id The unique identifier of the comment.
  # @param reactions_create_for_issue_comment_request 
  # @param [Hash] opts the optional parameters
  # @return [Reaction]
  describe 'reactions_create_for_issue_comment test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_create_for_pull_request_review_comment
  # Create reaction for a pull request review comment
  # Create a reaction to a [pull request review comment](https://docs.github.com/rest/reference/pulls#comments). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this pull request review comment.
  # @param owner The account owner of the repository. The name is not case sensitive.
  # @param repo The name of the repository. The name is not case sensitive.
  # @param comment_id The unique identifier of the comment.
  # @param reactions_create_for_pull_request_review_comment_request 
  # @param [Hash] opts the optional parameters
  # @return [Reaction]
  describe 'reactions_create_for_pull_request_review_comment test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_create_for_release
  # Create reaction for a release
  # Create a reaction to a [release](https://docs.github.com/rest/reference/repos#releases). A response with a &#x60;Status: 200 OK&#x60; means that you already added the reaction type to this release.
  # @param owner The account owner of the repository. The name is not case sensitive.
  # @param repo The name of the repository. The name is not case sensitive.
  # @param release_id The unique identifier of the release.
  # @param reactions_create_for_release_request 
  # @param [Hash] opts the optional parameters
  # @return [Reaction]
  describe 'reactions_create_for_release test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_create_for_team_discussion_comment_in_org
  # Create reaction for a team discussion comment
  # Create a reaction to a [team discussion comment](https://docs.github.com/rest/reference/teams#discussion-comments). OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this team discussion comment.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;POST /organizations/:org_id/team/:team_id/discussions/:discussion_number/comments/:comment_number/reactions&#x60;.
  # @param org The organization name. The name is not case sensitive.
  # @param team_slug The slug of the team name.
  # @param discussion_number The number that identifies the discussion.
  # @param comment_number The number that identifies the comment.
  # @param reactions_create_for_team_discussion_comment_in_org_request 
  # @param [Hash] opts the optional parameters
  # @return [Reaction]
  describe 'reactions_create_for_team_discussion_comment_in_org test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_create_for_team_discussion_comment_legacy
  # Create reaction for a team discussion comment (Legacy)
  # **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new \&quot;[Create reaction for a team discussion comment](https://docs.github.com/rest/reference/reactions#create-reaction-for-a-team-discussion-comment)\&quot; endpoint.  Create a reaction to a [team discussion comment](https://docs.github.com/rest/reference/teams#discussion-comments). OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this team discussion comment.
  # @param team_id The unique identifier of the team.
  # @param discussion_number The number that identifies the discussion.
  # @param comment_number The number that identifies the comment.
  # @param reactions_create_for_team_discussion_comment_in_org_request 
  # @param [Hash] opts the optional parameters
  # @return [Reaction]
  describe 'reactions_create_for_team_discussion_comment_legacy test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_create_for_team_discussion_in_org
  # Create reaction for a team discussion
  # Create a reaction to a [team discussion](https://docs.github.com/rest/reference/teams#discussions). OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this team discussion.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;POST /organizations/:org_id/team/:team_id/discussions/:discussion_number/reactions&#x60;.
  # @param org The organization name. The name is not case sensitive.
  # @param team_slug The slug of the team name.
  # @param discussion_number The number that identifies the discussion.
  # @param reactions_create_for_team_discussion_in_org_request 
  # @param [Hash] opts the optional parameters
  # @return [Reaction]
  describe 'reactions_create_for_team_discussion_in_org test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_create_for_team_discussion_legacy
  # Create reaction for a team discussion (Legacy)
  # **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;Create reaction for a team discussion&#x60;](https://docs.github.com/rest/reference/reactions#create-reaction-for-a-team-discussion) endpoint.  Create a reaction to a [team discussion](https://docs.github.com/rest/reference/teams#discussions). OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this team discussion.
  # @param team_id The unique identifier of the team.
  # @param discussion_number The number that identifies the discussion.
  # @param reactions_create_for_team_discussion_in_org_request 
  # @param [Hash] opts the optional parameters
  # @return [Reaction]
  describe 'reactions_create_for_team_discussion_legacy test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_delete_for_commit_comment
  # Delete a commit comment reaction
  # **Note:** You can also specify a repository by &#x60;repository_id&#x60; using the route &#x60;DELETE /repositories/:repository_id/comments/:comment_id/reactions/:reaction_id&#x60;.  Delete a reaction to a [commit comment](https://docs.github.com/rest/reference/repos#comments).
  # @param owner The account owner of the repository. The name is not case sensitive.
  # @param repo The name of the repository. The name is not case sensitive.
  # @param comment_id The unique identifier of the comment.
  # @param reaction_id The unique identifier of the reaction.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'reactions_delete_for_commit_comment test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_delete_for_issue
  # Delete an issue reaction
  # **Note:** You can also specify a repository by &#x60;repository_id&#x60; using the route &#x60;DELETE /repositories/:repository_id/issues/:issue_number/reactions/:reaction_id&#x60;.  Delete a reaction to an [issue](https://docs.github.com/rest/reference/issues/).
  # @param owner The account owner of the repository. The name is not case sensitive.
  # @param repo The name of the repository. The name is not case sensitive.
  # @param issue_number The number that identifies the issue.
  # @param reaction_id The unique identifier of the reaction.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'reactions_delete_for_issue test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_delete_for_issue_comment
  # Delete an issue comment reaction
  # **Note:** You can also specify a repository by &#x60;repository_id&#x60; using the route &#x60;DELETE delete /repositories/:repository_id/issues/comments/:comment_id/reactions/:reaction_id&#x60;.  Delete a reaction to an [issue comment](https://docs.github.com/rest/reference/issues#comments).
  # @param owner The account owner of the repository. The name is not case sensitive.
  # @param repo The name of the repository. The name is not case sensitive.
  # @param comment_id The unique identifier of the comment.
  # @param reaction_id The unique identifier of the reaction.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'reactions_delete_for_issue_comment test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_delete_for_pull_request_comment
  # Delete a pull request comment reaction
  # **Note:** You can also specify a repository by &#x60;repository_id&#x60; using the route &#x60;DELETE /repositories/:repository_id/pulls/comments/:comment_id/reactions/:reaction_id.&#x60;  Delete a reaction to a [pull request review comment](https://docs.github.com/rest/reference/pulls#review-comments).
  # @param owner The account owner of the repository. The name is not case sensitive.
  # @param repo The name of the repository. The name is not case sensitive.
  # @param comment_id The unique identifier of the comment.
  # @param reaction_id The unique identifier of the reaction.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'reactions_delete_for_pull_request_comment test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_delete_for_release
  # Delete a release reaction
  # **Note:** You can also specify a repository by &#x60;repository_id&#x60; using the route &#x60;DELETE delete /repositories/:repository_id/releases/:release_id/reactions/:reaction_id&#x60;.  Delete a reaction to a [release](https://docs.github.com/rest/reference/repos#releases).
  # @param owner The account owner of the repository. The name is not case sensitive.
  # @param repo The name of the repository. The name is not case sensitive.
  # @param release_id The unique identifier of the release.
  # @param reaction_id The unique identifier of the reaction.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'reactions_delete_for_release test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_delete_for_team_discussion
  # Delete team discussion reaction
  # **Note:** You can also specify a team or organization with &#x60;team_id&#x60; and &#x60;org_id&#x60; using the route &#x60;DELETE /organizations/:org_id/team/:team_id/discussions/:discussion_number/reactions/:reaction_id&#x60;.  Delete a reaction to a [team discussion](https://docs.github.com/rest/reference/teams#discussions). OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
  # @param org The organization name. The name is not case sensitive.
  # @param team_slug The slug of the team name.
  # @param discussion_number The number that identifies the discussion.
  # @param reaction_id The unique identifier of the reaction.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'reactions_delete_for_team_discussion test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_delete_for_team_discussion_comment
  # Delete team discussion comment reaction
  # **Note:** You can also specify a team or organization with &#x60;team_id&#x60; and &#x60;org_id&#x60; using the route &#x60;DELETE /organizations/:org_id/team/:team_id/discussions/:discussion_number/comments/:comment_number/reactions/:reaction_id&#x60;.  Delete a reaction to a [team discussion comment](https://docs.github.com/rest/reference/teams#discussion-comments). OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
  # @param org The organization name. The name is not case sensitive.
  # @param team_slug The slug of the team name.
  # @param discussion_number The number that identifies the discussion.
  # @param comment_number The number that identifies the comment.
  # @param reaction_id The unique identifier of the reaction.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'reactions_delete_for_team_discussion_comment test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_list_for_commit_comment
  # List reactions for a commit comment
  # List the reactions to a [commit comment](https://docs.github.com/rest/reference/repos#comments).
  # @param owner The account owner of the repository. The name is not case sensitive.
  # @param repo The name of the repository. The name is not case sensitive.
  # @param comment_id The unique identifier of the comment.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :content Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a commit comment.
  # @option opts [Integer] :per_page The number of results per page (max 100).
  # @option opts [Integer] :page Page number of the results to fetch.
  # @return [Array<Reaction>]
  describe 'reactions_list_for_commit_comment test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_list_for_issue
  # List reactions for an issue
  # List the reactions to an [issue](https://docs.github.com/rest/reference/issues).
  # @param owner The account owner of the repository. The name is not case sensitive.
  # @param repo The name of the repository. The name is not case sensitive.
  # @param issue_number The number that identifies the issue.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :content Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to an issue.
  # @option opts [Integer] :per_page The number of results per page (max 100).
  # @option opts [Integer] :page Page number of the results to fetch.
  # @return [Array<Reaction>]
  describe 'reactions_list_for_issue test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_list_for_issue_comment
  # List reactions for an issue comment
  # List the reactions to an [issue comment](https://docs.github.com/rest/reference/issues#comments).
  # @param owner The account owner of the repository. The name is not case sensitive.
  # @param repo The name of the repository. The name is not case sensitive.
  # @param comment_id The unique identifier of the comment.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :content Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to an issue comment.
  # @option opts [Integer] :per_page The number of results per page (max 100).
  # @option opts [Integer] :page Page number of the results to fetch.
  # @return [Array<Reaction>]
  describe 'reactions_list_for_issue_comment test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_list_for_pull_request_review_comment
  # List reactions for a pull request review comment
  # List the reactions to a [pull request review comment](https://docs.github.com/rest/reference/pulls#review-comments).
  # @param owner The account owner of the repository. The name is not case sensitive.
  # @param repo The name of the repository. The name is not case sensitive.
  # @param comment_id The unique identifier of the comment.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :content Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a pull request review comment.
  # @option opts [Integer] :per_page The number of results per page (max 100).
  # @option opts [Integer] :page Page number of the results to fetch.
  # @return [Array<Reaction>]
  describe 'reactions_list_for_pull_request_review_comment test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_list_for_release
  # List reactions for a release
  # List the reactions to a [release](https://docs.github.com/rest/reference/repos#releases).
  # @param owner The account owner of the repository. The name is not case sensitive.
  # @param repo The name of the repository. The name is not case sensitive.
  # @param release_id The unique identifier of the release.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :content Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a release.
  # @option opts [Integer] :per_page The number of results per page (max 100).
  # @option opts [Integer] :page Page number of the results to fetch.
  # @return [Array<Reaction>]
  describe 'reactions_list_for_release test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_list_for_team_discussion_comment_in_org
  # List reactions for a team discussion comment
  # List the reactions to a [team discussion comment](https://docs.github.com/rest/reference/teams#discussion-comments/). OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/:org_id/team/:team_id/discussions/:discussion_number/comments/:comment_number/reactions&#x60;.
  # @param org The organization name. The name is not case sensitive.
  # @param team_slug The slug of the team name.
  # @param discussion_number The number that identifies the discussion.
  # @param comment_number The number that identifies the comment.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :content Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a team discussion comment.
  # @option opts [Integer] :per_page The number of results per page (max 100).
  # @option opts [Integer] :page Page number of the results to fetch.
  # @return [Array<Reaction>]
  describe 'reactions_list_for_team_discussion_comment_in_org test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_list_for_team_discussion_comment_legacy
  # List reactions for a team discussion comment (Legacy)
  # **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;List reactions for a team discussion comment&#x60;](https://docs.github.com/rest/reference/reactions#list-reactions-for-a-team-discussion-comment) endpoint.  List the reactions to a [team discussion comment](https://docs.github.com/rest/reference/teams#discussion-comments). OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
  # @param team_id The unique identifier of the team.
  # @param discussion_number The number that identifies the discussion.
  # @param comment_number The number that identifies the comment.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :content Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a team discussion comment.
  # @option opts [Integer] :per_page The number of results per page (max 100).
  # @option opts [Integer] :page Page number of the results to fetch.
  # @return [Array<Reaction>]
  describe 'reactions_list_for_team_discussion_comment_legacy test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_list_for_team_discussion_in_org
  # List reactions for a team discussion
  # List the reactions to a [team discussion](https://docs.github.com/rest/reference/teams#discussions). OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/:org_id/team/:team_id/discussions/:discussion_number/reactions&#x60;.
  # @param org The organization name. The name is not case sensitive.
  # @param team_slug The slug of the team name.
  # @param discussion_number The number that identifies the discussion.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :content Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a team discussion.
  # @option opts [Integer] :per_page The number of results per page (max 100).
  # @option opts [Integer] :page Page number of the results to fetch.
  # @return [Array<Reaction>]
  describe 'reactions_list_for_team_discussion_in_org test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for reactions_list_for_team_discussion_legacy
  # List reactions for a team discussion (Legacy)
  # **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;List reactions for a team discussion&#x60;](https://docs.github.com/rest/reference/reactions#list-reactions-for-a-team-discussion) endpoint.  List the reactions to a [team discussion](https://docs.github.com/rest/reference/teams#discussions). OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
  # @param team_id The unique identifier of the team.
  # @param discussion_number The number that identifies the discussion.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :content Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a team discussion.
  # @option opts [Integer] :per_page The number of results per page (max 100).
  # @option opts [Integer] :page Page number of the results to fetch.
  # @return [Array<Reaction>]
  describe 'reactions_list_for_team_discussion_legacy test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
