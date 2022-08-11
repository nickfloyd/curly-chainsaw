using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Details of a deployment that is waiting for protection rules to pass
  /// </summary>
  [DataContract]
  public class PendingDeployment {
    /// <summary>
    /// Gets or Sets Environment
    /// </summary>
    [DataMember(Name="environment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "environment")]
    public PendingDeploymentEnvironment Environment { get; set; }

    /// <summary>
    /// The set duration of the wait timer
    /// </summary>
    /// <value>The set duration of the wait timer</value>
    [DataMember(Name="wait_timer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wait_timer")]
    public int? WaitTimer { get; set; }

    /// <summary>
    /// The time that the wait timer began.
    /// </summary>
    /// <value>The time that the wait timer began.</value>
    [DataMember(Name="wait_timer_started_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wait_timer_started_at")]
    public DateTime? WaitTimerStartedAt { get; set; }

    /// <summary>
    /// Whether the currently authenticated user can approve the deployment
    /// </summary>
    /// <value>Whether the currently authenticated user can approve the deployment</value>
    [DataMember(Name="current_user_can_approve", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "current_user_can_approve")]
    public bool? CurrentUserCanApprove { get; set; }

    /// <summary>
    /// The people or teams that may approve jobs that reference the environment. You can list up to six users or teams as reviewers. The reviewers must have at least read access to the repository. Only one of the required reviewers needs to approve the job for it to proceed.
    /// </summary>
    /// <value>The people or teams that may approve jobs that reference the environment. You can list up to six users or teams as reviewers. The reviewers must have at least read access to the repository. Only one of the required reviewers needs to approve the job for it to proceed.</value>
    [DataMember(Name="reviewers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reviewers")]
    public List<PendingDeploymentReviewersInner> Reviewers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PendingDeployment {\n");
      sb.Append("  Environment: ").Append(Environment).Append("\n");
      sb.Append("  WaitTimer: ").Append(WaitTimer).Append("\n");
      sb.Append("  WaitTimerStartedAt: ").Append(WaitTimerStartedAt).Append("\n");
      sb.Append("  CurrentUserCanApprove: ").Append(CurrentUserCanApprove).Append("\n");
      sb.Append("  Reviewers: ").Append(Reviewers).Append("\n");
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
