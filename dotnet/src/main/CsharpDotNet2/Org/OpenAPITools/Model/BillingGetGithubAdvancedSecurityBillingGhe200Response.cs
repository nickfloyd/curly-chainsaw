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
  public class BillingGetGithubAdvancedSecurityBillingGhe200Response {
    /// <summary>
    /// Gets or Sets TotalAdvancedSecurityCommitters
    /// </summary>
    [DataMember(Name="total_advanced_security_committers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_advanced_security_committers")]
    public int? TotalAdvancedSecurityCommitters { get; set; }

    /// <summary>
    /// Gets or Sets TotalCount
    /// </summary>
    [DataMember(Name="total_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_count")]
    public int? TotalCount { get; set; }

    /// <summary>
    /// Gets or Sets Repositories
    /// </summary>
    [DataMember(Name="repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repositories")]
    public List<BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInner> Repositories { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BillingGetGithubAdvancedSecurityBillingGhe200Response {\n");
      sb.Append("  TotalAdvancedSecurityCommitters: ").Append(TotalAdvancedSecurityCommitters).Append("\n");
      sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
      sb.Append("  Repositories: ").Append(Repositories).Append("\n");
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
