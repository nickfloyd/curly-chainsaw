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
  public class FullRepositorySecurityAndAnalysis {
    /// <summary>
    /// Gets or Sets AdvancedSecurity
    /// </summary>
    [DataMember(Name="advanced_security", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "advanced_security")]
    public FullRepositorySecurityAndAnalysisAdvancedSecurity AdvancedSecurity { get; set; }

    /// <summary>
    /// Gets or Sets SecretScanning
    /// </summary>
    [DataMember(Name="secret_scanning", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secret_scanning")]
    public FullRepositorySecurityAndAnalysisAdvancedSecurity SecretScanning { get; set; }

    /// <summary>
    /// Gets or Sets SecretScanningPushProtection
    /// </summary>
    [DataMember(Name="secret_scanning_push_protection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secret_scanning_push_protection")]
    public FullRepositorySecurityAndAnalysisAdvancedSecurity SecretScanningPushProtection { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FullRepositorySecurityAndAnalysis {\n");
      sb.Append("  AdvancedSecurity: ").Append(AdvancedSecurity).Append("\n");
      sb.Append("  SecretScanning: ").Append(SecretScanning).Append("\n");
      sb.Append("  SecretScanningPushProtection: ").Append(SecretScanningPushProtection).Append("\n");
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
