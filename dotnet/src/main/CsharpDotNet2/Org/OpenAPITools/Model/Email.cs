using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Email
  /// </summary>
  [DataContract]
  public class Email {
    /// <summary>
    /// Gets or Sets _Email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string _Email { get; set; }

    /// <summary>
    /// Gets or Sets Primary
    /// </summary>
    [DataMember(Name="primary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primary")]
    public bool? Primary { get; set; }

    /// <summary>
    /// Gets or Sets Verified
    /// </summary>
    [DataMember(Name="verified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verified")]
    public bool? Verified { get; set; }

    /// <summary>
    /// Gets or Sets Visibility
    /// </summary>
    [DataMember(Name="visibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibility")]
    public string Visibility { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Email {\n");
      sb.Append("  _Email: ").Append(_Email).Append("\n");
      sb.Append("  Primary: ").Append(Primary).Append("\n");
      sb.Append("  Verified: ").Append(Verified).Append("\n");
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
