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
  # Review Requested Issue Event
  class ReviewRequestedIssueEvent
    attr_accessor :id

    attr_accessor :node_id

    attr_accessor :url

    attr_accessor :actor

    attr_accessor :event

    attr_accessor :commit_id

    attr_accessor :commit_url

    attr_accessor :created_at

    attr_accessor :performed_via_github_app

    attr_accessor :review_requester

    attr_accessor :requested_team

    attr_accessor :requested_reviewer

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'id' => :'id',
        :'node_id' => :'node_id',
        :'url' => :'url',
        :'actor' => :'actor',
        :'event' => :'event',
        :'commit_id' => :'commit_id',
        :'commit_url' => :'commit_url',
        :'created_at' => :'created_at',
        :'performed_via_github_app' => :'performed_via_github_app',
        :'review_requester' => :'review_requester',
        :'requested_team' => :'requested_team',
        :'requested_reviewer' => :'requested_reviewer'
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
        :'url' => :'String',
        :'actor' => :'SimpleUser1',
        :'event' => :'String',
        :'commit_id' => :'String',
        :'commit_url' => :'String',
        :'created_at' => :'String',
        :'performed_via_github_app' => :'GitHubApp1',
        :'review_requester' => :'SimpleUser1',
        :'requested_team' => :'Team',
        :'requested_reviewer' => :'SimpleUser1'
      }
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
        :'commit_id',
        :'commit_url',
        :'performed_via_github_app',
      ])
    end

    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `OpenapiClient::ReviewRequestedIssueEvent` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `OpenapiClient::ReviewRequestedIssueEvent`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'id')
        self.id = attributes[:'id']
      end

      if attributes.key?(:'node_id')
        self.node_id = attributes[:'node_id']
      end

      if attributes.key?(:'url')
        self.url = attributes[:'url']
      end

      if attributes.key?(:'actor')
        self.actor = attributes[:'actor']
      end

      if attributes.key?(:'event')
        self.event = attributes[:'event']
      end

      if attributes.key?(:'commit_id')
        self.commit_id = attributes[:'commit_id']
      end

      if attributes.key?(:'commit_url')
        self.commit_url = attributes[:'commit_url']
      end

      if attributes.key?(:'created_at')
        self.created_at = attributes[:'created_at']
      end

      if attributes.key?(:'performed_via_github_app')
        self.performed_via_github_app = attributes[:'performed_via_github_app']
      end

      if attributes.key?(:'review_requester')
        self.review_requester = attributes[:'review_requester']
      end

      if attributes.key?(:'requested_team')
        self.requested_team = attributes[:'requested_team']
      end

      if attributes.key?(:'requested_reviewer')
        self.requested_reviewer = attributes[:'requested_reviewer']
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

      if @url.nil?
        invalid_properties.push('invalid value for "url", url cannot be nil.')
      end

      if @actor.nil?
        invalid_properties.push('invalid value for "actor", actor cannot be nil.')
      end

      if @event.nil?
        invalid_properties.push('invalid value for "event", event cannot be nil.')
      end

      if @created_at.nil?
        invalid_properties.push('invalid value for "created_at", created_at cannot be nil.')
      end

      if @review_requester.nil?
        invalid_properties.push('invalid value for "review_requester", review_requester cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @id.nil?
      return false if @node_id.nil?
      return false if @url.nil?
      return false if @actor.nil?
      return false if @event.nil?
      return false if @created_at.nil?
      return false if @review_requester.nil?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          id == o.id &&
          node_id == o.node_id &&
          url == o.url &&
          actor == o.actor &&
          event == o.event &&
          commit_id == o.commit_id &&
          commit_url == o.commit_url &&
          created_at == o.created_at &&
          performed_via_github_app == o.performed_via_github_app &&
          review_requester == o.review_requester &&
          requested_team == o.requested_team &&
          requested_reviewer == o.requested_reviewer
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [id, node_id, url, actor, event, commit_id, commit_url, created_at, performed_via_github_app, review_requester, requested_team, requested_reviewer].hash
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
