using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Repository invitations let you manage who you collaborate with.
  /// </summary>
  [DataContract]
  public class RepositoryInvitation {
    /// <summary>
    /// Unique identifier of the repository invitation.
    /// </summary>
    /// <value>Unique identifier of the repository invitation.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Repository
    /// </summary>
    [DataMember(Name="repository", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository")]
    public MinimalRepository Repository { get; set; }

    /// <summary>
    /// Gets or Sets Invitee
    /// </summary>
    [DataMember(Name="invitee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invitee")]
    public SimpleUser Invitee { get; set; }

    /// <summary>
    /// Gets or Sets Inviter
    /// </summary>
    [DataMember(Name="inviter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inviter")]
    public SimpleUser Inviter { get; set; }

    /// <summary>
    /// The permission associated with the invitation.
    /// </summary>
    /// <value>The permission associated with the invitation.</value>
    [DataMember(Name="permissions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permissions")]
    public string Permissions { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Whether or not the invitation has expired
    /// </summary>
    /// <value>Whether or not the invitation has expired</value>
    [DataMember(Name="expired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expired")]
    public bool? Expired { get; set; }

    /// <summary>
    /// URL for the repository invitation
    /// </summary>
    /// <value>URL for the repository invitation</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RepositoryInvitation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Repository: ").Append(Repository).Append("\n");
      sb.Append("  Invitee: ").Append(Invitee).Append("\n");
      sb.Append("  Inviter: ").Append(Inviter).Append("\n");
      sb.Append("  Permissions: ").Append(Permissions).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  Expired: ").Append(Expired).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
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
