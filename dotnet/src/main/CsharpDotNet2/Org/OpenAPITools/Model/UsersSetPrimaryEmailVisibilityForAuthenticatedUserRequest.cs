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
  public class UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest {
    /// <summary>
    /// Denotes whether an email is publicly visible.
    /// </summary>
    /// <value>Denotes whether an email is publicly visible.</value>
    [DataMember(Name="visibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibility")]
    public string Visibility { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest {\n");
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
