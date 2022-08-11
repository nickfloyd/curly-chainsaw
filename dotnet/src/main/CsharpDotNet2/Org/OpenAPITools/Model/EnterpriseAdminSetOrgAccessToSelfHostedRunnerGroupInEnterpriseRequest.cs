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
  public class EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest {
    /// <summary>
    /// List of organization IDs that can access the runner group.
    /// </summary>
    /// <value>List of organization IDs that can access the runner group.</value>
    [DataMember(Name="selected_organization_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selected_organization_ids")]
    public List<int?> SelectedOrganizationIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest {\n");
      sb.Append("  SelectedOrganizationIds: ").Append(SelectedOrganizationIds).Append("\n");
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
