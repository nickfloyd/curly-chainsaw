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
  public class EnterpriseAdminProvisionAndInviteEnterpriseUserRequestName {
    /// <summary>
    /// The first name of the user.
    /// </summary>
    /// <value>The first name of the user.</value>
    [DataMember(Name="givenName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "givenName")]
    public string GivenName { get; set; }

    /// <summary>
    /// The last name of the user.
    /// </summary>
    /// <value>The last name of the user.</value>
    [DataMember(Name="familyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "familyName")]
    public string FamilyName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EnterpriseAdminProvisionAndInviteEnterpriseUserRequestName {\n");
      sb.Append("  GivenName: ").Append(GivenName).Append("\n");
      sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
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
