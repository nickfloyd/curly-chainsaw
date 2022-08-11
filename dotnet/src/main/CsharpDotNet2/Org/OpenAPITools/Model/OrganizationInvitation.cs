using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Organization Invitation
  /// </summary>
  [DataContract]
  public class OrganizationInvitation {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Login
    /// </summary>
    [DataMember(Name="login", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "login")]
    public string Login { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets Role
    /// </summary>
    [DataMember(Name="role", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role")]
    public string Role { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets FailedAt
    /// </summary>
    [DataMember(Name="failed_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failed_at")]
    public string FailedAt { get; set; }

    /// <summary>
    /// Gets or Sets FailedReason
    /// </summary>
    [DataMember(Name="failed_reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failed_reason")]
    public string FailedReason { get; set; }

    /// <summary>
    /// Gets or Sets Inviter
    /// </summary>
    [DataMember(Name="inviter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inviter")]
    public SimpleUser1 Inviter { get; set; }

    /// <summary>
    /// Gets or Sets TeamCount
    /// </summary>
    [DataMember(Name="team_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "team_count")]
    public int? TeamCount { get; set; }

    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }

    /// <summary>
    /// Gets or Sets InvitationTeamsUrl
    /// </summary>
    [DataMember(Name="invitation_teams_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invitation_teams_url")]
    public string InvitationTeamsUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrganizationInvitation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Login: ").Append(Login).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Role: ").Append(Role).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  FailedAt: ").Append(FailedAt).Append("\n");
      sb.Append("  FailedReason: ").Append(FailedReason).Append("\n");
      sb.Append("  Inviter: ").Append(Inviter).Append("\n");
      sb.Append("  TeamCount: ").Append(TeamCount).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  InvitationTeamsUrl: ").Append(InvitationTeamsUrl).Append("\n");
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
