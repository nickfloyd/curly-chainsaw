=begin
#GitHub v3 REST API

#GitHub's v3 REST API.

The version of the OpenAPI document: 1.1.4

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 6.0.1

=end

require 'date'
require 'time'

module OpenapiClient
  class RepositoryTemplateRepository
    attr_accessor :id

    attr_accessor :node_id

    attr_accessor :name

    attr_accessor :full_name

    attr_accessor :owner

    attr_accessor :private

    attr_accessor :html_url

    attr_accessor :description

    attr_accessor :fork

    attr_accessor :url

    attr_accessor :archive_url

    attr_accessor :assignees_url

    attr_accessor :blobs_url

    attr_accessor :branches_url

    attr_accessor :collaborators_url

    attr_accessor :comments_url

    attr_accessor :commits_url

    attr_accessor :compare_url

    attr_accessor :contents_url

    attr_accessor :contributors_url

    attr_accessor :deployments_url

    attr_accessor :downloads_url

    attr_accessor :events_url

    attr_accessor :forks_url

    attr_accessor :git_commits_url

    attr_accessor :git_refs_url

    attr_accessor :git_tags_url

    attr_accessor :git_url

    attr_accessor :issue_comment_url

    attr_accessor :issue_events_url

    attr_accessor :issues_url

    attr_accessor :keys_url

    attr_accessor :labels_url

    attr_accessor :languages_url

    attr_accessor :merges_url

    attr_accessor :milestones_url

    attr_accessor :notifications_url

    attr_accessor :pulls_url

    attr_accessor :releases_url

    attr_accessor :ssh_url

    attr_accessor :stargazers_url

    attr_accessor :statuses_url

    attr_accessor :subscribers_url

    attr_accessor :subscription_url

    attr_accessor :tags_url

    attr_accessor :teams_url

    attr_accessor :trees_url

    attr_accessor :clone_url

    attr_accessor :mirror_url

    attr_accessor :hooks_url

    attr_accessor :svn_url

    attr_accessor :homepage

    attr_accessor :language

    attr_accessor :forks_count

    attr_accessor :stargazers_count

    attr_accessor :watchers_count

    attr_accessor :size

    attr_accessor :default_branch

    attr_accessor :open_issues_count

    attr_accessor :is_template

    attr_accessor :topics

    attr_accessor :has_issues

    attr_accessor :has_projects

    attr_accessor :has_wiki

    attr_accessor :has_pages

    attr_accessor :has_downloads

    attr_accessor :archived

    attr_accessor :disabled

    attr_accessor :visibility

    attr_accessor :pushed_at

    attr_accessor :created_at

    attr_accessor :updated_at

    attr_accessor :permissions

    attr_accessor :allow_rebase_merge

    attr_accessor :temp_clone_token

    attr_accessor :allow_squash_merge

    attr_accessor :allow_auto_merge

    attr_accessor :delete_branch_on_merge

    attr_accessor :allow_update_branch

    attr_accessor :use_squash_pr_title_as_default

    attr_accessor :allow_merge_commit

    attr_accessor :subscribers_count

    attr_accessor :network_count

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'id' => :'id',
        :'node_id' => :'node_id',
        :'name' => :'name',
        :'full_name' => :'full_name',
        :'owner' => :'owner',
        :'private' => :'private',
        :'html_url' => :'html_url',
        :'description' => :'description',
        :'fork' => :'fork',
        :'url' => :'url',
        :'archive_url' => :'archive_url',
        :'assignees_url' => :'assignees_url',
        :'blobs_url' => :'blobs_url',
        :'branches_url' => :'branches_url',
        :'collaborators_url' => :'collaborators_url',
        :'comments_url' => :'comments_url',
        :'commits_url' => :'commits_url',
        :'compare_url' => :'compare_url',
        :'contents_url' => :'contents_url',
        :'contributors_url' => :'contributors_url',
        :'deployments_url' => :'deployments_url',
        :'downloads_url' => :'downloads_url',
        :'events_url' => :'events_url',
        :'forks_url' => :'forks_url',
        :'git_commits_url' => :'git_commits_url',
        :'git_refs_url' => :'git_refs_url',
        :'git_tags_url' => :'git_tags_url',
        :'git_url' => :'git_url',
        :'issue_comment_url' => :'issue_comment_url',
        :'issue_events_url' => :'issue_events_url',
        :'issues_url' => :'issues_url',
        :'keys_url' => :'keys_url',
        :'labels_url' => :'labels_url',
        :'languages_url' => :'languages_url',
        :'merges_url' => :'merges_url',
        :'milestones_url' => :'milestones_url',
        :'notifications_url' => :'notifications_url',
        :'pulls_url' => :'pulls_url',
        :'releases_url' => :'releases_url',
        :'ssh_url' => :'ssh_url',
        :'stargazers_url' => :'stargazers_url',
        :'statuses_url' => :'statuses_url',
        :'subscribers_url' => :'subscribers_url',
        :'subscription_url' => :'subscription_url',
        :'tags_url' => :'tags_url',
        :'teams_url' => :'teams_url',
        :'trees_url' => :'trees_url',
        :'clone_url' => :'clone_url',
        :'mirror_url' => :'mirror_url',
        :'hooks_url' => :'hooks_url',
        :'svn_url' => :'svn_url',
        :'homepage' => :'homepage',
        :'language' => :'language',
        :'forks_count' => :'forks_count',
        :'stargazers_count' => :'stargazers_count',
        :'watchers_count' => :'watchers_count',
        :'size' => :'size',
        :'default_branch' => :'default_branch',
        :'open_issues_count' => :'open_issues_count',
        :'is_template' => :'is_template',
        :'topics' => :'topics',
        :'has_issues' => :'has_issues',
        :'has_projects' => :'has_projects',
        :'has_wiki' => :'has_wiki',
        :'has_pages' => :'has_pages',
        :'has_downloads' => :'has_downloads',
        :'archived' => :'archived',
        :'disabled' => :'disabled',
        :'visibility' => :'visibility',
        :'pushed_at' => :'pushed_at',
        :'created_at' => :'created_at',
        :'updated_at' => :'updated_at',
        :'permissions' => :'permissions',
        :'allow_rebase_merge' => :'allow_rebase_merge',
        :'temp_clone_token' => :'temp_clone_token',
        :'allow_squash_merge' => :'allow_squash_merge',
        :'allow_auto_merge' => :'allow_auto_merge',
        :'delete_branch_on_merge' => :'delete_branch_on_merge',
        :'allow_update_branch' => :'allow_update_branch',
        :'use_squash_pr_title_as_default' => :'use_squash_pr_title_as_default',
        :'allow_merge_commit' => :'allow_merge_commit',
        :'subscribers_count' => :'subscribers_count',
        :'network_count' => :'network_count'
      }
    end

    # Returns all the JSON keys this model knows about
    def self.acceptable_attributes
      attribute_map.values
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'id' => :'Integer',
        :'node_id' => :'String',
        :'name' => :'String',
        :'full_name' => :'String',
        :'owner' => :'RepositoryTemplateRepositoryOwner',
        :'private' => :'Boolean',
        :'html_url' => :'String',
        :'description' => :'String',
        :'fork' => :'Boolean',
        :'url' => :'String',
        :'archive_url' => :'String',
        :'assignees_url' => :'String',
        :'blobs_url' => :'String',
        :'branches_url' => :'String',
        :'collaborators_url' => :'String',
        :'comments_url' => :'String',
        :'commits_url' => :'String',
        :'compare_url' => :'String',
        :'contents_url' => :'String',
        :'contributors_url' => :'String',
        :'deployments_url' => :'String',
        :'downloads_url' => :'String',
        :'events_url' => :'String',
        :'forks_url' => :'String',
        :'git_commits_url' => :'String',
        :'git_refs_url' => :'String',
        :'git_tags_url' => :'String',
        :'git_url' => :'String',
        :'issue_comment_url' => :'String',
        :'issue_events_url' => :'String',
        :'issues_url' => :'String',
        :'keys_url' => :'String',
        :'labels_url' => :'String',
        :'languages_url' => :'String',
        :'merges_url' => :'String',
        :'milestones_url' => :'String',
        :'notifications_url' => :'String',
        :'pulls_url' => :'String',
        :'releases_url' => :'String',
        :'ssh_url' => :'String',
        :'stargazers_url' => :'String',
        :'statuses_url' => :'String',
        :'subscribers_url' => :'String',
        :'subscription_url' => :'String',
        :'tags_url' => :'String',
        :'teams_url' => :'String',
        :'trees_url' => :'String',
        :'clone_url' => :'String',
        :'mirror_url' => :'String',
        :'hooks_url' => :'String',
        :'svn_url' => :'String',
        :'homepage' => :'String',
        :'language' => :'String',
        :'forks_count' => :'Integer',
        :'stargazers_count' => :'Integer',
        :'watchers_count' => :'Integer',
        :'size' => :'Integer',
        :'default_branch' => :'String',
        :'open_issues_count' => :'Integer',
        :'is_template' => :'Boolean',
        :'topics' => :'Array<String>',
        :'has_issues' => :'Boolean',
        :'has_projects' => :'Boolean',
        :'has_wiki' => :'Boolean',
        :'has_pages' => :'Boolean',
        :'has_downloads' => :'Boolean',
        :'archived' => :'Boolean',
        :'disabled' => :'Boolean',
        :'visibility' => :'String',
        :'pushed_at' => :'String',
        :'created_at' => :'String',
        :'updated_at' => :'String',
        :'permissions' => :'RepositoryTemplateRepositoryPermissions',
        :'allow_rebase_merge' => :'Boolean',
        :'temp_clone_token' => :'String',
        :'allow_squash_merge' => :'Boolean',
        :'allow_auto_merge' => :'Boolean',
        :'delete_branch_on_merge' => :'Boolean',
        :'allow_update_branch' => :'Boolean',
        :'use_squash_pr_title_as_default' => :'Boolean',
        :'allow_merge_commit' => :'Boolean',
        :'subscribers_count' => :'Integer',
        :'network_count' => :'Integer'
      }
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
      ])
    end

    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `OpenapiClient::RepositoryTemplateRepository` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `OpenapiClient::RepositoryTemplateRepository`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'id')
        self.id = attributes[:'id']
      end

      if attributes.key?(:'node_id')
        self.node_id = attributes[:'node_id']
      end

      if attributes.key?(:'name')
        self.name = attributes[:'name']
      end

      if attributes.key?(:'full_name')
        self.full_name = attributes[:'full_name']
      end

      if attributes.key?(:'owner')
        self.owner = attributes[:'owner']
      end

      if attributes.key?(:'private')
        self.private = attributes[:'private']
      end

      if attributes.key?(:'html_url')
        self.html_url = attributes[:'html_url']
      end

      if attributes.key?(:'description')
        self.description = attributes[:'description']
      end

      if attributes.key?(:'fork')
        self.fork = attributes[:'fork']
      end

      if attributes.key?(:'url')
        self.url = attributes[:'url']
      end

      if attributes.key?(:'archive_url')
        self.archive_url = attributes[:'archive_url']
      end

      if attributes.key?(:'assignees_url')
        self.assignees_url = attributes[:'assignees_url']
      end

      if attributes.key?(:'blobs_url')
        self.blobs_url = attributes[:'blobs_url']
      end

      if attributes.key?(:'branches_url')
        self.branches_url = attributes[:'branches_url']
      end

      if attributes.key?(:'collaborators_url')
        self.collaborators_url = attributes[:'collaborators_url']
      end

      if attributes.key?(:'comments_url')
        self.comments_url = attributes[:'comments_url']
      end

      if attributes.key?(:'commits_url')
        self.commits_url = attributes[:'commits_url']
      end

      if attributes.key?(:'compare_url')
        self.compare_url = attributes[:'compare_url']
      end

      if attributes.key?(:'contents_url')
        self.contents_url = attributes[:'contents_url']
      end

      if attributes.key?(:'contributors_url')
        self.contributors_url = attributes[:'contributors_url']
      end

      if attributes.key?(:'deployments_url')
        self.deployments_url = attributes[:'deployments_url']
      end

      if attributes.key?(:'downloads_url')
        self.downloads_url = attributes[:'downloads_url']
      end

      if attributes.key?(:'events_url')
        self.events_url = attributes[:'events_url']
      end

      if attributes.key?(:'forks_url')
        self.forks_url = attributes[:'forks_url']
      end

      if attributes.key?(:'git_commits_url')
        self.git_commits_url = attributes[:'git_commits_url']
      end

      if attributes.key?(:'git_refs_url')
        self.git_refs_url = attributes[:'git_refs_url']
      end

      if attributes.key?(:'git_tags_url')
        self.git_tags_url = attributes[:'git_tags_url']
      end

      if attributes.key?(:'git_url')
        self.git_url = attributes[:'git_url']
      end

      if attributes.key?(:'issue_comment_url')
        self.issue_comment_url = attributes[:'issue_comment_url']
      end

      if attributes.key?(:'issue_events_url')
        self.issue_events_url = attributes[:'issue_events_url']
      end

      if attributes.key?(:'issues_url')
        self.issues_url = attributes[:'issues_url']
      end

      if attributes.key?(:'keys_url')
        self.keys_url = attributes[:'keys_url']
      end

      if attributes.key?(:'labels_url')
        self.labels_url = attributes[:'labels_url']
      end

      if attributes.key?(:'languages_url')
        self.languages_url = attributes[:'languages_url']
      end

      if attributes.key?(:'merges_url')
        self.merges_url = attributes[:'merges_url']
      end

      if attributes.key?(:'milestones_url')
        self.milestones_url = attributes[:'milestones_url']
      end

      if attributes.key?(:'notifications_url')
        self.notifications_url = attributes[:'notifications_url']
      end

      if attributes.key?(:'pulls_url')
        self.pulls_url = attributes[:'pulls_url']
      end

      if attributes.key?(:'releases_url')
        self.releases_url = attributes[:'releases_url']
      end

      if attributes.key?(:'ssh_url')
        self.ssh_url = attributes[:'ssh_url']
      end

      if attributes.key?(:'stargazers_url')
        self.stargazers_url = attributes[:'stargazers_url']
      end

      if attributes.key?(:'statuses_url')
        self.statuses_url = attributes[:'statuses_url']
      end

      if attributes.key?(:'subscribers_url')
        self.subscribers_url = attributes[:'subscribers_url']
      end

      if attributes.key?(:'subscription_url')
        self.subscription_url = attributes[:'subscription_url']
      end

      if attributes.key?(:'tags_url')
        self.tags_url = attributes[:'tags_url']
      end

      if attributes.key?(:'teams_url')
        self.teams_url = attributes[:'teams_url']
      end

      if attributes.key?(:'trees_url')
        self.trees_url = attributes[:'trees_url']
      end

      if attributes.key?(:'clone_url')
        self.clone_url = attributes[:'clone_url']
      end

      if attributes.key?(:'mirror_url')
        self.mirror_url = attributes[:'mirror_url']
      end

      if attributes.key?(:'hooks_url')
        self.hooks_url = attributes[:'hooks_url']
      end

      if attributes.key?(:'svn_url')
        self.svn_url = attributes[:'svn_url']
      end

      if attributes.key?(:'homepage')
        self.homepage = attributes[:'homepage']
      end

      if attributes.key?(:'language')
        self.language = attributes[:'language']
      end

      if attributes.key?(:'forks_count')
        self.forks_count = attributes[:'forks_count']
      end

      if attributes.key?(:'stargazers_count')
        self.stargazers_count = attributes[:'stargazers_count']
      end

      if attributes.key?(:'watchers_count')
        self.watchers_count = attributes[:'watchers_count']
      end

      if attributes.key?(:'size')
        self.size = attributes[:'size']
      end

      if attributes.key?(:'default_branch')
        self.default_branch = attributes[:'default_branch']
      end

      if attributes.key?(:'open_issues_count')
        self.open_issues_count = attributes[:'open_issues_count']
      end

      if attributes.key?(:'is_template')
        self.is_template = attributes[:'is_template']
      end

      if attributes.key?(:'topics')
        if (value = attributes[:'topics']).is_a?(Array)
          self.topics = value
        end
      end

      if attributes.key?(:'has_issues')
        self.has_issues = attributes[:'has_issues']
      end

      if attributes.key?(:'has_projects')
        self.has_projects = attributes[:'has_projects']
      end

      if attributes.key?(:'has_wiki')
        self.has_wiki = attributes[:'has_wiki']
      end

      if attributes.key?(:'has_pages')
        self.has_pages = attributes[:'has_pages']
      end

      if attributes.key?(:'has_downloads')
        self.has_downloads = attributes[:'has_downloads']
      end

      if attributes.key?(:'archived')
        self.archived = attributes[:'archived']
      end

      if attributes.key?(:'disabled')
        self.disabled = attributes[:'disabled']
      end

      if attributes.key?(:'visibility')
        self.visibility = attributes[:'visibility']
      end

      if attributes.key?(:'pushed_at')
        self.pushed_at = attributes[:'pushed_at']
      end

      if attributes.key?(:'created_at')
        self.created_at = attributes[:'created_at']
      end

      if attributes.key?(:'updated_at')
        self.updated_at = attributes[:'updated_at']
      end

      if attributes.key?(:'permissions')
        self.permissions = attributes[:'permissions']
      end

      if attributes.key?(:'allow_rebase_merge')
        self.allow_rebase_merge = attributes[:'allow_rebase_merge']
      end

      if attributes.key?(:'temp_clone_token')
        self.temp_clone_token = attributes[:'temp_clone_token']
      end

      if attributes.key?(:'allow_squash_merge')
        self.allow_squash_merge = attributes[:'allow_squash_merge']
      end

      if attributes.key?(:'allow_auto_merge')
        self.allow_auto_merge = attributes[:'allow_auto_merge']
      end

      if attributes.key?(:'delete_branch_on_merge')
        self.delete_branch_on_merge = attributes[:'delete_branch_on_merge']
      end

      if attributes.key?(:'allow_update_branch')
        self.allow_update_branch = attributes[:'allow_update_branch']
      end

      if attributes.key?(:'use_squash_pr_title_as_default')
        self.use_squash_pr_title_as_default = attributes[:'use_squash_pr_title_as_default']
      end

      if attributes.key?(:'allow_merge_commit')
        self.allow_merge_commit = attributes[:'allow_merge_commit']
      end

      if attributes.key?(:'subscribers_count')
        self.subscribers_count = attributes[:'subscribers_count']
      end

      if attributes.key?(:'network_count')
        self.network_count = attributes[:'network_count']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          id == o.id &&
          node_id == o.node_id &&
          name == o.name &&
          full_name == o.full_name &&
          owner == o.owner &&
          private == o.private &&
          html_url == o.html_url &&
          description == o.description &&
          fork == o.fork &&
          url == o.url &&
          archive_url == o.archive_url &&
          assignees_url == o.assignees_url &&
          blobs_url == o.blobs_url &&
          branches_url == o.branches_url &&
          collaborators_url == o.collaborators_url &&
          comments_url == o.comments_url &&
          commits_url == o.commits_url &&
          compare_url == o.compare_url &&
          contents_url == o.contents_url &&
          contributors_url == o.contributors_url &&
          deployments_url == o.deployments_url &&
          downloads_url == o.downloads_url &&
          events_url == o.events_url &&
          forks_url == o.forks_url &&
          git_commits_url == o.git_commits_url &&
          git_refs_url == o.git_refs_url &&
          git_tags_url == o.git_tags_url &&
          git_url == o.git_url &&
          issue_comment_url == o.issue_comment_url &&
          issue_events_url == o.issue_events_url &&
          issues_url == o.issues_url &&
          keys_url == o.keys_url &&
          labels_url == o.labels_url &&
          languages_url == o.languages_url &&
          merges_url == o.merges_url &&
          milestones_url == o.milestones_url &&
          notifications_url == o.notifications_url &&
          pulls_url == o.pulls_url &&
          releases_url == o.releases_url &&
          ssh_url == o.ssh_url &&
          stargazers_url == o.stargazers_url &&
          statuses_url == o.statuses_url &&
          subscribers_url == o.subscribers_url &&
          subscription_url == o.subscription_url &&
          tags_url == o.tags_url &&
          teams_url == o.teams_url &&
          trees_url == o.trees_url &&
          clone_url == o.clone_url &&
          mirror_url == o.mirror_url &&
          hooks_url == o.hooks_url &&
          svn_url == o.svn_url &&
          homepage == o.homepage &&
          language == o.language &&
          forks_count == o.forks_count &&
          stargazers_count == o.stargazers_count &&
          watchers_count == o.watchers_count &&
          size == o.size &&
          default_branch == o.default_branch &&
          open_issues_count == o.open_issues_count &&
          is_template == o.is_template &&
          topics == o.topics &&
          has_issues == o.has_issues &&
          has_projects == o.has_projects &&
          has_wiki == o.has_wiki &&
          has_pages == o.has_pages &&
          has_downloads == o.has_downloads &&
          archived == o.archived &&
          disabled == o.disabled &&
          visibility == o.visibility &&
          pushed_at == o.pushed_at &&
          created_at == o.created_at &&
          updated_at == o.updated_at &&
          permissions == o.permissions &&
          allow_rebase_merge == o.allow_rebase_merge &&
          temp_clone_token == o.temp_clone_token &&
          allow_squash_merge == o.allow_squash_merge &&
          allow_auto_merge == o.allow_auto_merge &&
          delete_branch_on_merge == o.delete_branch_on_merge &&
          allow_update_branch == o.allow_update_branch &&
          use_squash_pr_title_as_default == o.use_squash_pr_title_as_default &&
          allow_merge_commit == o.allow_merge_commit &&
          subscribers_count == o.subscribers_count &&
          network_count == o.network_count
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [id, node_id, name, full_name, owner, private, html_url, description, fork, url, archive_url, assignees_url, blobs_url, branches_url, collaborators_url, comments_url, commits_url, compare_url, contents_url, contributors_url, deployments_url, downloads_url, events_url, forks_url, git_commits_url, git_refs_url, git_tags_url, git_url, issue_comment_url, issue_events_url, issues_url, keys_url, labels_url, languages_url, merges_url, milestones_url, notifications_url, pulls_url, releases_url, ssh_url, stargazers_url, statuses_url, subscribers_url, subscription_url, tags_url, teams_url, trees_url, clone_url, mirror_url, hooks_url, svn_url, homepage, language, forks_count, stargazers_count, watchers_count, size, default_branch, open_issues_count, is_template, topics, has_issues, has_projects, has_wiki, has_pages, has_downloads, archived, disabled, visibility, pushed_at, created_at, updated_at, permissions, allow_rebase_merge, temp_clone_token, allow_squash_merge, allow_auto_merge, delete_branch_on_merge, allow_update_branch, use_squash_pr_title_as_default, allow_merge_commit, subscribers_count, network_count].hash
    end

    # Builds the object from hash
    # @param [Hash] attributes Model attributes in the form of hash
    # @return [Object] Returns the model itself
    def self.build_from_hash(attributes)
      new.build_from_hash(attributes)
    end

    # Builds the object from hash
    # @param [Hash] attributes Model attributes in the form of hash
    # @return [Object] Returns the model itself
    def build_from_hash(attributes)
      return nil unless attributes.is_a?(Hash)
      attributes = attributes.transform_keys(&:to_sym)
      self.class.openapi_types.each_pair do |key, type|
        if attributes[self.class.attribute_map[key]].nil? && self.class.openapi_nullable.include?(key)
          self.send("#{key}=", nil)
        elsif type =~ /\AArray<(.*)>/i
          # check to ensure the input is an array given that the attribute
          # is documented as an array but the input is not
          if attributes[self.class.attribute_map[key]].is_a?(Array)
            self.send("#{key}=", attributes[self.class.attribute_map[key]].map { |v| _deserialize($1, v) })
          end
        elsif !attributes[self.class.attribute_map[key]].nil?
          self.send("#{key}=", _deserialize(type, attributes[self.class.attribute_map[key]]))
        end
      end

      self
    end

    # Deserializes the data based on type
    # @param string type Data type
    # @param string value Value to be deserialized
    # @return [Object] Deserialized data
    def _deserialize(type, value)
      case type.to_sym
      when :Time
        Time.parse(value)
      when :Date
        Date.parse(value)
      when :String
        value.to_s
      when :Integer
        value.to_i
      when :Float
        value.to_f
      when :Boolean
        if value.to_s =~ /\A(true|t|yes|y|1)\z/i
          true
        else
          false
        end
      when :Object
        # generic object (usually a Hash), return directly
        value
      when /\AArray<(?<inner_type>.+)>\z/
        inner_type = Regexp.last_match[:inner_type]
        value.map { |v| _deserialize(inner_type, v) }
      when /\AHash<(?<k_type>.+?), (?<v_type>.+)>\z/
        k_type = Regexp.last_match[:k_type]
        v_type = Regexp.last_match[:v_type]
        {}.tap do |hash|
          value.each do |k, v|
            hash[_deserialize(k_type, k)] = _deserialize(v_type, v)
          end
        end
      else # model
        # models (e.g. Pet) or oneOf
        klass = OpenapiClient.const_get(type)
        klass.respond_to?(:openapi_one_of) ? klass.build(value) : klass.build_from_hash(value)
      end
    end

    # Returns the string representation of the object
    # @return [String] String presentation of the object
    def to_s
      to_hash.to_s
    end

    # to_body is an alias to to_hash (backward compatibility)
    # @return [Hash] Returns the object in the form of hash
    def to_body
      to_hash
    end

    # Returns the object in the form of hash
    # @return [Hash] Returns the object in the form of hash
    def to_hash
      hash = {}
      self.class.attribute_map.each_pair do |attr, param|
        value = self.send(attr)
        if value.nil?
          is_nullable = self.class.openapi_nullable.include?(attr)
          next if !is_nullable || (is_nullable && !instance_variable_defined?(:"@#{attr}"))
        end

        hash[param] = _to_hash(value)
      end
      hash
    end

    # Outputs non-array value in the form of hash
    # For object, use to_hash. Otherwise, just return the value
    # @param [Object] value Any valid value
    # @return [Hash] Returns the value in the form of hash
    def _to_hash(value)
      if value.is_a?(Array)
        value.compact.map { |v| _to_hash(v) }
      elsif value.is_a?(Hash)
        {}.tap do |hash|
          value.each { |k, v| hash[k] = _to_hash(v) }
        end
      elsif value.respond_to? :to_hash
        value.to_hash
      else
        value
      end
    end

  end

end