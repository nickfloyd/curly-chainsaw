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
  # User Search Result Item
  class UserSearchResultItem
    attr_accessor :login

    attr_accessor :id

    attr_accessor :node_id

    attr_accessor :avatar_url

    attr_accessor :gravatar_id

    attr_accessor :url

    attr_accessor :html_url

    attr_accessor :followers_url

    attr_accessor :subscriptions_url

    attr_accessor :organizations_url

    attr_accessor :repos_url

    attr_accessor :received_events_url

    attr_accessor :type

    attr_accessor :score

    attr_accessor :following_url

    attr_accessor :gists_url

    attr_accessor :starred_url

    attr_accessor :events_url

    attr_accessor :public_repos

    attr_accessor :public_gists

    attr_accessor :followers

    attr_accessor :following

    attr_accessor :created_at

    attr_accessor :updated_at

    attr_accessor :name

    attr_accessor :bio

    attr_accessor :email

    attr_accessor :location

    attr_accessor :site_admin

    attr_accessor :hireable

    attr_accessor :text_matches

    attr_accessor :blog

    attr_accessor :company

    attr_accessor :suspended_at

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'login' => :'login',
        :'id' => :'id',
        :'node_id' => :'node_id',
        :'avatar_url' => :'avatar_url',
        :'gravatar_id' => :'gravatar_id',
        :'url' => :'url',
        :'html_url' => :'html_url',
        :'followers_url' => :'followers_url',
        :'subscriptions_url' => :'subscriptions_url',
        :'organizations_url' => :'organizations_url',
        :'repos_url' => :'repos_url',
        :'received_events_url' => :'received_events_url',
        :'type' => :'type',
        :'score' => :'score',
        :'following_url' => :'following_url',
        :'gists_url' => :'gists_url',
        :'starred_url' => :'starred_url',
        :'events_url' => :'events_url',
        :'public_repos' => :'public_repos',
        :'public_gists' => :'public_gists',
        :'followers' => :'followers',
        :'following' => :'following',
        :'created_at' => :'created_at',
        :'updated_at' => :'updated_at',
        :'name' => :'name',
        :'bio' => :'bio',
        :'email' => :'email',
        :'location' => :'location',
        :'site_admin' => :'site_admin',
        :'hireable' => :'hireable',
        :'text_matches' => :'text_matches',
        :'blog' => :'blog',
        :'company' => :'company',
        :'suspended_at' => :'suspended_at'
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
        :'id' => :'Integer',
        :'node_id' => :'String',
        :'avatar_url' => :'String',
        :'gravatar_id' => :'String',
        :'url' => :'String',
        :'html_url' => :'String',
        :'followers_url' => :'String',
        :'subscriptions_url' => :'String',
        :'organizations_url' => :'String',
        :'repos_url' => :'String',
        :'received_events_url' => :'String',
        :'type' => :'String',
        :'score' => :'Float',
        :'following_url' => :'String',
        :'gists_url' => :'String',
        :'starred_url' => :'String',
        :'events_url' => :'String',
        :'public_repos' => :'Integer',
        :'public_gists' => :'Integer',
        :'followers' => :'Integer',
        :'following' => :'Integer',
        :'created_at' => :'Time',
        :'updated_at' => :'Time',
        :'name' => :'String',
        :'bio' => :'String',
        :'email' => :'String',
        :'location' => :'String',
        :'site_admin' => :'Boolean',
        :'hireable' => :'Boolean',
        :'text_matches' => :'Array<SearchResultTextMatchesInner>',
        :'blog' => :'String',
        :'company' => :'String',
        :'suspended_at' => :'Time'
      }
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
        :'gravatar_id',
        :'name',
        :'bio',
        :'email',
        :'location',
        :'hireable',
        :'blog',
        :'company',
        :'suspended_at'
      ])
    end

    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `OpenapiClient::UserSearchResultItem` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `OpenapiClient::UserSearchResultItem`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'login')
        self.login = attributes[:'login']
      end

      if attributes.key?(:'id')
        self.id = attributes[:'id']
      end

      if attributes.key?(:'node_id')
        self.node_id = attributes[:'node_id']
      end

      if attributes.key?(:'avatar_url')
        self.avatar_url = attributes[:'avatar_url']
      end

      if attributes.key?(:'gravatar_id')
        self.gravatar_id = attributes[:'gravatar_id']
      end

      if attributes.key?(:'url')
        self.url = attributes[:'url']
      end

      if attributes.key?(:'html_url')
        self.html_url = attributes[:'html_url']
      end

      if attributes.key?(:'followers_url')
        self.followers_url = attributes[:'followers_url']
      end

      if attributes.key?(:'subscriptions_url')
        self.subscriptions_url = attributes[:'subscriptions_url']
      end

      if attributes.key?(:'organizations_url')
        self.organizations_url = attributes[:'organizations_url']
      end

      if attributes.key?(:'repos_url')
        self.repos_url = attributes[:'repos_url']
      end

      if attributes.key?(:'received_events_url')
        self.received_events_url = attributes[:'received_events_url']
      end

      if attributes.key?(:'type')
        self.type = attributes[:'type']
      end

      if attributes.key?(:'score')
        self.score = attributes[:'score']
      end

      if attributes.key?(:'following_url')
        self.following_url = attributes[:'following_url']
      end

      if attributes.key?(:'gists_url')
        self.gists_url = attributes[:'gists_url']
      end

      if attributes.key?(:'starred_url')
        self.starred_url = attributes[:'starred_url']
      end

      if attributes.key?(:'events_url')
        self.events_url = attributes[:'events_url']
      end

      if attributes.key?(:'public_repos')
        self.public_repos = attributes[:'public_repos']
      end

      if attributes.key?(:'public_gists')
        self.public_gists = attributes[:'public_gists']
      end

      if attributes.key?(:'followers')
        self.followers = attributes[:'followers']
      end

      if attributes.key?(:'following')
        self.following = attributes[:'following']
      end

      if attributes.key?(:'created_at')
        self.created_at = attributes[:'created_at']
      end

      if attributes.key?(:'updated_at')
        self.updated_at = attributes[:'updated_at']
      end

      if attributes.key?(:'name')
        self.name = attributes[:'name']
      end

      if attributes.key?(:'bio')
        self.bio = attributes[:'bio']
      end

      if attributes.key?(:'email')
        self.email = attributes[:'email']
      end

      if attributes.key?(:'location')
        self.location = attributes[:'location']
      end

      if attributes.key?(:'site_admin')
        self.site_admin = attributes[:'site_admin']
      end

      if attributes.key?(:'hireable')
        self.hireable = attributes[:'hireable']
      end

      if attributes.key?(:'text_matches')
        if (value = attributes[:'text_matches']).is_a?(Array)
          self.text_matches = value
        end
      end

      if attributes.key?(:'blog')
        self.blog = attributes[:'blog']
      end

      if attributes.key?(:'company')
        self.company = attributes[:'company']
      end

      if attributes.key?(:'suspended_at')
        self.suspended_at = attributes[:'suspended_at']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      if @login.nil?
        invalid_properties.push('invalid value for "login", login cannot be nil.')
      end

      if @id.nil?
        invalid_properties.push('invalid value for "id", id cannot be nil.')
      end

      if @node_id.nil?
        invalid_properties.push('invalid value for "node_id", node_id cannot be nil.')
      end

      if @avatar_url.nil?
        invalid_properties.push('invalid value for "avatar_url", avatar_url cannot be nil.')
      end

      if @url.nil?
        invalid_properties.push('invalid value for "url", url cannot be nil.')
      end

      if @html_url.nil?
        invalid_properties.push('invalid value for "html_url", html_url cannot be nil.')
      end

      if @followers_url.nil?
        invalid_properties.push('invalid value for "followers_url", followers_url cannot be nil.')
      end

      if @subscriptions_url.nil?
        invalid_properties.push('invalid value for "subscriptions_url", subscriptions_url cannot be nil.')
      end

      if @organizations_url.nil?
        invalid_properties.push('invalid value for "organizations_url", organizations_url cannot be nil.')
      end

      if @repos_url.nil?
        invalid_properties.push('invalid value for "repos_url", repos_url cannot be nil.')
      end

      if @received_events_url.nil?
        invalid_properties.push('invalid value for "received_events_url", received_events_url cannot be nil.')
      end

      if @type.nil?
        invalid_properties.push('invalid value for "type", type cannot be nil.')
      end

      if @score.nil?
        invalid_properties.push('invalid value for "score", score cannot be nil.')
      end

      if @following_url.nil?
        invalid_properties.push('invalid value for "following_url", following_url cannot be nil.')
      end

      if @gists_url.nil?
        invalid_properties.push('invalid value for "gists_url", gists_url cannot be nil.')
      end

      if @starred_url.nil?
        invalid_properties.push('invalid value for "starred_url", starred_url cannot be nil.')
      end

      if @events_url.nil?
        invalid_properties.push('invalid value for "events_url", events_url cannot be nil.')
      end

      if @site_admin.nil?
        invalid_properties.push('invalid value for "site_admin", site_admin cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @login.nil?
      return false if @id.nil?
      return false if @node_id.nil?
      return false if @avatar_url.nil?
      return false if @url.nil?
      return false if @html_url.nil?
      return false if @followers_url.nil?
      return false if @subscriptions_url.nil?
      return false if @organizations_url.nil?
      return false if @repos_url.nil?
      return false if @received_events_url.nil?
      return false if @type.nil?
      return false if @score.nil?
      return false if @following_url.nil?
      return false if @gists_url.nil?
      return false if @starred_url.nil?
      return false if @events_url.nil?
      return false if @site_admin.nil?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          login == o.login &&
          id == o.id &&
          node_id == o.node_id &&
          avatar_url == o.avatar_url &&
          gravatar_id == o.gravatar_id &&
          url == o.url &&
          html_url == o.html_url &&
          followers_url == o.followers_url &&
          subscriptions_url == o.subscriptions_url &&
          organizations_url == o.organizations_url &&
          repos_url == o.repos_url &&
          received_events_url == o.received_events_url &&
          type == o.type &&
          score == o.score &&
          following_url == o.following_url &&
          gists_url == o.gists_url &&
          starred_url == o.starred_url &&
          events_url == o.events_url &&
          public_repos == o.public_repos &&
          public_gists == o.public_gists &&
          followers == o.followers &&
          following == o.following &&
          created_at == o.created_at &&
          updated_at == o.updated_at &&
          name == o.name &&
          bio == o.bio &&
          email == o.email &&
          location == o.location &&
          site_admin == o.site_admin &&
          hireable == o.hireable &&
          text_matches == o.text_matches &&
          blog == o.blog &&
          company == o.company &&
          suspended_at == o.suspended_at
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [login, id, node_id, avatar_url, gravatar_id, url, html_url, followers_url, subscriptions_url, organizations_url, repos_url, received_events_url, type, score, following_url, gists_url, starred_url, events_url, public_repos, public_gists, followers, following, created_at, updated_at, name, bio, email, location, site_admin, hireable, text_matches, blog, company, suspended_at].hash
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