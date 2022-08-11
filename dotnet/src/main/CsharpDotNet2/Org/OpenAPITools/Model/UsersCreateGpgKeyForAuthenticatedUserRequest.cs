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
  public class UsersCreateGpgKeyForAuthenticatedUserRequest {
    /// <summary>
    /// A descriptive name for the new key.
    /// </summary>
    /// <value>A descriptive name for the new key.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A GPG key in ASCII-armored format.
    /// </summary>
    /// <value>A GPG key in ASCII-armored format.</value>
    [DataMember(Name="armored_public_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "armored_public_key")]
    public string ArmoredPublicKey { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UsersCreateGpgKeyForAuthenticatedUserRequest {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ArmoredPublicKey: ").Append(ArmoredPublicKey).Append("\n");
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
