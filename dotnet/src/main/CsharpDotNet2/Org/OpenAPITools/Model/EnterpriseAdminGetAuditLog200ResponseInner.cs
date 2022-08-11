using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class EnterpriseAdminGetAuditLog200ResponseInner {
    /// <summary>
    /// The time the audit log event occurred, given as a [Unix timestamp](http://en.wikipedia.org/wiki/Unix_time).
    /// </summary>
    /// <value>The time the audit log event occurred, given as a [Unix timestamp](http://en.wikipedia.org/wiki/Unix_time).</value>
    [DataMember(Name="@timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "@timestamp")]
    public int? Timestamp { get; set; }

    /// <summary>
    /// The name of the action that was performed, for example `user.login` or `repo.create`.
    /// </summary>
    /// <value>The name of the action that was performed, for example `user.login` or `repo.create`.</value>
    [DataMember(Name="action", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "action")]
    public string Action { get; set; }

    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Gets or Sets ActiveWas
    /// </summary>
    [DataMember(Name="active_was", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active_was")]
    public bool? ActiveWas { get; set; }

    /// <summary>
    /// The actor who performed the action.
    /// </summary>
    /// <value>The actor who performed the action.</value>
    [DataMember(Name="actor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actor")]
    public string Actor { get; set; }

    /// <summary>
    /// The id of the actor who performed the action.
    /// </summary>
    /// <value>The id of the actor who performed the action.</value>
    [DataMember(Name="actor_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actor_id")]
    public int? ActorId { get; set; }

    /// <summary>
    /// Gets or Sets ActorLocation
    /// </summary>
    [DataMember(Name="actor_location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actor_location")]
    public EnterpriseAdminGetAuditLog200ResponseInnerActorLocation ActorLocation { get; set; }

    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public Dictionary<string, Object> Data { get; set; }

    /// <summary>
    /// Gets or Sets OrgId
    /// </summary>
    [DataMember(Name="org_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "org_id")]
    public int? OrgId { get; set; }

    /// <summary>
    /// The username of the account being blocked.
    /// </summary>
    /// <value>The username of the account being blocked.</value>
    [DataMember(Name="blocked_user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blocked_user")]
    public string BlockedUser { get; set; }

    /// <summary>
    /// Gets or Sets Business
    /// </summary>
    [DataMember(Name="business", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "business")]
    public string Business { get; set; }

    /// <summary>
    /// Gets or Sets Config
    /// </summary>
    [DataMember(Name="config", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "config")]
    public List<Object> Config { get; set; }

    /// <summary>
    /// Gets or Sets ConfigWas
    /// </summary>
    [DataMember(Name="config_was", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "config_was")]
    public List<Object> ConfigWas { get; set; }

    /// <summary>
    /// Gets or Sets ContentType
    /// </summary>
    [DataMember(Name="content_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content_type")]
    public string ContentType { get; set; }

    /// <summary>
    /// The time the audit log event was recorded, given as a [Unix timestamp](http://en.wikipedia.org/wiki/Unix_time).
    /// </summary>
    /// <value>The time the audit log event was recorded, given as a [Unix timestamp](http://en.wikipedia.org/wiki/Unix_time).</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public int? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets DeployKeyFingerprint
    /// </summary>
    [DataMember(Name="deploy_key_fingerprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deploy_key_fingerprint")]
    public string DeployKeyFingerprint { get; set; }

    /// <summary>
    /// A unique identifier for an audit event.
    /// </summary>
    /// <value>A unique identifier for an audit event.</value>
    [DataMember(Name="_document_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_document_id")]
    public string DocumentId { get; set; }

    /// <summary>
    /// Gets or Sets Emoji
    /// </summary>
    [DataMember(Name="emoji", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emoji")]
    public string Emoji { get; set; }

    /// <summary>
    /// Gets or Sets Events
    /// </summary>
    [DataMember(Name="events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events")]
    public List<Object> Events { get; set; }

    /// <summary>
    /// Gets or Sets EventsWere
    /// </summary>
    [DataMember(Name="events_were", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events_were")]
    public List<Object> EventsWere { get; set; }

    /// <summary>
    /// Gets or Sets Explanation
    /// </summary>
    [DataMember(Name="explanation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "explanation")]
    public string Explanation { get; set; }

    /// <summary>
    /// Gets or Sets Fingerprint
    /// </summary>
    [DataMember(Name="fingerprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fingerprint")]
    public string Fingerprint { get; set; }

    /// <summary>
    /// Gets or Sets HookId
    /// </summary>
    [DataMember(Name="hook_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hook_id")]
    public int? HookId { get; set; }

    /// <summary>
    /// Gets or Sets LimitedAvailability
    /// </summary>
    [DataMember(Name="limited_availability", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limited_availability")]
    public bool? LimitedAvailability { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets OldUser
    /// </summary>
    [DataMember(Name="old_user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "old_user")]
    public string OldUser { get; set; }

    /// <summary>
    /// Gets or Sets OpensshPublicKey
    /// </summary>
    [DataMember(Name="openssh_public_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openssh_public_key")]
    public string OpensshPublicKey { get; set; }

    /// <summary>
    /// Gets or Sets Org
    /// </summary>
    [DataMember(Name="org", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "org")]
    public string Org { get; set; }

    /// <summary>
    /// Gets or Sets PreviousVisibility
    /// </summary>
    [DataMember(Name="previous_visibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previous_visibility")]
    public string PreviousVisibility { get; set; }

    /// <summary>
    /// Gets or Sets ReadOnly
    /// </summary>
    [DataMember(Name="read_only", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "read_only")]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// The name of the repository.
    /// </summary>
    /// <value>The name of the repository.</value>
    [DataMember(Name="repo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repo")]
    public string Repo { get; set; }

    /// <summary>
    /// The name of the repository.
    /// </summary>
    /// <value>The name of the repository.</value>
    [DataMember(Name="repository", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository")]
    public string Repository { get; set; }

    /// <summary>
    /// Gets or Sets RepositoryPublic
    /// </summary>
    [DataMember(Name="repository_public", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository_public")]
    public bool? RepositoryPublic { get; set; }

    /// <summary>
    /// Gets or Sets TargetLogin
    /// </summary>
    [DataMember(Name="target_login", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target_login")]
    public string TargetLogin { get; set; }

    /// <summary>
    /// Gets or Sets Team
    /// </summary>
    [DataMember(Name="team", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "team")]
    public string Team { get; set; }

    /// <summary>
    /// The type of protocol (for example, HTTP or SSH) used to transfer Git data.
    /// </summary>
    /// <value>The type of protocol (for example, HTTP or SSH) used to transfer Git data.</value>
    [DataMember(Name="transport_protocol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transport_protocol")]
    public int? TransportProtocol { get; set; }

    /// <summary>
    /// A human readable name for the protocol (for example, HTTP or SSH) used to transfer Git data.
    /// </summary>
    /// <value>A human readable name for the protocol (for example, HTTP or SSH) used to transfer Git data.</value>
    [DataMember(Name="transport_protocol_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transport_protocol_name")]
    public string TransportProtocolName { get; set; }

    /// <summary>
    /// The user that was affected by the action performed (if available).
    /// </summary>
    /// <value>The user that was affected by the action performed (if available).</value>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public string User { get; set; }

    /// <summary>
    /// The repository visibility, for example `public` or `private`.
    /// </summary>
    /// <value>The repository visibility, for example `public` or `private`.</value>
    [DataMember(Name="visibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibility")]
    public string Visibility { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EnterpriseAdminGetAuditLog200ResponseInner {\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  Action: ").Append(Action).Append("\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  ActiveWas: ").Append(ActiveWas).Append("\n");
      sb.Append("  Actor: ").Append(Actor).Append("\n");
      sb.Append("  ActorId: ").Append(ActorId).Append("\n");
      sb.Append("  ActorLocation: ").Append(ActorLocation).Append("\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  OrgId: ").Append(OrgId).Append("\n");
      sb.Append("  BlockedUser: ").Append(BlockedUser).Append("\n");
      sb.Append("  Business: ").Append(Business).Append("\n");
      sb.Append("  Config: ").Append(Config).Append("\n");
      sb.Append("  ConfigWas: ").Append(ConfigWas).Append("\n");
      sb.Append("  ContentType: ").Append(ContentType).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  DeployKeyFingerprint: ").Append(DeployKeyFingerprint).Append("\n");
      sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
      sb.Append("  Emoji: ").Append(Emoji).Append("\n");
      sb.Append("  Events: ").Append(Events).Append("\n");
      sb.Append("  EventsWere: ").Append(EventsWere).Append("\n");
      sb.Append("  Explanation: ").Append(Explanation).Append("\n");
      sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
      sb.Append("  HookId: ").Append(HookId).Append("\n");
      sb.Append("  LimitedAvailability: ").Append(LimitedAvailability).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  OldUser: ").Append(OldUser).Append("\n");
      sb.Append("  OpensshPublicKey: ").Append(OpensshPublicKey).Append("\n");
      sb.Append("  Org: ").Append(Org).Append("\n");
      sb.Append("  PreviousVisibility: ").Append(PreviousVisibility).Append("\n");
      sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
      sb.Append("  Repo: ").Append(Repo).Append("\n");
      sb.Append("  Repository: ").Append(Repository).Append("\n");
      sb.Append("  RepositoryPublic: ").Append(RepositoryPublic).Append("\n");
      sb.Append("  TargetLogin: ").Append(TargetLogin).Append("\n");
      sb.Append("  Team: ").Append(Team).Append("\n");
      sb.Append("  TransportProtocol: ").Append(TransportProtocol).Append("\n");
      sb.Append("  TransportProtocolName: ").Append(TransportProtocolName).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  Visibility: ").Append(Visibility).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
    }

}
}
