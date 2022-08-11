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
  # Information of a job execution in a workflow run
  class Job
    # The id of the job.
    attr_accessor :id

    # The id of the associated workflow run.
    attr_accessor :run_id

    attr_accessor :run_url

    # Attempt number of the associated workflow run, 1 for first attempt and higher if the workflow was re-run.
    attr_accessor :run_attempt

    attr_accessor :node_id

    # The SHA of the commit that is being run.
    attr_accessor :head_sha

    attr_accessor :url

    attr_accessor :html_url

    # The phase of the lifecycle that the job is currently in.
    attr_accessor :status

    # The outcome of the job.
    attr_accessor :conclusion

    # The time that the job started, in ISO 8601 format.
    attr_accessor :started_at

    # The time that the job finished, in ISO 8601 format.
    attr_accessor :completed_at

    # The name of the job.
    attr_accessor :name

    # Steps in this job.
    attr_accessor :steps

    attr_accessor :check_run_url

    # Labels for the workflow job. Specified by the \"runs_on\" attribute in the action's workflow file.
    attr_accessor :labels

    # The ID of the runner to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)
    attr_accessor :runner_id

    # The name of the runner to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)
    attr_accessor :runner_name

    # The ID of the runner group to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)
    attr_accessor :runner_group_id

    # The name of the runner group to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)
    attr_accessor :runner_group_name

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
        :'run_id' => :'run_id',
        :'run_url' => :'run_url',
        :'run_attempt' => :'run_attempt',
        :'node_id' => :'node_id',
        :'head_sha' => :'head_sha',
        :'url' => :'url',
        :'html_url' => :'html_url',
        :'status' => :'status',
        :'conclusion' => :'conclusion',
        :'started_at' => :'started_at',
        :'completed_at' => :'completed_at',
        :'name' => :'name',
        :'steps' => :'steps',
        :'check_run_url' => :'check_run_url',
        :'labels' => :'labels',
        :'runner_id' => :'runner_id',
        :'runner_name' => :'runner_name',
        :'runner_group_id' => :'runner_group_id',
        :'runner_group_name' => :'runner_group_name'
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
        :'run_id' => :'Integer',
        :'run_url' => :'String',
        :'run_attempt' => :'Integer',
        :'node_id' => :'String',
        :'head_sha' => :'String',
        :'url' => :'String',
        :'html_url' => :'String',
        :'status' => :'String',
        :'conclusion' => :'String',
        :'started_at' => :'Time',
        :'completed_at' => :'Time',
        :'name' => :'String',
        :'steps' => :'Array<JobStepsInner>',
        :'check_run_url' => :'String',
        :'labels' => :'Array<String>',
        :'runner_id' => :'Integer',
        :'runner_name' => :'String',
        :'runner_group_id' => :'Integer',
        :'runner_group_name' => :'String'
      }
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
        :'html_url',
        :'conclusion',
        :'completed_at',
        :'runner_id',
        :'runner_name',
        :'runner_group_id',
        :'runner_group_name'
      ])
    end

    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `OpenapiClient::Job` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `OpenapiClient::Job`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'id')
        self.id = attributes[:'id']
      end

      if attributes.key?(:'run_id')
        self.run_id = attributes[:'run_id']
      end

      if attributes.key?(:'run_url')
        self.run_url = attributes[:'run_url']
      end

      if attributes.key?(:'run_attempt')
        self.run_attempt = attributes[:'run_attempt']
      end

      if attributes.key?(:'node_id')
        self.node_id = attributes[:'node_id']
      end

      if attributes.key?(:'head_sha')
        self.head_sha = attributes[:'head_sha']
      end

      if attributes.key?(:'url')
        self.url = attributes[:'url']
      end

      if attributes.key?(:'html_url')
        self.html_url = attributes[:'html_url']
      end

      if attributes.key?(:'status')
        self.status = attributes[:'status']
      end

      if attributes.key?(:'conclusion')
        self.conclusion = attributes[:'conclusion']
      end

      if attributes.key?(:'started_at')
        self.started_at = attributes[:'started_at']
      end

      if attributes.key?(:'completed_at')
        self.completed_at = attributes[:'completed_at']
      end

      if attributes.key?(:'name')
        self.name = attributes[:'name']
      end

      if attributes.key?(:'steps')
        if (value = attributes[:'steps']).is_a?(Array)
          self.steps = value
        end
      end

      if attributes.key?(:'check_run_url')
        self.check_run_url = attributes[:'check_run_url']
      end

      if attributes.key?(:'labels')
        if (value = attributes[:'labels']).is_a?(Array)
          self.labels = value
        end
      end

      if attributes.key?(:'runner_id')
        self.runner_id = attributes[:'runner_id']
      end

      if attributes.key?(:'runner_name')
        self.runner_name = attributes[:'runner_name']
      end

      if attributes.key?(:'runner_group_id')
        self.runner_group_id = attributes[:'runner_group_id']
      end

      if attributes.key?(:'runner_group_name')
        self.runner_group_name = attributes[:'runner_group_name']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      if @id.nil?
        invalid_properties.push('invalid value for "id", id cannot be nil.')
      end

      if @run_id.nil?
        invalid_properties.push('invalid value for "run_id", run_id cannot be nil.')
      end

      if @run_url.nil?
        invalid_properties.push('invalid value for "run_url", run_url cannot be nil.')
      end

      if @node_id.nil?
        invalid_properties.push('invalid value for "node_id", node_id cannot be nil.')
      end

      if @head_sha.nil?
        invalid_properties.push('invalid value for "head_sha", head_sha cannot be nil.')
      end

      if @url.nil?
        invalid_properties.push('invalid value for "url", url cannot be nil.')
      end

      if @status.nil?
        invalid_properties.push('invalid value for "status", status cannot be nil.')
      end

      if @started_at.nil?
        invalid_properties.push('invalid value for "started_at", started_at cannot be nil.')
      end

      if @name.nil?
        invalid_properties.push('invalid value for "name", name cannot be nil.')
      end

      if @check_run_url.nil?
        invalid_properties.push('invalid value for "check_run_url", check_run_url cannot be nil.')
      end

      if @labels.nil?
        invalid_properties.push('invalid value for "labels", labels cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @id.nil?
      return false if @run_id.nil?
      return false if @run_url.nil?
      return false if @node_id.nil?
      return false if @head_sha.nil?
      return false if @url.nil?
      return false if @status.nil?
      status_validator = EnumAttributeValidator.new('String', ["queued", "in_progress", "completed"])
      return false unless status_validator.valid?(@status)
      return false if @started_at.nil?
      return false if @name.nil?
      return false if @check_run_url.nil?
      return false if @labels.nil?
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

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          id == o.id &&
          run_id == o.run_id &&
          run_url == o.run_url &&
          run_attempt == o.run_attempt &&
          node_id == o.node_id &&
          head_sha == o.head_sha &&
          url == o.url &&
          html_url == o.html_url &&
          status == o.status &&
          conclusion == o.conclusion &&
          started_at == o.started_at &&
          completed_at == o.completed_at &&
          name == o.name &&
          steps == o.steps &&
          check_run_url == o.check_run_url &&
          labels == o.labels &&
          runner_id == o.runner_id &&
          runner_name == o.runner_name &&
          runner_group_id == o.runner_group_id &&
          runner_group_name == o.runner_group_name
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [id, run_id, run_url, run_attempt, node_id, head_sha, url, html_url, status, conclusion, started_at, completed_at, name, steps, check_run_url, labels, runner_id, runner_name, runner_group_id, runner_group_name].hash
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
