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
  # A release.
  class Release
    attr_accessor :url

    attr_accessor :html_url

    attr_accessor :assets_url

    attr_accessor :upload_url

    attr_accessor :tarball_url

    attr_accessor :zipball_url

    attr_accessor :id

    attr_accessor :node_id

    # The name of the tag.
    attr_accessor :tag_name

    # Specifies the commitish value that determines where the Git tag is created from.
    attr_accessor :target_commitish

    attr_accessor :name

    attr_accessor :body

    # true to create a draft (unpublished) release, false to create a published one.
    attr_accessor :draft

    # Whether to identify the release as a prerelease or a full release.
    attr_accessor :prerelease

    attr_accessor :created_at

    attr_accessor :published_at

    attr_accessor :author

    attr_accessor :assets

    attr_accessor :body_html

    attr_accessor :body_text

    attr_accessor :mentions_count

    # The URL of the release discussion.
    attr_accessor :discussion_url

    attr_accessor :reactions

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'url' => :'url',
        :'html_url' => :'html_url',
        :'assets_url' => :'assets_url',
        :'upload_url' => :'upload_url',
        :'tarball_url' => :'tarball_url',
        :'zipball_url' => :'zipball_url',
        :'id' => :'id',
        :'node_id' => :'node_id',
        :'tag_name' => :'tag_name',
        :'target_commitish' => :'target_commitish',
        :'name' => :'name',
        :'body' => :'body',
        :'draft' => :'draft',
        :'prerelease' => :'prerelease',
        :'created_at' => :'created_at',
        :'published_at' => :'published_at',
        :'author' => :'author',
        :'assets' => :'assets',
        :'body_html' => :'body_html',
        :'body_text' => :'body_text',
        :'mentions_count' => :'mentions_count',
        :'discussion_url' => :'discussion_url',
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
        :'url' => :'String',
        :'html_url' => :'String',
        :'assets_url' => :'String',
        :'upload_url' => :'String',
        :'tarball_url' => :'String',
        :'zipball_url' => :'String',
        :'id' => :'Integer',
        :'node_id' => :'String',
        :'tag_name' => :'String',
        :'target_commitish' => :'String',
        :'name' => :'String',
        :'body' => :'String',
        :'draft' => :'Boolean',
        :'prerelease' => :'Boolean',
        :'created_at' => :'Time',
        :'published_at' => :'Time',
        :'author' => :'SimpleUser1',
        :'assets' => :'Array<ReleaseAsset>',
        :'body_html' => :'String',
        :'body_text' => :'String',
        :'mentions_count' => :'Integer',
        :'discussion_url' => :'String',
        :'reactions' => :'ReactionRollup'
      }
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
        :'tarball_url',
        :'zipball_url',
        :'name',
        :'body',
        :'published_at',
      ])
    end

    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `OpenapiClient::Release` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `OpenapiClient::Release`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'url')
        self.url = attributes[:'url']
      end

      if attributes.key?(:'html_url')
        self.html_url = attributes[:'html_url']
      end

      if attributes.key?(:'assets_url')
        self.assets_url = attributes[:'assets_url']
      end

      if attributes.key?(:'upload_url')
        self.upload_url = attributes[:'upload_url']
      end

      if attributes.key?(:'tarball_url')
        self.tarball_url = attributes[:'tarball_url']
      end

      if attributes.key?(:'zipball_url')
        self.zipball_url = attributes[:'zipball_url']
      end

      if attributes.key?(:'id')
        self.id = attributes[:'id']
      end

      if attributes.key?(:'node_id')
        self.node_id = attributes[:'node_id']
      end

      if attributes.key?(:'tag_name')
        self.tag_name = attributes[:'tag_name']
      end

      if attributes.key?(:'target_commitish')
        self.target_commitish = attributes[:'target_commitish']
      end

      if attributes.key?(:'name')
        self.name = attributes[:'name']
      end

      if attributes.key?(:'body')
        self.body = attributes[:'body']
      end

      if attributes.key?(:'draft')
        self.draft = attributes[:'draft']
      end

      if attributes.key?(:'prerelease')
        self.prerelease = attributes[:'prerelease']
      end

      if attributes.key?(:'created_at')
        self.created_at = attributes[:'created_at']
      end

      if attributes.key?(:'published_at')
        self.published_at = attributes[:'published_at']
      end

      if attributes.key?(:'author')
        self.author = attributes[:'author']
      end

      if attributes.key?(:'assets')
        if (value = attributes[:'assets']).is_a?(Array)
          self.assets = value
        end
      end

      if attributes.key?(:'body_html')
        self.body_html = attributes[:'body_html']
      end

      if attributes.key?(:'body_text')
        self.body_text = attributes[:'body_text']
      end

      if attributes.key?(:'mentions_count')
        self.mentions_count = attributes[:'mentions_count']
      end

      if attributes.key?(:'discussion_url')
        self.discussion_url = attributes[:'discussion_url']
      end

      if attributes.key?(:'reactions')
        self.reactions = attributes[:'reactions']
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

      if @assets_url.nil?
        invalid_properties.push('invalid value for "assets_url", assets_url cannot be nil.')
      end

      if @upload_url.nil?
        invalid_properties.push('invalid value for "upload_url", upload_url cannot be nil.')
      end

      if @id.nil?
        invalid_properties.push('invalid value for "id", id cannot be nil.')
      end

      if @node_id.nil?
        invalid_properties.push('invalid value for "node_id", node_id cannot be nil.')
      end

      if @tag_name.nil?
        invalid_properties.push('invalid value for "tag_name", tag_name cannot be nil.')
      end

      if @target_commitish.nil?
        invalid_properties.push('invalid value for "target_commitish", target_commitish cannot be nil.')
      end

      if @draft.nil?
        invalid_properties.push('invalid value for "draft", draft cannot be nil.')
      end

      if @prerelease.nil?
        invalid_properties.push('invalid value for "prerelease", prerelease cannot be nil.')
      end

      if @created_at.nil?
        invalid_properties.push('invalid value for "created_at", created_at cannot be nil.')
      end

      if @author.nil?
        invalid_properties.push('invalid value for "author", author cannot be nil.')
      end

      if @assets.nil?
        invalid_properties.push('invalid value for "assets", assets cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @url.nil?
      return false if @html_url.nil?
      return false if @assets_url.nil?
      return false if @upload_url.nil?
      return false if @id.nil?
      return false if @node_id.nil?
      return false if @tag_name.nil?
      return false if @target_commitish.nil?
      return false if @draft.nil?
      return false if @prerelease.nil?
      return false if @created_at.nil?
      return false if @author.nil?
      return false if @assets.nil?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          url == o.url &&
          html_url == o.html_url &&
          assets_url == o.assets_url &&
          upload_url == o.upload_url &&
          tarball_url == o.tarball_url &&
          zipball_url == o.zipball_url &&
          id == o.id &&
          node_id == o.node_id &&
          tag_name == o.tag_name &&
          target_commitish == o.target_commitish &&
          name == o.name &&
          body == o.body &&
          draft == o.draft &&
          prerelease == o.prerelease &&
          created_at == o.created_at &&
          published_at == o.published_at &&
          author == o.author &&
          assets == o.assets &&
          body_html == o.body_html &&
          body_text == o.body_text &&
          mentions_count == o.mentions_count &&
          discussion_url == o.discussion_url &&
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
      [url, html_url, assets_url, upload_url, tarball_url, zipball_url, id, node_id, tag_name, target_commitish, name, body, draft, prerelease, created_at, published_at, author, assets, body_html, body_text, mentions_count, discussion_url, reactions].hash
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
