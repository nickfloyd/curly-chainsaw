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
  class ReactionRollup
    attr_accessor :url

    attr_accessor :total_count

    attr_accessor :_1

    attr_accessor :_1

    attr_accessor :laugh

    attr_accessor :confused

    attr_accessor :heart

    attr_accessor :hooray

    attr_accessor :eyes

    attr_accessor :rocket

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'url' => :'url',
        :'total_count' => :'total_count',
        :'_1' => :'+1',
        :'_1' => :'-1',
        :'laugh' => :'laugh',
        :'confused' => :'confused',
        :'heart' => :'heart',
        :'hooray' => :'hooray',
        :'eyes' => :'eyes',
        :'rocket' => :'rocket'
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
        :'total_count' => :'Integer',
        :'_1' => :'Integer',
        :'_1' => :'Integer',
        :'laugh' => :'Integer',
        :'confused' => :'Integer',
        :'heart' => :'Integer',
        :'hooray' => :'Integer',
        :'eyes' => :'Integer',
        :'rocket' => :'Integer'
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `OpenapiClient::ReactionRollup` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `OpenapiClient::ReactionRollup`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'url')
        self.url = attributes[:'url']
      end

      if attributes.key?(:'total_count')
        self.total_count = attributes[:'total_count']
      end

      if attributes.key?(:'_1')
        self._1 = attributes[:'_1']
      end

      if attributes.key?(:'_1')
        self._1 = attributes[:'_1']
      end

      if attributes.key?(:'laugh')
        self.laugh = attributes[:'laugh']
      end

      if attributes.key?(:'confused')
        self.confused = attributes[:'confused']
      end

      if attributes.key?(:'heart')
        self.heart = attributes[:'heart']
      end

      if attributes.key?(:'hooray')
        self.hooray = attributes[:'hooray']
      end

      if attributes.key?(:'eyes')
        self.eyes = attributes[:'eyes']
      end

      if attributes.key?(:'rocket')
        self.rocket = attributes[:'rocket']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      if @url.nil?
        invalid_properties.push('invalid value for "url", url cannot be nil.')
      end

      if @total_count.nil?
        invalid_properties.push('invalid value for "total_count", total_count cannot be nil.')
      end

      if @_1.nil?
        invalid_properties.push('invalid value for "_1", _1 cannot be nil.')
      end

      if @_1.nil?
        invalid_properties.push('invalid value for "_1", _1 cannot be nil.')
      end

      if @laugh.nil?
        invalid_properties.push('invalid value for "laugh", laugh cannot be nil.')
      end

      if @confused.nil?
        invalid_properties.push('invalid value for "confused", confused cannot be nil.')
      end

      if @heart.nil?
        invalid_properties.push('invalid value for "heart", heart cannot be nil.')
      end

      if @hooray.nil?
        invalid_properties.push('invalid value for "hooray", hooray cannot be nil.')
      end

      if @eyes.nil?
        invalid_properties.push('invalid value for "eyes", eyes cannot be nil.')
      end

      if @rocket.nil?
        invalid_properties.push('invalid value for "rocket", rocket cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @url.nil?
      return false if @total_count.nil?
      return false if @_1.nil?
      return false if @_1.nil?
      return false if @laugh.nil?
      return false if @confused.nil?
      return false if @heart.nil?
      return false if @hooray.nil?
      return false if @eyes.nil?
      return false if @rocket.nil?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          url == o.url &&
          total_count == o.total_count &&
          _1 == o._1 &&
          _1 == o._1 &&
          laugh == o.laugh &&
          confused == o.confused &&
          heart == o.heart &&
          hooray == o.hooray &&
          eyes == o.eyes &&
          rocket == o.rocket
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [url, total_count, _1, _1, laugh, confused, heart, hooray, eyes, rocket].hash
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
