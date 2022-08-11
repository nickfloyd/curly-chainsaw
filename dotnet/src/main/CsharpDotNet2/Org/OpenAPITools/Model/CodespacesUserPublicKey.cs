using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The public key used for setting user Codespaces&#39; Secrets.
  /// </summary>
  [DataContract]
  public class CodespacesUserPublicKey {
    /// <summary>
    /// The identifier for the key.
    /// </summary>
    /// <value>The identifier for the key.</value>
    [DataMember(Name="key_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key_id")]
    public string KeyId { get; set; }

    /// <summary>
    /// The Base64 encoded public key.
    /// </summary>
    /// <value>The Base64 encoded public key.</value>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CodespacesUserPublicKey {\n");
      sb.Append("  KeyId: ").Append(KeyId).Append("\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
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
