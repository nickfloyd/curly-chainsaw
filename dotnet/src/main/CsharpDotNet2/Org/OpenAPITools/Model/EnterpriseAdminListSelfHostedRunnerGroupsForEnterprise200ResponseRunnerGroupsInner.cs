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
  public class EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Visibility
    /// </summary>
    [DataMember(Name="visibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibility")]
    public string Visibility { get; set; }

    /// <summary>
    /// Gets or Sets Default
    /// </summary>
    [DataMember(Name="default", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default")]
    public bool? Default { get; set; }

    /// <summary>
    /// Gets or Sets SelectedOrganizationsUrl
    /// </summary>
    [DataMember(Name="selected_organizations_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selected_organizations_url")]
    public string SelectedOrganizationsUrl { get; set; }

    /// <summary>
    /// Gets or Sets RunnersUrl
    /// </summary>
    [DataMember(Name="runners_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runners_url")]
    public string RunnersUrl { get; set; }

    /// <summary>
    /// Gets or Sets AllowsPublicRepositories
    /// </summary>
    [DataMember(Name="allows_public_repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allows_public_repositories")]
    public bool? AllowsPublicRepositories { get; set; }

    /// <summary>
    /// If `true`, the `restricted_to_workflows` and `selected_workflows` fields cannot be modified.
    /// </summary>
    /// <value>If `true`, the `restricted_to_workflows` and `selected_workflows` fields cannot be modified.</value>
    [DataMember(Name="workflow_restrictions_read_only", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workflow_restrictions_read_only")]
    public bool? WorkflowRestrictionsReadOnly { get; set; }

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
      sb.Append("class EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Visibility: ").Append(Visibility).Append("\n");
      sb.Append("  Default: ").Append(Default).Append("\n");
      sb.Append("  SelectedOrganizationsUrl: ").Append(SelectedOrganizationsUrl).Append("\n");
      sb.Append("  RunnersUrl: ").Append(RunnersUrl).Append("\n");
      sb.Append("  AllowsPublicRepositories: ").Append(AllowsPublicRepositories).Append("\n");
      sb.Append("  WorkflowRestrictionsReadOnly: ").Append(WorkflowRestrictionsReadOnly).Append("\n");
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
