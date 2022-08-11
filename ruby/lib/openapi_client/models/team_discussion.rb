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
  # A team discussion is a persistent record of a free-form conversation within a team.
  class TeamDiscussion
    attr_accessor :author

    # The main text of the discussion.
    attr_accessor :body

    attr_accessor :body_html

    # The current version of the body content. If provided, this update operation will be rejected if the given version does not match the latest version on the server.
    attr_accessor :body_version

    attr_accessor :comments_count

    attr_accessor :comments_url

    attr_accessor :created_at

    attr_accessor :last_edited_at

    attr_accessor :html_url

    attr_accessor :node_id

    # The unique sequence number of a team discussion.
    attr_accessor :number

    # Whether or not this discussion should be pinned for easy retrieval.
    attr_accessor :pinned

    # Whether or not this discussion should be restricted to team members and organization administrators.
    attr_accessor :private

    attr_accessor :team_url

    # The title of the discussion.
    attr_accessor :title

    attr_accessor :updated_at

    attr_accessor :url

    attr_accessor :reactions

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'author' => :'author',
        :'body' => :'body',
        :'body_html' => :'body_html',
        :'body_version' => :'body_version',
        :'comments_count' => :'comments_count',
        :'comments_url' => :'comments_url',
        :'created_at' => :'created_at',
        :'last_edited_at' => :'last_edited_at',
        :'html_url' => :'html_url',
        :'node_id' => :'node_id',
        :'number' => :'number',
        :'pinned' => :'pinned',
        :'private' => :'private',
        :'team_url' => :'team_url',
        :'title' => :'title',
        :'updated_at' => :'updated_at',
        :'url' => :'url',
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
        :'author' => :'SimpleUser',
        :'body' => :'String',
        :'body_html' => :'String',
        :'body_version' => :'String',
        :'comments_count' => :'Integer',
        :'comments_url' => :'String',
        :'created_at' => :'Time',
        :'last_edited_at' => :'Time',
        :'html_url' => :'String',
        :'node_id' => :'String',
        :'number' => :'Integer',
        :'pinned' => :'Boolean',
        :'private' => :'Boolean',
        :'team_url' => :'String',
        :'title' => :'String',
        :'updated_at' => :'Time',
        :'url' => :'String',
        :'reactions' => :'ReactionRollup'
      }
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
        :'author',
        :'last_edited_at',
      ])
    end

    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `OpenapiClient::TeamDiscussion` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `OpenapiClient::TeamDiscussion`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'author')
        self.author = attributes[:'author']
      end

      if attributes.key?(:'body')
        self.body = attributes[:'body']
      end

      if attributes.key?(:'body_html')
        self.body_html = attributes[:'body_html']
      end

      if attributes.key?(:'body_version')
        self.body_version = attributes[:'body_version']
      end

      if attributes.key?(:'comments_count')
        self.comments_count = attributes[:'comments_count']
      end

      if attributes.key?(:'comments_url')
        self.comments_url = attributes[:'comments_url']
      end

      if attributes.key?(:'created_at')
        self.created_at = attributes[:'created_at']
      end

      if attributes.key?(:'last_edited_at')
        self.last_edited_at = attributes[:'last_edited_at']
      end

      if attributes.key?(:'html_url')
        self.html_url = attributes[:'html_url']
      end

      if attributes.key?(:'node_id')
        self.node_id = attributes[:'node_id']
      end

      if attributes.key?(:'number')
        self.number = attributes[:'number']
      end

      if attributes.key?(:'pinned')
        self.pinned = attributes[:'pinned']
      end

      if attributes.key?(:'private')
        self.private = attributes[:'private']
      end

      if attributes.key?(:'team_url')
        self.team_url = attributes[:'team_url']
      end

      if attributes.key?(:'title')
        self.title = attributes[:'title']
      end

      if attributes.key?(:'updated_at')
        self.updated_at = attributes[:'updated_at']
      end

      if attributes.key?(:'url')
        self.url = attributes[:'url']
      end

      if attributes.key?(:'reactions')
        self.reactions = attributes[:'reactions']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      if @body.nil?
        invalid_properties.push('invalid value for "body", body cannot be nil.')
      end

      if @body_html.nil?
        invalid_properties.push('invalid value for "body_html", body_html cannot be nil.')
      end

      if @body_version.nil?
        invalid_properties.push('invalid value for "body_version", body_version cannot be nil.')
      end

      if @comments_count.nil?
        invalid_properties.push('invalid value for "comments_count", comments_count cannot be nil.')
      end

      if @comments_url.nil?
        invalid_properties.push('invalid value for "comments_url", comments_url cannot be nil.')
      end

      if @created_at.nil?
        invalid_properties.push('invalid value for "created_at", created_at cannot be nil.')
      end

      if @html_url.nil?
        invalid_properties.push('invalid value for "html_url", html_url cannot be nil.')
      end

      if @node_id.nil?
        invalid_properties.push('invalid value for "node_id", node_id cannot be nil.')
      end

      if @number.nil?
        invalid_properties.push('invalid value for "number", number cannot be nil.')
      end

      if @pinned.nil?
        invalid_properties.push('invalid value for "pinned", pinned cannot be nil.')
      end

      if @private.nil?
        invalid_properties.push('invalid value for "private", private cannot be nil.')
      end

      if @team_url.nil?
        invalid_properties.push('invalid value for "team_url", team_url cannot be nil.')
      end

      if @title.nil?
        invalid_properties.push('invalid value for "title", title cannot be nil.')
      end

      if @updated_at.nil?
        invalid_properties.push('invalid value for "updated_at", updated_at cannot be nil.')
      end

      if @url.nil?
        invalid_properties.push('invalid value for "url", url cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @body.nil?
      return false if @body_html.nil?
      return false if @body_version.nil?
      return false if @comments_count.nil?
      return false if @comments_url.nil?
      return false if @created_at.nil?
      return false if @html_url.nil?
      return false if @node_id.nil?
      return false if @number.nil?
      return false if @pinned.nil?
      return false if @private.nil?
      return false if @team_url.nil?
      return false if @title.nil?
      return false if @updated_at.nil?
      return false if @url.nil?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          author == o.author &&
          body == o.body &&
          body_html == o.body_html &&
          body_version == o.body_version &&
          comments_count == o.comments_count &&
          comments_url == o.comments_url &&
          created_at == o.created_at &&
          last_edited_at == o.last_edited_at &&
          html_url == o.html_url &&
          node_id == o.node_id &&
          number == o.number &&
          pinned == o.pinned &&
          private == o.private &&
          team_url == o.team_url &&
          title == o.title &&
          updated_at == o.updated_at &&
          url == o.url &&
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
      [author, body, body_html, body_version, comments_count, comments_url, created_at, last_edited_at, html_url, node_id, number, pinned, private, team_url, title, updated_at, url, reactions].hash
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
