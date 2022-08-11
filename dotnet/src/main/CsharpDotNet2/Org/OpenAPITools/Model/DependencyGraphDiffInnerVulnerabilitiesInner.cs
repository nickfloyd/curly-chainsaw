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
  public class DependencyGraphDiffInnerVulnerabilitiesInner {
    /// <summary>
    /// Gets or Sets Severity
    /// </summary>
    [DataMember(Name="severity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "severity")]
    public string Severity { get; set; }

    /// <summary>
    /// Gets or Sets AdvisoryGhsaId
    /// </summary>
    [DataMember(Name="advisory_ghsa_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "advisory_ghsa_id")]
    public string AdvisoryGhsaId { get; set; }

    /// <summary>
    /// Gets or Sets AdvisorySummary
    /// </summary>
    [DataMember(Name="advisory_summary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "advisory_summary")]
    public string AdvisorySummary { get; set; }

    /// <summary>
    /// Gets or Sets AdvisoryUrl
    /// </summary>
    [DataMember(Name="advisory_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "advisory_url")]
    public string AdvisoryUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DependencyGraphDiffInnerVulnerabilitiesInner {\n");
      sb.Append("  Severity: ").Append(Severity).Append("\n");
      sb.Append("  AdvisoryGhsaId: ").Append(AdvisoryGhsaId).Append("\n");
      sb.Append("  AdvisorySummary: ").Append(AdvisorySummary).Append("\n");
      sb.Append("  AdvisoryUrl: ").Append(AdvisoryUrl).Append("\n");
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
