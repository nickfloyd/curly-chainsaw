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
  # Timeline Comment Event
  class TimelineCommentEvent
    attr_accessor :event

    attr_accessor :actor

    # Unique identifier of the issue comment
    attr_accessor :id

    attr_accessor :node_id

    # URL for the issue comment
    attr_accessor :url

    # Contents of the issue comment
    attr_accessor :body

    attr_accessor :body_text

    attr_accessor :body_html

    attr_accessor :html_url

    attr_accessor :user

    attr_accessor :created_at

    attr_accessor :updated_at

    attr_accessor :issue_url

    # How the author is associated with the repository.
    attr_accessor :author_association

    attr_accessor :performed_via_github_app

    attr_accessor :reactions

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
        :'event' => :'event',
        :'actor' => :'actor',
        :'id' => :'id',
        :'node_id' => :'node_id',
        :'url' => :'url',
        :'body' => :'body',
        :'body_text' => :'body_text',
        :'body_html' => :'body_html',
        :'html_url' => :'html_url',
        :'user' => :'user',
        :'created_at' => :'created_at',
        :'updated_at' => :'updated_at',
        :'issue_url' => :'issue_url',
        :'author_association' => :'author_association',
        :'performed_via_github_app' => :'performed_via_github_app',
        :'reactions' => :'reactions'
      }
    end

    # Returns all the JSON keys this model knows about
    def self.acceptable_attributes
      attribute_map.values
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'event' => :'String',
        :'actor' => :'SimpleUser1',
        :'id' => :'Integer',
        :'node_id' => :'String',
        :'url' => :'String',
        :'body' => :'String',
        :'body_text' => :'String',
        :'body_html' => :'String',
        :'html_url' => :'String',
        :'user' => :'SimpleUser1',
        :'created_at' => :'Time',
        :'updated_at' => :'Time',
        :'issue_url' => :'String',
        :'author_association' => :'String',
        :'performed_via_github_app' => :'GitHubApp1',
        :'reactions' => :'ReactionRollup'
      }
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
        :'performed_via_github_app',
      ])
    end

    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `OpenapiClient::TimelineCommentEvent` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `OpenapiClient::TimelineCommentEvent`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'event')
        self.event = attributes[:'event']
      end

      if attributes.key?(:'actor')
        self.actor = attributes[:'actor']
      end

      if attributes.key?(:'id')
        self.id = attributes[:'id']
      end

      if attributes.key?(:'node_id')
        self.node_id = attributes[:'node_id']
      end

      if attributes.key?(:'url')
        self.url = attributes[:'url']
      end

      if attributes.key?(:'body')
        self.body = attributes[:'body']
      end

      if attributes.key?(:'body_text')
        self.body_text = attributes[:'body_text']
      end

      if attributes.key?(:'body_html')
        self.body_html = attributes[:'body_html']
      end

      if attributes.key?(:'html_url')
        self.html_url = attributes[:'html_url']
      end

      if attributes.key?(:'user')
        self.user = attributes[:'user']
      end

      if attributes.key?(:'created_at')
        self.created_at = attributes[:'created_at']
      end

      if attributes.key?(:'updated_at')
        self.updated_at = attributes[:'updated_at']
      end

      if attributes.key?(:'issue_url')
        self.issue_url = attributes[:'issue_url']
      end

      if attributes.key?(:'author_association')
        self.author_association = attributes[:'author_association']
      end

      if attributes.key?(:'performed_via_github_app')
        self.performed_via_github_app = attributes[:'performed_via_github_app']
      end

      if attributes.key?(:'reactions')
        self.reactions = attributes[:'reactions']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      if @event.nil?
        invalid_properties.push('invalid value for "event", event cannot be nil.')
      end

      if @actor.nil?
        invalid_properties.push('invalid value for "actor", actor cannot be nil.')
      end

      if @id.nil?
        invalid_properties.push('invalid value for "id", id cannot be nil.')
      end

      if @node_id.nil?
        invalid_properties.push('invalid value for "node_id", node_id cannot be nil.')
      end

      if @url.nil?
        invalid_properties.push('invalid value for "url", url cannot be nil.')
      end

      if @html_url.nil?
        invalid_properties.push('invalid value for "html_url", html_url cannot be nil.')
      end

      if @user.nil?
        invalid_properties.push('invalid value for "user", user cannot be nil.')
      end

      if @created_at.nil?
        invalid_properties.push('invalid value for "created_at", created_at cannot be nil.')
      end

      if @updated_at.nil?
        invalid_properties.push('invalid value for "updated_at", updated_at cannot be nil.')
      end

      if @issue_url.nil?
        invalid_properties.push('invalid value for "issue_url", issue_url cannot be nil.')
      end

      if @author_association.nil?
        invalid_properties.push('invalid value for "author_association", author_association cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @event.nil?
      return false if @actor.nil?
      return false if @id.nil?
      return false if @node_id.nil?
      return false if @url.nil?
      return false if @html_url.nil?
      return false if @user.nil?
      return false if @created_at.nil?
      return false if @updated_at.nil?
      return false if @issue_url.nil?
      return false if @author_association.nil?
      author_association_validator = EnumAttributeValidator.new('String', ["COLLABORATOR", "CONTRIBUTOR", "FIRST_TIMER", "FIRST_TIME_CONTRIBUTOR", "MANNEQUIN", "MEMBER", "NONE", "OWNER"])
      return false unless author_association_validator.valid?(@author_association)
      true
    end

    # Custom attribute writer method checking allowed values (enum).
    # @param [Object] author_association Object to be assigned
    def author_association=(author_association)
      validator = EnumAttributeValidator.new('String', ["COLLABORATOR", "CONTRIBUTOR", "FIRST_TIMER", "FIRST_TIME_CONTRIBUTOR", "MANNEQUIN", "MEMBER", "NONE", "OWNER"])
      unless validator.valid?(author_association)
        fail ArgumentError, "invalid value for \"author_association\", must be one of #{validator.allowable_values}."
      end
      @author_association = author_association
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          event == o.event &&
          actor == o.actor &&
          id == o.id &&
          node_id == o.node_id &&
          url == o.url &&
          body == o.body &&
          body_text == o.body_text &&
          body_html == o.body_html &&
          html_url == o.html_url &&
          user == o.user &&
          created_at == o.created_at &&
          updated_at == o.updated_at &&
          issue_url == o.issue_url &&
          author_association == o.author_association &&
          performed_via_github_app == o.performed_via_github_app &&
          reactions == o.reactions
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [event, actor, id, node_id, url, body, body_text, body_html, html_url, user, created_at, updated_at, issue_url, author_association, performed_via_github_app, reactions].hash
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
