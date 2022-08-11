using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Org Membership
  /// </summary>
  [DataContract]
  public class OrgMembership {
    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// The state of the member in the organization. The `pending` state indicates the user has not yet accepted an invitation.
    /// </summary>
    /// <value>The state of the member in the organization. The `pending` state indicates the user has not yet accepted an invitation.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// The user's membership type in the organization.
    /// </summary>
    /// <value>The user's membership type in the organization.</value>
    [DataMember(Name="role", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role")]
    public string Role { get; set; }

    /// <summary>
    /// Gets or Sets OrganizationUrl
    /// </summary>
    [DataMember(Name="organization_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organization_url")]
    public string OrganizationUrl { get; set; }

    /// <summary>
    /// Gets or Sets Organization
    /// </summary>
    [DataMember(Name="organization", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organization")]
    public OrganizationSimple Organization { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public SimpleUser User { get; set; }

    /// <summary>
    /// Gets or Sets Permissions
    /// </summary>
    [DataMember(Name="permissions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permissions")]
    public OrgMembershipPermissions Permissions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrgMembership {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Role: ").Append(Role).Append("\n");
      sb.Append("  OrganizationUrl: ").Append(OrganizationUrl).Append("\n");
      sb.Append("  Organization: ").Append(Organization).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  Permissions: ").Append(Permissions).Append("\n");
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
