using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Specify which security and analysis features to enable or disable for the repository.  To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see \&quot;[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).\&quot;  For example, to enable GitHub Advanced Security, use this data in the body of the &#x60;PATCH&#x60; request: &#x60;{ \&quot;security_and_analysis\&quot;: {\&quot;advanced_security\&quot;: { \&quot;status\&quot;: \&quot;enabled\&quot; } } }&#x60;.  You can check which security and analysis features are currently enabled by using a &#x60;GET /repos/{owner}/{repo}&#x60; request.
  /// </summary>
  [DataContract]
  public class ReposUpdateRequestSecurityAndAnalysis {
    /// <summary>
    /// Gets or Sets AdvancedSecurity
    /// </summary>
    [DataMember(Name="advanced_security", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "advanced_security")]
    public ReposUpdateRequestSecurityAndAnalysisAdvancedSecurity AdvancedSecurity { get; set; }

    /// <summary>
    /// Gets or Sets SecretScanning
    /// </summary>
    [DataMember(Name="secret_scanning", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secret_scanning")]
    public ReposUpdateRequestSecurityAndAnalysisSecretScanning SecretScanning { get; set; }

    /// <summary>
    /// Gets or Sets SecretScanningPushProtection
    /// </summary>
    [DataMember(Name="secret_scanning_push_protection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secret_scanning_push_protection")]
    public ReposUpdateRequestSecurityAndAnalysisSecretScanningPushProtection SecretScanningPushProtection { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposUpdateRequestSecurityAndAnalysis {\n");
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
