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
  public class OrgsListCustomRoles200Response {
    /// <summary>
    /// The number of custom roles in this organization
    /// </summary>
    /// <value>The number of custom roles in this organization</value>
    [DataMember(Name="total_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_count")]
    public int? TotalCount { get; set; }

    /// <summary>
    /// Gets or Sets CustomRoles
    /// </summary>
    [DataMember(Name="custom_roles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_roles")]
    public List<OrganizationCustomRepositoryRole> CustomRoles { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrgsListCustomRoles200Response {\n");
      sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
      sb.Append("  CustomRoles: ").Append(CustomRoles).Append("\n");
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
