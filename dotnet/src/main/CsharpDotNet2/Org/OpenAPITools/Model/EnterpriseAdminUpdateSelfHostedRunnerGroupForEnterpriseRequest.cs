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
  public class EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest {
    /// <summary>
    /// Name of the runner group.
    /// </summary>
    /// <value>Name of the runner group.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Visibility of a runner group. You can select all organizations or select individual organizations.
    /// </summary>
    /// <value>Visibility of a runner group. You can select all organizations or select individual organizations.</value>
    [DataMember(Name="visibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibility")]
    public string Visibility { get; set; }

    /// <summary>
    /// Whether the runner group can be used by `public` repositories.
    /// </summary>
    /// <value>Whether the runner group can be used by `public` repositories.</value>
    [DataMember(Name="allows_public_repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allows_public_repositories")]
    public bool? AllowsPublicRepositories { get; set; }

    /// <summary>
    /// If `true`, the runner group will be restricted to running only the workflows specified in the `selected_workflows` array.
    /// </summary>
    /// <value>If `true`, the runner group will be restricted to running only the workflows specified in the `selected_workflows` array.</value>
    [DataMember(Name="restricted_to_workflows", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "restricted_to_workflows")]
    public bool? RestrictedToWorkflows { get; set; }

    /// <summary>
    /// List of workflows the runner group should be allowed to run. This setting will be ignored unless `restricted_to_workflows` is set to `true`.
    /// </summary>
    /// <value>List of workflows the runner group should be allowed to run. This setting will be ignored unless `restricted_to_workflows` is set to `true`.</value>
    [DataMember(Name="selected_workflows", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selected_workflows")]
    public List<string> SelectedWorkflows { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Visibility: ").Append(Visibility).Append("\n");
      sb.Append("  AllowsPublicRepositories: ").Append(AllowsPublicRepositories).Append("\n");
      sb.Append("  RestrictedToWorkflows: ").Append(RestrictedToWorkflows).Append("\n");
      sb.Append("  SelectedWorkflows: ").Append(SelectedWorkflows).Append("\n");
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
