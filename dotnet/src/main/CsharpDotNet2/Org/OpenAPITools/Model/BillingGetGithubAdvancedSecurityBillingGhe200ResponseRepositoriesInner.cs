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
  public class BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInner {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets AdvancedSecurityCommitters
    /// </summary>
    [DataMember(Name="advanced_security_committers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "advanced_security_committers")]
    public int? AdvancedSecurityCommitters { get; set; }

    /// <summary>
    /// Gets or Sets AdvancedSecurityCommittersBreakdown
    /// </summary>
    [DataMember(Name="advanced_security_committers_breakdown", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "advanced_security_committers_breakdown")]
    public List<BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInnerAdvancedSecurityCommittersBreakdownInner> AdvancedSecurityCommittersBreakdown { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInner {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  AdvancedSecurityCommitters: ").Append(AdvancedSecurityCommitters).Append("\n");
      sb.Append("  AdvancedSecurityCommittersBreakdown: ").Append(AdvancedSecurityCommittersBreakdown).Append("\n");
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
