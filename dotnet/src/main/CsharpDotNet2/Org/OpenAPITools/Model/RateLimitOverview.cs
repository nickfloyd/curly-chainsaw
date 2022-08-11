using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Rate Limit Overview
  /// </summary>
  [DataContract]
  public class RateLimitOverview {
    /// <summary>
    /// Gets or Sets Resources
    /// </summary>
    [DataMember(Name="resources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resources")]
    public RateLimitOverviewResources Resources { get; set; }

    /// <summary>
    /// Gets or Sets Rate
    /// </summary>
    [DataMember(Name="rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rate")]
    public RateLimit Rate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RateLimitOverview {\n");
      sb.Append("  Resources: ").Append(Resources).Append("\n");
      sb.Append("  Rate: ").Append(Rate).Append("\n");
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
