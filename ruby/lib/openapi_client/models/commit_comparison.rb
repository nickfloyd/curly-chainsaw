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
  # Commit Comparison
  class CommitComparison
    attr_accessor :url

    attr_accessor :html_url

    attr_accessor :permalink_url

    attr_accessor :diff_url

    attr_accessor :patch_url

    attr_accessor :base_commit

    attr_accessor :merge_base_commit

    attr_accessor :status

    attr_accessor :ahead_by

    attr_accessor :behind_by

    attr_accessor :total_commits

    attr_accessor :commits

    attr_accessor :files

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
        :'url' => :'url',
        :'html_url' => :'html_url',
        :'permalink_url' => :'permalink_url',
        :'diff_url' => :'diff_url',
        :'patch_url' => :'patch_url',
        :'base_commit' => :'base_commit',
        :'merge_base_commit' => :'merge_base_commit',
        :'status' => :'status',
        :'ahead_by' => :'ahead_by',
        :'behind_by' => :'behind_by',
        :'total_commits' => :'total_commits',
        :'commits' => :'commits',
        :'files' => :'files'
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
        :'html_url' => :'String',
        :'permalink_url' => :'String',
        :'diff_url' => :'String',
        :'patch_url' => :'String',
        :'base_commit' => :'Commit',
        :'merge_base_commit' => :'Commit',
        :'status' => :'String',
        :'ahead_by' => :'Integer',
        :'behind_by' => :'Integer',
        :'total_commits' => :'Integer',
        :'commits' => :'Array<Commit>',
        :'files' => :'Array<DiffEntry>'
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `OpenapiClient::CommitComparison` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `OpenapiClient::CommitComparison`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'url')
        self.url = attributes[:'url']
      end

      if attributes.key?(:'html_url')
        self.html_url = attributes[:'html_url']
      end

      if attributes.key?(:'permalink_url')
        self.permalink_url = attributes[:'permalink_url']
      end

      if attributes.key?(:'diff_url')
        self.diff_url = attributes[:'diff_url']
      end

      if attributes.key?(:'patch_url')
        self.patch_url = attributes[:'patch_url']
      end

      if attributes.key?(:'base_commit')
        self.base_commit = attributes[:'base_commit']
      end

      if attributes.key?(:'merge_base_commit')
        self.merge_base_commit = attributes[:'merge_base_commit']
      end

      if attributes.key?(:'status')
        self.status = attributes[:'status']
      end

      if attributes.key?(:'ahead_by')
        self.ahead_by = attributes[:'ahead_by']
      end

      if attributes.key?(:'behind_by')
        self.behind_by = attributes[:'behind_by']
      end

      if attributes.key?(:'total_commits')
        self.total_commits = attributes[:'total_commits']
      end

      if attributes.key?(:'commits')
        if (value = attributes[:'commits']).is_a?(Array)
          self.commits = value
        end
      end

      if attributes.key?(:'files')
        if (value = attributes[:'files']).is_a?(Array)
          self.files = value
        end
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      if @url.nil?
        invalid_properties.push('invalid value for "url", url cannot be nil.')
      end

      if @html_url.nil?
        invalid_properties.push('invalid value for "html_url", html_url cannot be nil.')
      end

      if @permalink_url.nil?
        invalid_properties.push('invalid value for "permalink_url", permalink_url cannot be nil.')
      end

      if @diff_url.nil?
        invalid_properties.push('invalid value for "diff_url", diff_url cannot be nil.')
      end

      if @patch_url.nil?
        invalid_properties.push('invalid value for "patch_url", patch_url cannot be nil.')
      end

      if @base_commit.nil?
        invalid_properties.push('invalid value for "base_commit", base_commit cannot be nil.')
      end

      if @merge_base_commit.nil?
        invalid_properties.push('invalid value for "merge_base_commit", merge_base_commit cannot be nil.')
      end

      if @status.nil?
        invalid_properties.push('invalid value for "status", status cannot be nil.')
      end

      if @ahead_by.nil?
        invalid_properties.push('invalid value for "ahead_by", ahead_by cannot be nil.')
      end

      if @behind_by.nil?
        invalid_properties.push('invalid value for "behind_by", behind_by cannot be nil.')
      end

      if @total_commits.nil?
        invalid_properties.push('invalid value for "total_commits", total_commits cannot be nil.')
      end

      if @commits.nil?
        invalid_properties.push('invalid value for "commits", commits cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @url.nil?
      return false if @html_url.nil?
      return false if @permalink_url.nil?
      return false if @diff_url.nil?
      return false if @patch_url.nil?
      return false if @base_commit.nil?
      return false if @merge_base_commit.nil?
      return false if @status.nil?
      status_validator = EnumAttributeValidator.new('String', ["diverged", "ahead", "behind", "identical"])
      return false unless status_validator.valid?(@status)
      return false if @ahead_by.nil?
      return false if @behind_by.nil?
      return false if @total_commits.nil?
      return false if @commits.nil?
      true
    end

    # Custom attribute writer method checking allowed values (enum).
    # @param [Object] status Object to be assigned
    def status=(status)
      validator = EnumAttributeValidator.new('String', ["diverged", "ahead", "behind", "identical"])
      unless validator.valid?(status)
        fail ArgumentError, "invalid value for \"status\", must be one of #{validator.allowable_values}."
      end
      @status = status
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          url == o.url &&
          html_url == o.html_url &&
          permalink_url == o.permalink_url &&
          diff_url == o.diff_url &&
          patch_url == o.patch_url &&
          base_commit == o.base_commit &&
          merge_base_commit == o.merge_base_commit &&
          status == o.status &&
          ahead_by == o.ahead_by &&
          behind_by == o.behind_by &&
          total_commits == o.total_commits &&
          commits == o.commits &&
          files == o.files
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [url, html_url, permalink_url, diff_url, patch_url, base_commit, merge_base_commit, status, ahead_by, behind_by, total_commits, commits, files].hash
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
