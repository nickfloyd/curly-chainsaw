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
  # A request for a specific ref(branch,sha,tag) to be deployed
  class Deployment
    attr_accessor :url

    # Unique identifier of the deployment
    attr_accessor :id

    attr_accessor :node_id

    attr_accessor :sha

    # The ref to deploy. This can be a branch, tag, or sha.
    attr_accessor :ref

    # Parameter to specify a task to execute
    attr_accessor :task

    attr_accessor :payload

    attr_accessor :original_environment

    # Name for the target deployment environment.
    attr_accessor :environment

    attr_accessor :description

    attr_accessor :creator

    attr_accessor :created_at

    attr_accessor :updated_at

    attr_accessor :statuses_url

    attr_accessor :repository_url

    # Specifies if the given environment is will no longer exist at some point in the future. Default: false.
    attr_accessor :transient_environment

    # Specifies if the given environment is one that end-users directly interact with. Default: false.
    attr_accessor :production_environment

    attr_accessor :performed_via_github_app

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'url' => :'url',
        :'id' => :'id',
        :'node_id' => :'node_id',
        :'sha' => :'sha',
        :'ref' => :'ref',
        :'task' => :'task',
        :'payload' => :'payload',
        :'original_environment' => :'original_environment',
        :'environment' => :'environment',
        :'description' => :'description',
        :'creator' => :'creator',
        :'created_at' => :'created_at',
        :'updated_at' => :'updated_at',
        :'statuses_url' => :'statuses_url',
        :'repository_url' => :'repository_url',
        :'transient_environment' => :'transient_environment',
        :'production_environment' => :'production_environment',
        :'performed_via_github_app' => :'performed_via_github_app'
      }
    end

    # Returns all the JSON keys this model knows about
    def self.acceptable_attributes
      attribute_map.values
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'url' => :'String',
        :'id' => :'Integer',
        :'node_id' => :'String',
        :'sha' => :'String',
        :'ref' => :'String',
        :'task' => :'String',
        :'payload' => :'DeploymentPayload',
        :'original_environment' => :'String',
        :'environment' => :'String',
        :'description' => :'String',
        :'creator' => :'SimpleUser',
        :'created_at' => :'Time',
        :'updated_at' => :'Time',
        :'statuses_url' => :'String',
        :'repository_url' => :'String',
        :'transient_environment' => :'Boolean',
        :'production_environment' => :'Boolean',
        :'performed_via_github_app' => :'GitHubApp1'
      }
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
        :'description',
        :'creator',
        :'performed_via_github_app'
      ])
    end

    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `OpenapiClient::Deployment` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `OpenapiClient::Deployment`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'url')
        self.url = attributes[:'url']
      end

      if attributes.key?(:'id')
        self.id = attributes[:'id']
      end

      if attributes.key?(:'node_id')
        self.node_id = attributes[:'node_id']
      end

      if attributes.key?(:'sha')
        self.sha = attributes[:'sha']
      end

      if attributes.key?(:'ref')
        self.ref = attributes[:'ref']
      end

      if attributes.key?(:'task')
        self.task = attributes[:'task']
      end

      if attributes.key?(:'payload')
        self.payload = attributes[:'payload']
      end

      if attributes.key?(:'original_environment')
        self.original_environment = attributes[:'original_environment']
      end

      if attributes.key?(:'environment')
        self.environment = attributes[:'environment']
      end

      if attributes.key?(:'description')
        self.description = attributes[:'description']
      end

      if attributes.key?(:'creator')
        self.creator = attributes[:'creator']
      end

      if attributes.key?(:'created_at')
        self.created_at = attributes[:'created_at']
      end

      if attributes.key?(:'updated_at')
        self.updated_at = attributes[:'updated_at']
      end

      if attributes.key?(:'statuses_url')
        self.statuses_url = attributes[:'statuses_url']
      end

      if attributes.key?(:'repository_url')
        self.repository_url = attributes[:'repository_url']
      end

      if attributes.key?(:'transient_environment')
        self.transient_environment = attributes[:'transient_environment']
      end

      if attributes.key?(:'production_environment')
        self.production_environment = attributes[:'production_environment']
      end

      if attributes.key?(:'performed_via_github_app')
        self.performed_via_github_app = attributes[:'performed_via_github_app']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      if @url.nil?
        invalid_properties.push('invalid value for "url", url cannot be nil.')
      end

      if @id.nil?
        invalid_properties.push('invalid value for "id", id cannot be nil.')
      end

      if @node_id.nil?
        invalid_properties.push('invalid value for "node_id", node_id cannot be nil.')
      end

      if @sha.nil?
        invalid_properties.push('invalid value for "sha", sha cannot be nil.')
      end

      if @ref.nil?
        invalid_properties.push('invalid value for "ref", ref cannot be nil.')
      end

      if @task.nil?
        invalid_properties.push('invalid value for "task", task cannot be nil.')
      end

      if @payload.nil?
        invalid_properties.push('invalid value for "payload", payload cannot be nil.')
      end

      if @environment.nil?
        invalid_properties.push('invalid value for "environment", environment cannot be nil.')
      end

      if @created_at.nil?
        invalid_properties.push('invalid value for "created_at", created_at cannot be nil.')
      end

      if @updated_at.nil?
        invalid_properties.push('invalid value for "updated_at", updated_at cannot be nil.')
      end

      if @statuses_url.nil?
        invalid_properties.push('invalid value for "statuses_url", statuses_url cannot be nil.')
      end

      if @repository_url.nil?
        invalid_properties.push('invalid value for "repository_url", repository_url cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @url.nil?
      return false if @id.nil?
      return false if @node_id.nil?
      return false if @sha.nil?
      return false if @ref.nil?
      return false if @task.nil?
      return false if @payload.nil?
      return false if @environment.nil?
      return false if @created_at.nil?
      return false if @updated_at.nil?
      return false if @statuses_url.nil?
      return false if @repository_url.nil?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          url == o.url &&
          id == o.id &&
          node_id == o.node_id &&
          sha == o.sha &&
          ref == o.ref &&
          task == o.task &&
          payload == o.payload &&
          original_environment == o.original_environment &&
          environment == o.environment &&
          description == o.description &&
          creator == o.creator &&
          created_at == o.created_at &&
          updated_at == o.updated_at &&
          statuses_url == o.statuses_url &&
          repository_url == o.repository_url &&
          transient_environment == o.transient_environment &&
          production_environment == o.production_environment &&
          performed_via_github_app == o.performed_via_github_app
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [url, id, node_id, sha, ref, task, payload, original_environment, environment, description, creator, created_at, updated_at, statuses_url, repository_url, transient_environment, production_environment, performed_via_github_app].hash
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
