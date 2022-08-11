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
  public class ExternalGroupMembersInner {
    /// <summary>
    /// The internal user ID of the identity
    /// </summary>
    /// <value>The internal user ID of the identity</value>
    [DataMember(Name="member_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "member_id")]
    public int? MemberId { get; set; }

    /// <summary>
    /// The handle/login for the user
    /// </summary>
    /// <value>The handle/login for the user</value>
    [DataMember(Name="member_login", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "member_login")]
    public string MemberLogin { get; set; }

    /// <summary>
    /// The user display name/profile name
    /// </summary>
    /// <value>The user display name/profile name</value>
    [DataMember(Name="member_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "member_name")]
    public string MemberName { get; set; }

    /// <summary>
    /// An email attached to a user
    /// </summary>
    /// <value>An email attached to a user</value>
    [DataMember(Name="member_email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "member_email")]
    public string MemberEmail { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExternalGroupMembersInner {\n");
      sb.Append("  MemberId: ").Append(MemberId).Append("\n");
      sb.Append("  MemberLogin: ").Append(MemberLogin).Append("\n");
      sb.Append("  MemberName: ").Append(MemberName).Append("\n");
      sb.Append("  MemberEmail: ").Append(MemberEmail).Append("\n");
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
