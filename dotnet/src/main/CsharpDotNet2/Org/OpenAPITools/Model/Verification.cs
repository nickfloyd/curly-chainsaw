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
  public class Verification {
    /// <summary>
    /// Gets or Sets Verified
    /// </summary>
    [DataMember(Name="verified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verified")]
    public bool? Verified { get; set; }

    /// <summary>
    /// Gets or Sets Reason
    /// </summary>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// Gets or Sets Payload
    /// </summary>
    [DataMember(Name="payload", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payload")]
    public string Payload { get; set; }

    /// <summary>
    /// Gets or Sets Signature
    /// </summary>
    [DataMember(Name="signature", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signature")]
    public string Signature { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Verification {\n");
      sb.Append("  Verified: ").Append(Verified).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  Payload: ").Append(Payload).Append("\n");
      sb.Append("  Signature: ").Append(Signature).Append("\n");
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
