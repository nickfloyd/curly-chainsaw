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
  public class EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response {
    /// <summary>
    /// Gets or Sets TotalCount
    /// </summary>
    [DataMember(Name="total_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_count")]
    public decimal? TotalCount { get; set; }

    /// <summary>
    /// Gets or Sets Organizations
    /// </summary>
    [DataMember(Name="organizations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organizations")]
    public List<OrganizationSimple> Organizations { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response {\n");
      sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
      sb.Append("  Organizations: ").Append(Organizations).Append("\n");
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
