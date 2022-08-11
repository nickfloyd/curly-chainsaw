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
  public class ActionsReviewPendingDeploymentsForRunRequest {
    /// <summary>
    /// The list of environment ids to approve or reject
    /// </summary>
    /// <value>The list of environment ids to approve or reject</value>
    [DataMember(Name="environment_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "environment_ids")]
    public List<int?> EnvironmentIds { get; set; }

    /// <summary>
    /// Whether to approve or reject deployment to the specified environments.
    /// </summary>
    /// <value>Whether to approve or reject deployment to the specified environments.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// A comment to accompany the deployment review
    /// </summary>
    /// <value>A comment to accompany the deployment review</value>
    [DataMember(Name="comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment")]
    public string Comment { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActionsReviewPendingDeploymentsForRunRequest {\n");
      sb.Append("  EnvironmentIds: ").Append(EnvironmentIds).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
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
