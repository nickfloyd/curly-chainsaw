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
  public class OrgsSetMembershipForUserRequest {
    /// <summary>
    /// The role to give the user in the organization. Can be one of:   \\* `admin` - The user will become an owner of the organization.   \\* `member` - The user will become a non-owner member of the organization.
    /// </summary>
    /// <value>The role to give the user in the organization. Can be one of:   \\* `admin` - The user will become an owner of the organization.   \\* `member` - The user will become a non-owner member of the organization.</value>
    [DataMember(Name="role", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role")]
    public string Role { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrgsSetMembershipForUserRequest {\n");
      sb.Append("  Role: ").Append(Role).Append("\n");
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
