using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Pages Health Check Status
  /// </summary>
  [DataContract]
  public class PagesHealthCheckStatus {
    /// <summary>
    /// Gets or Sets Domain
    /// </summary>
    [DataMember(Name="domain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "domain")]
    public PagesHealthCheckStatusDomain Domain { get; set; }

    /// <summary>
    /// Gets or Sets AltDomain
    /// </summary>
    [DataMember(Name="alt_domain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alt_domain")]
    public PagesHealthCheckStatusAltDomain AltDomain { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PagesHealthCheckStatus {\n");
      sb.Append("  Domain: ").Append(Domain).Append("\n");
      sb.Append("  AltDomain: ").Append(AltDomain).Append("\n");
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
