using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// An entry in the reviews log for environment deployments
  /// </summary>
  [DataContract]
  public class EnvironmentApproval {
    /// <summary>
    /// The list of environments that were approved or rejected
    /// </summary>
    /// <value>The list of environments that were approved or rejected</value>
    [DataMember(Name="environments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "environments")]
    public List<EnvironmentApprovalEnvironmentsInner> Environments { get; set; }

    /// <summary>
    /// Whether deployment to the environment(s) was approved or rejected
    /// </summary>
    /// <value>Whether deployment to the environment(s) was approved or rejected</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public SimpleUser1 User { get; set; }

    /// <summary>
    /// The comment submitted with the deployment review
    /// </summary>
    /// <value>The comment submitted with the deployment review</value>
    [DataMember(Name="comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment")]
    public string Comment { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EnvironmentApproval {\n");
      sb.Append("  Environments: ").Append(Environments).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
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
