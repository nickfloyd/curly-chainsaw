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
  public class ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest {
    /// <summary>
    /// The default workflow permissions granted to the GITHUB_TOKEN when running workflows.
    /// </summary>
    /// <value>The default workflow permissions granted to the GITHUB_TOKEN when running workflows.</value>
    [DataMember(Name="default_workflow_permissions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_workflow_permissions")]
    public string DefaultWorkflowPermissions { get; set; }

    /// <summary>
    /// Whether GitHub Actions can approve pull requests. Enabling this can be a security risk.
    /// </summary>
    /// <value>Whether GitHub Actions can approve pull requests. Enabling this can be a security risk.</value>
    [DataMember(Name="can_approve_pull_request_reviews", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "can_approve_pull_request_reviews")]
    public bool? CanApprovePullRequestReviews { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest {\n");
      sb.Append("  DefaultWorkflowPermissions: ").Append(DefaultWorkflowPermissions).Append("\n");
      sb.Append("  CanApprovePullRequestReviews: ").Append(CanApprovePullRequestReviews).Append("\n");
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
