using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Use the &#x60;status&#x60; property to enable or disable secret scanning for this repository. For more information, see \&quot;[About secret scanning](/code-security/secret-security/about-secret-scanning).\&quot;
  /// </summary>
  [DataContract]
  public class ReposUpdateRequestSecurityAndAnalysisSecretScanning {
    /// <summary>
    /// Can be `enabled` or `disabled`.
    /// </summary>
    /// <value>Can be `enabled` or `disabled`.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposUpdateRequestSecurityAndAnalysisSecretScanning {\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
