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
  public class OrgsCreateInvitationRequest {
    /// <summary>
    /// **Required unless you provide `email`**. GitHub user ID for the person you are inviting.
    /// </summary>
    /// <value>**Required unless you provide `email`**. GitHub user ID for the person you are inviting.</value>
    [DataMember(Name="invitee_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invitee_id")]
    public int? InviteeId { get; set; }

    /// <summary>
    /// **Required unless you provide `invitee_id`**. Email address of the person you are inviting, which can be an existing GitHub user.
    /// </summary>
    /// <value>**Required unless you provide `invitee_id`**. Email address of the person you are inviting, which can be an existing GitHub user.</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// The role for the new member.  \\* `admin` - Organization owners with full administrative rights to the organization and complete access to all repositories and teams.   \\* `direct_member` - Non-owner organization members with ability to see other members and join teams by invitation.   \\* `billing_manager` - Non-owner organization members with ability to manage the billing settings of your organization.
    /// </summary>
    /// <value>The role for the new member.  \\* `admin` - Organization owners with full administrative rights to the organization and complete access to all repositories and teams.   \\* `direct_member` - Non-owner organization members with ability to see other members and join teams by invitation.   \\* `billing_manager` - Non-owner organization members with ability to manage the billing settings of your organization.</value>
    [DataMember(Name="role", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role")]
    public string Role { get; set; }

    /// <summary>
    /// Specify IDs for the teams you want to invite new members to.
    /// </summary>
    /// <value>Specify IDs for the teams you want to invite new members to.</value>
    [DataMember(Name="team_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "team_ids")]
    public List<int?> TeamIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrgsCreateInvitationRequest {\n");
      sb.Append("  InviteeId: ").Append(InviteeId).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Role: ").Append(Role).Append("\n");
      sb.Append("  TeamIds: ").Append(TeamIds).Append("\n");
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
