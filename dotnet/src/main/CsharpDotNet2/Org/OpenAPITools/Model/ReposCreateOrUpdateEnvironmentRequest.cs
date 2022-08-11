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
  public class ReposCreateOrUpdateEnvironmentRequest {
    /// <summary>
    /// The amount of time to delay a job after the job is initially triggered. The time (in minutes) must be an integer between 0 and 43,200 (30 days).
    /// </summary>
    /// <value>The amount of time to delay a job after the job is initially triggered. The time (in minutes) must be an integer between 0 and 43,200 (30 days).</value>
    [DataMember(Name="wait_timer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wait_timer")]
    public int? WaitTimer { get; set; }

    /// <summary>
    /// The people or teams that may review jobs that reference the environment. You can list up to six users or teams as reviewers. The reviewers must have at least read access to the repository. Only one of the required reviewers needs to approve the job for it to proceed.
    /// </summary>
    /// <value>The people or teams that may review jobs that reference the environment. You can list up to six users or teams as reviewers. The reviewers must have at least read access to the repository. Only one of the required reviewers needs to approve the job for it to proceed.</value>
    [DataMember(Name="reviewers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reviewers")]
    public List<ReposCreateOrUpdateEnvironmentRequestReviewersInner> Reviewers { get; set; }

    /// <summary>
    /// Gets or Sets DeploymentBranchPolicy
    /// </summary>
    [DataMember(Name="deployment_branch_policy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deployment_branch_policy")]
    public EnvironmentDeploymentBranchPolicy DeploymentBranchPolicy { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposCreateOrUpdateEnvironmentRequest {\n");
      sb.Append("  WaitTimer: ").Append(WaitTimer).Append("\n");
      sb.Append("  Reviewers: ").Append(Reviewers).Append("\n");
      sb.Append("  DeploymentBranchPolicy: ").Append(DeploymentBranchPolicy).Append("\n");
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
