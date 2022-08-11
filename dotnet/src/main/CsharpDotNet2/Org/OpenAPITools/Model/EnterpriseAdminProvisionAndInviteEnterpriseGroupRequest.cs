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
  public class EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest {
    /// <summary>
    /// The SCIM schema URIs.
    /// </summary>
    /// <value>The SCIM schema URIs.</value>
    [DataMember(Name="schemas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schemas")]
    public List<string> Schemas { get; set; }

    /// <summary>
    /// The name of the SCIM group. This must match the GitHub organization that the group maps to.
    /// </summary>
    /// <value>The name of the SCIM group. This must match the GitHub organization that the group maps to.</value>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets Members
    /// </summary>
    [DataMember(Name="members", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members")]
    public List<EnterpriseAdminProvisionAndInviteEnterpriseGroupRequestMembersInner> Members { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest {\n");
      sb.Append("  Schemas: ").Append(Schemas).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Members: ").Append(Members).Append("\n");
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
