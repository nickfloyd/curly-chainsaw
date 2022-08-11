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
  # A suite of checks performed on the code of a given code change
  class CheckSuite
    attr_accessor :id

    attr_accessor :node_id

    attr_accessor :head_branch

    # The SHA of the head commit that is being checked.
    attr_accessor :head_sha

    attr_accessor :status

    attr_accessor :conclusion

    attr_accessor :url

    attr_accessor :before

    attr_accessor :after

    attr_accessor :pull_requests

    attr_accessor :app

    attr_accessor :repository

    attr_accessor :created_at

    attr_accessor :updated_at

    attr_accessor :head_commit

    attr_accessor :latest_check_runs_count

    attr_accessor :check_runs_url

    attr_accessor :rerequestable

    attr_accessor :runs_rerequestable

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
        :'id' => :'id',
        :'node_id' => :'node_id',
        :'head_branch' => :'head_branch',
        :'head_sha' => :'head_sha',
        :'status' => :'status',
        :'conclusion' => :'conclusion',
        :'url' => :'url',
        :'before' => :'before',
        :'after' => :'after',
        :'pull_requests' => :'pull_requests',
        :'app' => :'app',
        :'repository' => :'repository',
        :'created_at' => :'created_at',
        :'updated_at' => :'updated_at',
        :'head_commit' => :'head_commit',
        :'latest_check_runs_count' => :'latest_check_runs_count',
        :'check_runs_url' => :'check_runs_url',
        :'rerequestable' => :'rerequestable',
        :'runs_rerequestable' => :'runs_rerequestable'
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
        :'head_branch' => :'String',
        :'head_sha' => :'String',
        :'status' => :'String',
        :'conclusion' => :'String',
        :'url' => :'String',
        :'before' => :'String',
        :'after' => :'String',
        :'pull_requests' => :'Array<PullRequestMinimal>',
        :'app' => :'GitHubApp1',
        :'repository' => :'MinimalRepository',
        :'created_at' => :'Time',
        :'updated_at' => :'Time',
        :'head_commit' => :'SimpleCommit1',
        :'latest_check_runs_count' => :'Integer',
        :'check_runs_url' => :'String',
        :'rerequestable' => :'Boolean',
        :'runs_rerequestable' => :'Boolean'
      }
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
        :'head_branch',
        :'status',
        :'conclusion',
        :'url',
        :'before',
        :'after',
        :'pull_requests',
        :'app',
        :'created_at',
        :'updated_at',
      ])
    end

    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `OpenapiClient::CheckSuite` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `OpenapiClient::CheckSuite`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'id')
        self.id = attributes[:'id']
      end

      if attributes.key?(:'node_id')
        self.node_id = attributes[:'node_id']
      end

      if attributes.key?(:'head_branch')
        self.head_branch = attributes[:'head_branch']
      end

      if attributes.key?(:'head_sha')
        self.head_sha = attributes[:'head_sha']
      end

      if attributes.key?(:'status')
        self.status = attributes[:'status']
      end

      if attributes.key?(:'conclusion')
        self.conclusion = attributes[:'conclusion']
      end

      if attributes.key?(:'url')
        self.url = attributes[:'url']
      end

      if attributes.key?(:'before')
        self.before = attributes[:'before']
      end

      if attributes.key?(:'after')
        self.after = attributes[:'after']
      end

      if attributes.key?(:'pull_requests')
        if (value = attributes[:'pull_requests']).is_a?(Array)
          self.pull_requests = value
        end
      end

      if attributes.key?(:'app')
        self.app = attributes[:'app']
      end

      if attributes.key?(:'repository')
        self.repository = attributes[:'repository']
      end

      if attributes.key?(:'created_at')
        self.created_at = attributes[:'created_at']
      end

      if attributes.key?(:'updated_at')
        self.updated_at = attributes[:'updated_at']
      end

      if attributes.key?(:'head_commit')
        self.head_commit = attributes[:'head_commit']
      end

      if attributes.key?(:'latest_check_runs_count')
        self.latest_check_runs_count = attributes[:'latest_check_runs_count']
      end

      if attributes.key?(:'check_runs_url')
        self.check_runs_url = attributes[:'check_runs_url']
      end

      if attributes.key?(:'rerequestable')
        self.rerequestable = attributes[:'rerequestable']
      end

      if attributes.key?(:'runs_rerequestable')
        self.runs_rerequestable = attributes[:'runs_rerequestable']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      if @id.nil?
        invalid_properties.push('invalid value for "id", id cannot be nil.')
      end

      if @node_id.nil?
        invalid_properties.push('invalid value for "node_id", node_id cannot be nil.')
      end

      if @head_sha.nil?
        invalid_properties.push('invalid value for "head_sha", head_sha cannot be nil.')
      end

      if @repository.nil?
        invalid_properties.push('invalid value for "repository", repository cannot be nil.')
      end

      if @head_commit.nil?
        invalid_properties.push('invalid value for "head_commit", head_commit cannot be nil.')
      end

      if @latest_check_runs_count.nil?
        invalid_properties.push('invalid value for "latest_check_runs_count", latest_check_runs_count cannot be nil.')
      end

      if @check_runs_url.nil?
        invalid_properties.push('invalid value for "check_runs_url", check_runs_url cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @id.nil?
      return false if @node_id.nil?
      return false if @head_sha.nil?
      status_validator = EnumAttributeValidator.new('String', ["queued", "in_progress", "completed"])
      return false unless status_validator.valid?(@status)
      conclusion_validator = EnumAttributeValidator.new('String', ["success", "failure", "neutral", "cancelled", "skipped", "timed_out", "action_required"])
      return false unless conclusion_validator.valid?(@conclusion)
      return false if @repository.nil?
      return false if @head_commit.nil?
      return false if @latest_check_runs_count.nil?
      return false if @check_runs_url.nil?
      true
    end

    # Custom attribute writer method checking allowed values (enum).
    # @param [Object] status Object to be assigned
    def status=(status)
      validator = EnumAttributeValidator.new('String', ["queued", "in_progress", "completed"])
      unless validator.valid?(status)
        fail ArgumentError, "invalid value for \"status\", must be one of #{validator.allowable_values}."
      end
      @status = status
    end

    # Custom attribute writer method checking allowed values (enum).
    # @param [Object] conclusion Object to be assigned
    def conclusion=(conclusion)
      validator = EnumAttributeValidator.new('String', ["success", "failure", "neutral", "cancelled", "skipped", "timed_out", "action_required"])
      unless validator.valid?(conclusion)
        fail ArgumentError, "invalid value for \"conclusion\", must be one of #{validator.allowable_values}."
      end
      @conclusion = conclusion
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          id == o.id &&
          node_id == o.node_id &&
          head_branch == o.head_branch &&
          head_sha == o.head_sha &&
          status == o.status &&
          conclusion == o.conclusion &&
          url == o.url &&
          before == o.before &&
          after == o.after &&
          pull_requests == o.pull_requests &&
          app == o.app &&
          repository == o.repository &&
          created_at == o.created_at &&
          updated_at == o.updated_at &&
          head_commit == o.head_commit &&
          latest_check_runs_count == o.latest_check_runs_count &&
          check_runs_url == o.check_runs_url &&
          rerequestable == o.rerequestable &&
          runs_rerequestable == o.runs_rerequestable
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [id, node_id, head_branch, head_sha, status, conclusion, url, before, after, pull_requests, app, repository, created_at, updated_at, head_commit, latest_check_runs_count, check_runs_url, rerequestable, runs_rerequestable].hash
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
