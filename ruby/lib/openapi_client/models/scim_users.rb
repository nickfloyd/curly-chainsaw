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
  # SCIM /Users provisioning endpoints
  class SCIMUsers
    # SCIM schema used.
    attr_accessor :schemas

    # Unique identifier of an external identity
    attr_accessor :id

    # The ID of the User.
    attr_accessor :external_id

    # Configured by the admin. Could be an email, login, or username
    attr_accessor :user_name

    # The name of the user, suitable for display to end-users
    attr_accessor :display_name

    attr_accessor :name

    # user emails
    attr_accessor :emails

    # The active status of the User.
    attr_accessor :active

    attr_accessor :meta

    # The ID of the organization.
    attr_accessor :organization_id

    # Set of operations to be performed
    attr_accessor :operations

    # associated groups
    attr_accessor :groups

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'schemas' => :'schemas',
        :'id' => :'id',
        :'external_id' => :'externalId',
        :'user_name' => :'userName',
        :'display_name' => :'displayName',
        :'name' => :'name',
        :'emails' => :'emails',
        :'active' => :'active',
        :'meta' => :'meta',
        :'organization_id' => :'organization_id',
        :'operations' => :'operations',
        :'groups' => :'groups'
      }
    end

    # Returns all the JSON keys this model knows about
    def self.acceptable_attributes
      attribute_map.values
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'schemas' => :'Array<String>',
        :'id' => :'String',
        :'external_id' => :'String',
        :'user_name' => :'String',
        :'display_name' => :'String',
        :'name' => :'SCIMUsersName',
        :'emails' => :'Array<SCIMUsersEmailsInner>',
        :'active' => :'Boolean',
        :'meta' => :'SCIMUsersMeta',
        :'organization_id' => :'Integer',
        :'operations' => :'Array<SCIMUsersOperationsInner>',
        :'groups' => :'Array<SCIMUsersGroupsInner>'
      }
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
        :'external_id',
        :'user_name',
        :'display_name',
      ])
    end

    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `OpenapiClient::SCIMUsers` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `OpenapiClient::SCIMUsers`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'schemas')
        if (value = attributes[:'schemas']).is_a?(Array)
          self.schemas = value
        end
      end

      if attributes.key?(:'id')
        self.id = attributes[:'id']
      end

      if attributes.key?(:'external_id')
        self.external_id = attributes[:'external_id']
      end

      if attributes.key?(:'user_name')
        self.user_name = attributes[:'user_name']
      end

      if attributes.key?(:'display_name')
        self.display_name = attributes[:'display_name']
      end

      if attributes.key?(:'name')
        self.name = attributes[:'name']
      end

      if attributes.key?(:'emails')
        if (value = attributes[:'emails']).is_a?(Array)
          self.emails = value
        end
      end

      if attributes.key?(:'active')
        self.active = attributes[:'active']
      end

      if attributes.key?(:'meta')
        self.meta = attributes[:'meta']
      end

      if attributes.key?(:'organization_id')
        self.organization_id = attributes[:'organization_id']
      end

      if attributes.key?(:'operations')
        if (value = attributes[:'operations']).is_a?(Array)
          self.operations = value
        end
      end

      if attributes.key?(:'groups')
        if (value = attributes[:'groups']).is_a?(Array)
          self.groups = value
        end
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      if @schemas.nil?
        invalid_properties.push('invalid value for "schemas", schemas cannot be nil.')
      end

      if @schemas.length < 1
        invalid_properties.push('invalid value for "schemas", number of items must be greater than or equal to 1.')
      end

      if @id.nil?
        invalid_properties.push('invalid value for "id", id cannot be nil.')
      end

      if @name.nil?
        invalid_properties.push('invalid value for "name", name cannot be nil.')
      end

      if @emails.nil?
        invalid_properties.push('invalid value for "emails", emails cannot be nil.')
      end

      if @emails.length < 1
        invalid_properties.push('invalid value for "emails", number of items must be greater than or equal to 1.')
      end

      if @active.nil?
        invalid_properties.push('invalid value for "active", active cannot be nil.')
      end

      if @meta.nil?
        invalid_properties.push('invalid value for "meta", meta cannot be nil.')
      end

      if !@operations.nil? && @operations.length < 1
        invalid_properties.push('invalid value for "operations", number of items must be greater than or equal to 1.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @schemas.nil?
      return false if @schemas.length < 1
      return false if @id.nil?
      return false if @name.nil?
      return false if @emails.nil?
      return false if @emails.length < 1
      return false if @active.nil?
      return false if @meta.nil?
      return false if !@operations.nil? && @operations.length < 1
      true
    end

    # Custom attribute writer method with validation
    # @param [Object] schemas Value to be assigned
    def schemas=(schemas)
      if schemas.nil?
        fail ArgumentError, 'schemas cannot be nil'
      end

      if schemas.length < 1
        fail ArgumentError, 'invalid value for "schemas", number of items must be greater than or equal to 1.'
      end

      @schemas = schemas
    end

    # Custom attribute writer method with validation
    # @param [Object] emails Value to be assigned
    def emails=(emails)
      if emails.nil?
        fail ArgumentError, 'emails cannot be nil'
      end

      if emails.length < 1
        fail ArgumentError, 'invalid value for "emails", number of items must be greater than or equal to 1.'
      end

      @emails = emails
    end

    # Custom attribute writer method with validation
    # @param [Object] operations Value to be assigned
    def operations=(operations)
      if !operations.nil? && operations.length < 1
        fail ArgumentError, 'invalid value for "operations", number of items must be greater than or equal to 1.'
      end

      @operations = operations
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          schemas == o.schemas &&
          id == o.id &&
          external_id == o.external_id &&
          user_name == o.user_name &&
          display_name == o.display_name &&
          name == o.name &&
          emails == o.emails &&
          active == o.active &&
          meta == o.meta &&
          organization_id == o.organization_id &&
          operations == o.operations &&
          groups == o.groups
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [schemas, id, external_id, user_name, display_name, name, emails, active, meta, organization_id, operations, groups].hash
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
