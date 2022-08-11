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
  # Low-level Git commit operations within a repository
  class GitCommit
    # SHA for the commit
    attr_accessor :sha

    attr_accessor :node_id

    attr_accessor :url

    attr_accessor :author

    attr_accessor :committer

    # Message describing the purpose of the commit
    attr_accessor :message

    attr_accessor :tree

    attr_accessor :parents

    attr_accessor :verification

    attr_accessor :html_url

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'sha' => :'sha',
        :'node_id' => :'node_id',
        :'url' => :'url',
        :'author' => :'author',
        :'committer' => :'committer',
        :'message' => :'message',
        :'tree' => :'tree',
        :'parents' => :'parents',
        :'verification' => :'verification',
        :'html_url' => :'html_url'
      }
    end

    # Returns all the JSON keys this model knows about
    def self.acceptable_attributes
      attribute_map.values
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'sha' => :'String',
        :'node_id' => :'String',
        :'url' => :'String',
        :'author' => :'GitCommitAuthor',
        :'committer' => :'GitCommitAuthor',
        :'message' => :'String',
        :'tree' => :'GitCommitTree',
        :'parents' => :'Array<GitCommitParentsInner>',
        :'verification' => :'GitCommitVerification',
        :'html_url' => :'String'
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `OpenapiClient::GitCommit` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `OpenapiClient::GitCommit`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'sha')
        self.sha = attributes[:'sha']
      end

      if attributes.key?(:'node_id')
        self.node_id = attributes[:'node_id']
      end

      if attributes.key?(:'url')
        self.url = attributes[:'url']
      end

      if attributes.key?(:'author')
        self.author = attributes[:'author']
      end

      if attributes.key?(:'committer')
        self.committer = attributes[:'committer']
      end

      if attributes.key?(:'message')
        self.message = attributes[:'message']
      end

      if attributes.key?(:'tree')
        self.tree = attributes[:'tree']
      end

      if attributes.key?(:'parents')
        if (value = attributes[:'parents']).is_a?(Array)
          self.parents = value
        end
      end

      if attributes.key?(:'verification')
        self.verification = attributes[:'verification']
      end

      if attributes.key?(:'html_url')
        self.html_url = attributes[:'html_url']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      if @sha.nil?
        invalid_properties.push('invalid value for "sha", sha cannot be nil.')
      end

      if @node_id.nil?
        invalid_properties.push('invalid value for "node_id", node_id cannot be nil.')
      end

      if @url.nil?
        invalid_properties.push('invalid value for "url", url cannot be nil.')
      end

      if @author.nil?
        invalid_properties.push('invalid value for "author", author cannot be nil.')
      end

      if @committer.nil?
        invalid_properties.push('invalid value for "committer", committer cannot be nil.')
      end

      if @message.nil?
        invalid_properties.push('invalid value for "message", message cannot be nil.')
      end

      if @tree.nil?
        invalid_properties.push('invalid value for "tree", tree cannot be nil.')
      end

      if @parents.nil?
        invalid_properties.push('invalid value for "parents", parents cannot be nil.')
      end

      if @verification.nil?
        invalid_properties.push('invalid value for "verification", verification cannot be nil.')
      end

      if @html_url.nil?
        invalid_properties.push('invalid value for "html_url", html_url cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @sha.nil?
      return false if @node_id.nil?
      return false if @url.nil?
      return false if @author.nil?
      return false if @committer.nil?
      return false if @message.nil?
      return false if @tree.nil?
      return false if @parents.nil?
      return false if @verification.nil?
      return false if @html_url.nil?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          sha == o.sha &&
          node_id == o.node_id &&
          url == o.url &&
          author == o.author &&
          committer == o.committer &&
          message == o.message &&
          tree == o.tree &&
          parents == o.parents &&
          verification == o.verification &&
          html_url == o.html_url
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [sha, node_id, url, author, committer, message, tree, parents, verification, html_url].hash
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
