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
  public class ReposCreateDeploymentRequest {
    /// <summary>
    /// The ref to deploy. This can be a branch, tag, or SHA.
    /// </summary>
    /// <value>The ref to deploy. This can be a branch, tag, or SHA.</value>
    [DataMember(Name="ref", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ref")]
    public string Ref { get; set; }

    /// <summary>
    /// Specifies a task to execute (e.g., `deploy` or `deploy:migrations`).
    /// </summary>
    /// <value>Specifies a task to execute (e.g., `deploy` or `deploy:migrations`).</value>
    [DataMember(Name="task", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "task")]
    public string Task { get; set; }

    /// <summary>
    /// Attempts to automatically merge the default branch into the requested ref, if it's behind the default branch.
    /// </summary>
    /// <value>Attempts to automatically merge the default branch into the requested ref, if it's behind the default branch.</value>
    [DataMember(Name="auto_merge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "auto_merge")]
    public bool? AutoMerge { get; set; }

    /// <summary>
    /// The [status](https://docs.github.com/rest/commits/statuses) contexts to verify against commit status checks. If you omit this parameter, GitHub verifies all unique contexts before creating a deployment. To bypass checking entirely, pass an empty array. Defaults to all unique contexts.
    /// </summary>
    /// <value>The [status](https://docs.github.com/rest/commits/statuses) contexts to verify against commit status checks. If you omit this parameter, GitHub verifies all unique contexts before creating a deployment. To bypass checking entirely, pass an empty array. Defaults to all unique contexts.</value>
    [DataMember(Name="required_contexts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required_contexts")]
    public List<string> RequiredContexts { get; set; }

    /// <summary>
    /// Gets or Sets Payload
    /// </summary>
    [DataMember(Name="payload", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payload")]
    public ReposCreateDeploymentRequestPayload Payload { get; set; }

    /// <summary>
    /// Name for the target deployment environment (e.g., `production`, `staging`, `qa`).
    /// </summary>
    /// <value>Name for the target deployment environment (e.g., `production`, `staging`, `qa`).</value>
    [DataMember(Name="environment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "environment")]
    public string Environment { get; set; }

    /// <summary>
    /// Short description of the deployment.
    /// </summary>
    /// <value>Short description of the deployment.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Specifies if the given environment is specific to the deployment and will no longer exist at some point in the future. Default: `false`
    /// </summary>
    /// <value>Specifies if the given environment is specific to the deployment and will no longer exist at some point in the future. Default: `false`</value>
    [DataMember(Name="transient_environment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transient_environment")]
    public bool? TransientEnvironment { get; set; }

    /// <summary>
    /// Specifies if the given environment is one that end-users directly interact with. Default: `true` when `environment` is `production` and `false` otherwise.
    /// </summary>
    /// <value>Specifies if the given environment is one that end-users directly interact with. Default: `true` when `environment` is `production` and `false` otherwise.</value>
    [DataMember(Name="production_environment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "production_environment")]
    public bool? ProductionEnvironment { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposCreateDeploymentRequest {\n");
      sb.Append("  Ref: ").Append(Ref).Append("\n");
      sb.Append("  Task: ").Append(Task).Append("\n");
      sb.Append("  AutoMerge: ").Append(AutoMerge).Append("\n");
      sb.Append("  RequiredContexts: ").Append(RequiredContexts).Append("\n");
      sb.Append("  Payload: ").Append(Payload).Append("\n");
      sb.Append("  Environment: ").Append(Environment).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  TransientEnvironment: ").Append(TransientEnvironment).Append("\n");
      sb.Append("  ProductionEnvironment: ").Append(ProductionEnvironment).Append("\n");
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
