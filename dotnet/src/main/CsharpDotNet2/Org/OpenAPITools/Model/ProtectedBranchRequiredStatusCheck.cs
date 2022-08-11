using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Protected Branch Required Status Check
  /// </summary>
  [DataContract]
  public class ProtectedBranchRequiredStatusCheck {
    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets EnforcementLevel
    /// </summary>
    [DataMember(Name="enforcement_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enforcement_level")]
    public string EnforcementLevel { get; set; }

    /// <summary>
    /// Gets or Sets Contexts
    /// </summary>
    [DataMember(Name="contexts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contexts")]
    public List<string> Contexts { get; set; }

    /// <summary>
    /// Gets or Sets Checks
    /// </summary>
    [DataMember(Name="checks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checks")]
    public List<ProtectedBranchRequiredStatusCheckChecksInner> Checks { get; set; }

    /// <summary>
    /// Gets or Sets ContextsUrl
    /// </summary>
    [DataMember(Name="contexts_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contexts_url")]
    public string ContextsUrl { get; set; }

    /// <summary>
    /// Gets or Sets Strict
    /// </summary>
    [DataMember(Name="strict", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "strict")]
    public bool? Strict { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProtectedBranchRequiredStatusCheck {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  EnforcementLevel: ").Append(EnforcementLevel).Append("\n");
      sb.Append("  Contexts: ").Append(Contexts).Append("\n");
      sb.Append("  Checks: ").Append(Checks).Append("\n");
      sb.Append("  ContextsUrl: ").Append(ContextsUrl).Append("\n");
      sb.Append("  Strict: ").Append(Strict).Append("\n");
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
