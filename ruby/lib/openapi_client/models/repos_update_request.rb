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
  class ReposUpdateRequest
    # The name of the repository.
    attr_accessor :name

    # A short description of the repository.
    attr_accessor :description

    # A URL with more information about the repository.
    attr_accessor :homepage

    # Either `true` to make the repository private or `false` to make it public. Default: `false`.   **Note**: You will get a `422` error if the organization restricts [changing repository visibility](https://docs.github.com/articles/repository-permission-levels-for-an-organization#changing-the-visibility-of-repositories) to organization owners and a non-owner tries to change the value of private.
    attr_accessor :private

    # Can be `public` or `private`. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, `visibility` can also be `internal`.\"
    attr_accessor :visibility

    attr_accessor :security_and_analysis

    # Either `true` to enable issues for this repository or `false` to disable them.
    attr_accessor :has_issues

    # Either `true` to enable projects for this repository or `false` to disable them. **Note:** If you're creating a repository in an organization that has disabled repository projects, the default is `false`, and if you pass `true`, the API returns an error.
    attr_accessor :has_projects

    # Either `true` to enable the wiki for this repository or `false` to disable it.
    attr_accessor :has_wiki

    # Either `true` to make this repo available as a template repository or `false` to prevent it.
    attr_accessor :is_template

    # Updates the default branch for this repository.
    attr_accessor :default_branch

    # Either `true` to allow squash-merging pull requests, or `false` to prevent squash-merging.
    attr_accessor :allow_squash_merge

    # Either `true` to allow merging pull requests with a merge commit, or `false` to prevent merging pull requests with merge commits.
    attr_accessor :allow_merge_commit

    # Either `true` to allow rebase-merging pull requests, or `false` to prevent rebase-merging.
    attr_accessor :allow_rebase_merge

    # Either `true` to allow auto-merge on pull requests, or `false` to disallow auto-merge.
    attr_accessor :allow_auto_merge

    # Either `true` to allow automatically deleting head branches when pull requests are merged, or `false` to prevent automatic deletion.
    attr_accessor :delete_branch_on_merge

    # Either `true` to always allow a pull request head branch that is behind its base branch to be updated even if it is not required to be up to date before merging, or false otherwise.
    attr_accessor :allow_update_branch

    # Either `true` to allow squash-merge commits to use pull request title, or `false` to use commit message.
    attr_accessor :use_squash_pr_title_as_default

    # `true` to archive this repository. **Note**: You cannot unarchive repositories through the API.
    attr_accessor :archived

    # Either `true` to allow private forks, or `false` to prevent private forks.
    attr_accessor :allow_forking

    class EnumAttributeValidator
      attr_reader :datatype
      attr_reader :allowable_values

      def initialize(datatype, allowable_values)
        @allowable_values = allowable_values.map do |value|
          case datatype.to_s
          when /Integer/i
            value.to_i
          when /Float/i
            value.to_f
          else
            value
          end
        end
      end

      def valid?(value)
        !value || allowable_values.include?(value)
      end
    end

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'name' => :'name',
        :'description' => :'description',
        :'homepage' => :'homepage',
        :'private' => :'private',
        :'visibility' => :'visibility',
        :'security_and_analysis' => :'security_and_analysis',
        :'has_issues' => :'has_issues',
        :'has_projects' => :'has_projects',
        :'has_wiki' => :'has_wiki',
        :'is_template' => :'is_template',
        :'default_branch' => :'default_branch',
        :'allow_squash_merge' => :'allow_squash_merge',
        :'allow_merge_commit' => :'allow_merge_commit',
        :'allow_rebase_merge' => :'allow_rebase_merge',
        :'allow_auto_merge' => :'allow_auto_merge',
        :'delete_branch_on_merge' => :'delete_branch_on_merge',
        :'allow_update_branch' => :'allow_update_branch',
        :'use_squash_pr_title_as_default' => :'use_squash_pr_title_as_default',
        :'archived' => :'archived',
        :'allow_forking' => :'allow_forking'
      }
    end

    # Returns all the JSON keys this model knows about
    def self.acceptable_attributes
      attribute_map.values
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'name' => :'String',
        :'description' => :'String',
        :'homepage' => :'String',
        :'private' => :'Boolean',
        :'visibility' => :'String',
        :'security_and_analysis' => :'ReposUpdateRequestSecurityAndAnalysis',
        :'has_issues' => :'Boolean',
        :'has_projects' => :'Boolean',
        :'has_wiki' => :'Boolean',
        :'is_template' => :'Boolean',
        :'default_branch' => :'String',
        :'allow_squash_merge' => :'Boolean',
        :'allow_merge_commit' => :'Boolean',
        :'allow_rebase_merge' => :'Boolean',
        :'allow_auto_merge' => :'Boolean',
        :'delete_branch_on_merge' => :'Boolean',
        :'allow_update_branch' => :'Boolean',
        :'use_squash_pr_title_as_default' => :'Boolean',
        :'archived' => :'Boolean',
        :'allow_forking' => :'Boolean'
      }
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
        :'security_and_analysis',
      ])
    end

    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `OpenapiClient::ReposUpdateRequest` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `OpenapiClient::ReposUpdateRequest`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'name')
        self.name = attributes[:'name']
      end

      if attributes.key?(:'description')
        self.description = attributes[:'description']
      end

      if attributes.key?(:'homepage')
        self.homepage = attributes[:'homepage']
      end

      if attributes.key?(:'private')
        self.private = attributes[:'private']
      else
        self.private = false
      end

      if attributes.key?(:'visibility')
        self.visibility = attributes[:'visibility']
      end

      if attributes.key?(:'security_and_analysis')
        self.security_and_analysis = attributes[:'security_and_analysis']
      end

      if attributes.key?(:'has_issues')
        self.has_issues = attributes[:'has_issues']
      else
        self.has_issues = true
      end

      if attributes.key?(:'has_projects')
        self.has_projects = attributes[:'has_projects']
      else
        self.has_projects = true
      end

      if attributes.key?(:'has_wiki')
        self.has_wiki = attributes[:'has_wiki']
      else
        self.has_wiki = true
      end

      if attributes.key?(:'is_template')
        self.is_template = attributes[:'is_template']
      else
        self.is_template = false
      end

      if attributes.key?(:'default_branch')
        self.default_branch = attributes[:'default_branch']
      end

      if attributes.key?(:'allow_squash_merge')
        self.allow_squash_merge = attributes[:'allow_squash_merge']
      else
        self.allow_squash_merge = true
      end

      if attributes.key?(:'allow_merge_commit')
        self.allow_merge_commit = attributes[:'allow_merge_commit']
      else
        self.allow_merge_commit = true
      end

      if attributes.key?(:'allow_rebase_merge')
        self.allow_rebase_merge = attributes[:'allow_rebase_merge']
      else
        self.allow_rebase_merge = true
      end

      if attributes.key?(:'allow_auto_merge')
        self.allow_auto_merge = attributes[:'allow_auto_merge']
      else
        self.allow_auto_merge = false
      end

      if attributes.key?(:'delete_branch_on_merge')
        self.delete_branch_on_merge = attributes[:'delete_branch_on_merge']
      else
        self.delete_branch_on_merge = false
      end

      if attributes.key?(:'allow_update_branch')
        self.allow_update_branch = attributes[:'allow_update_branch']
      else
        self.allow_update_branch = false
      end

      if attributes.key?(:'use_squash_pr_title_as_default')
        self.use_squash_pr_title_as_default = attributes[:'use_squash_pr_title_as_default']
      else
        self.use_squash_pr_title_as_default = false
      end

      if attributes.key?(:'archived')
        self.archived = attributes[:'archived']
      else
        self.archived = false
      end

      if attributes.key?(:'allow_forking')
        self.allow_forking = attributes[:'allow_forking']
      else
        self.allow_forking = false
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
      visibility_validator = EnumAttributeValidator.new('String', ["public", "private", "internal"])
      return false unless visibility_validator.valid?(@visibility)
      true
    end

    # Custom attribute writer method checking allowed values (enum).
    # @param [Object] visibility Object to be assigned
    def visibility=(visibility)
      validator = EnumAttributeValidator.new('String', ["public", "private", "internal"])
      unless validator.valid?(visibility)
        fail ArgumentError, "invalid value for \"visibility\", must be one of #{validator.allowable_values}."
      end
      @visibility = visibility
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          name == o.name &&
          description == o.description &&
          homepage == o.homepage &&
          private == o.private &&
          visibility == o.visibility &&
          security_and_analysis == o.security_and_analysis &&
          has_issues == o.has_issues &&
          has_projects == o.has_projects &&
          has_wiki == o.has_wiki &&
          is_template == o.is_template &&
          default_branch == o.default_branch &&
          allow_squash_merge == o.allow_squash_merge &&
          allow_merge_commit == o.allow_merge_commit &&
          allow_rebase_merge == o.allow_rebase_merge &&
          allow_auto_merge == o.allow_auto_merge &&
          delete_branch_on_merge == o.delete_branch_on_merge &&
          allow_update_branch == o.allow_update_branch &&
          use_squash_pr_title_as_default == o.use_squash_pr_title_as_default &&
          archived == o.archived &&
          allow_forking == o.allow_forking
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [name, description, homepage, private, visibility, security_and_analysis, has_issues, has_projects, has_wiki, is_template, default_branch, allow_squash_merge, allow_merge_commit, allow_rebase_merge, allow_auto_merge, delete_branch_on_merge, allow_update_branch, use_squash_pr_title_as_default, archived, allow_forking].hash
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
