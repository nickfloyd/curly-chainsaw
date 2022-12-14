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
  # Credential Authorization
  class CredentialAuthorization
    # User login that owns the underlying credential.
    attr_accessor :login

    # Unique identifier for the credential.
    attr_accessor :credential_id

    # Human-readable description of the credential type.
    attr_accessor :credential_type

    # Last eight characters of the credential. Only included in responses with credential_type of personal access token.
    attr_accessor :token_last_eight

    # Date when the credential was authorized for use.
    attr_accessor :credential_authorized_at

    # List of oauth scopes the token has been granted.
    attr_accessor :scopes

    # Unique string to distinguish the credential. Only included in responses with credential_type of SSH Key.
    attr_accessor :fingerprint

    # Date when the credential was last accessed. May be null if it was never accessed
    attr_accessor :credential_accessed_at

    attr_accessor :authorized_credential_id

    # The title given to the ssh key. This will only be present when the credential is an ssh key.
    attr_accessor :authorized_credential_title

    # The note given to the token. This will only be present when the credential is a token.
    attr_accessor :authorized_credential_note

    # The expiry for the token. This will only be present when the credential is a token.
    attr_accessor :authorized_credential_expires_at

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'login' => :'login',
        :'credential_id' => :'credential_id',
        :'credential_type' => :'credential_type',
        :'token_last_eight' => :'token_last_eight',
        :'credential_authorized_at' => :'credential_authorized_at',
        :'scopes' => :'scopes',
        :'fingerprint' => :'fingerprint',
        :'credential_accessed_at' => :'credential_accessed_at',
        :'authorized_credential_id' => :'authorized_credential_id',
        :'authorized_credential_title' => :'authorized_credential_title',
        :'authorized_credential_note' => :'authorized_credential_note',
        :'authorized_credential_expires_at' => :'authorized_credential_expires_at'
      }
    end

    # Returns all the JSON keys this model knows about
    def self.acceptable_attributes
      attribute_map.values
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'login' => :'String',
        :'credential_id' => :'Integer',
        :'credential_type' => :'String',
        :'token_last_eight' => :'String',
        :'credential_authorized_at' => :'Time',
        :'scopes' => :'Array<String>',
        :'fingerprint' => :'String',
        :'credential_accessed_at' => :'Time',
        :'authorized_credential_id' => :'Integer',
        :'authorized_credential_title' => :'String',
        :'authorized_credential_note' => :'String',
        :'authorized_credential_expires_at' => :'Time'
      }
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
        :'credential_accessed_at',
        :'authorized_credential_id',
        :'authorized_credential_title',
        :'authorized_credential_note',
        :'authorized_credential_expires_at'
      ])
    end

    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `OpenapiClient::CredentialAuthorization` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `OpenapiClient::CredentialAuthorization`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'login')
        self.login = attributes[:'login']
      end

      if attributes.key?(:'credential_id')
        self.credential_id = attributes[:'credential_id']
      end

      if attributes.key?(:'credential_type')
        self.credential_type = attributes[:'credential_type']
      end

      if attributes.key?(:'token_last_eight')
        self.token_last_eight = attributes[:'token_last_eight']
      end

      if attributes.key?(:'credential_authorized_at')
        self.credential_authorized_at = attributes[:'credential_authorized_at']
      end

      if attributes.key?(:'scopes')
        if (value = attributes[:'scopes']).is_a?(Array)
          self.scopes = value
        end
      end

      if attributes.key?(:'fingerprint')
        self.fingerprint = attributes[:'fingerprint']
      end

      if attributes.key?(:'credential_accessed_at')
        self.credential_accessed_at = attributes[:'credential_accessed_at']
      end

      if attributes.key?(:'authorized_credential_id')
        self.authorized_credential_id = attributes[:'authorized_credential_id']
      end

      if attributes.key?(:'authorized_credential_title')
        self.authorized_credential_title = attributes[:'authorized_credential_title']
      end

      if attributes.key?(:'authorized_credential_note')
        self.authorized_credential_note = attributes[:'authorized_credential_note']
      end

      if attributes.key?(:'authorized_credential_expires_at')
        self.authorized_credential_expires_at = attributes[:'authorized_credential_expires_at']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      if @login.nil?
        invalid_properties.push('invalid value for "login", login cannot be nil.')
      end

      if @credential_id.nil?
        invalid_properties.push('invalid value for "credential_id", credential_id cannot be nil.')
      end

      if @credential_type.nil?
        invalid_properties.push('invalid value for "credential_type", credential_type cannot be nil.')
      end

      if @credential_authorized_at.nil?
        invalid_properties.push('invalid value for "credential_authorized_at", credential_authorized_at cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @login.nil?
      return false if @credential_id.nil?
      return false if @credential_type.nil?
      return false if @credential_authorized_at.nil?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          login == o.login &&
          credential_id == o.credential_id &&
          credential_type == o.credential_type &&
          token_last_eight == o.token_last_eight &&
          credential_authorized_at == o.credential_authorized_at &&
          scopes == o.scopes &&
          fingerprint == o.fingerprint &&
          credential_accessed_at == o.credential_accessed_at &&
          authorized_credential_id == o.authorized_credential_id &&
          authorized_credential_title == o.authorized_credential_title &&
          authorized_credential_note == o.authorized_credential_note &&
          authorized_credential_expires_at == o.authorized_credential_expires_at
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [login, credential_id, credential_type, token_last_eight, credential_authorized_at, scopes, fingerprint, credential_accessed_at, authorized_credential_id, authorized_credential_title, authorized_credential_note, authorized_credential_expires_at].hash
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
