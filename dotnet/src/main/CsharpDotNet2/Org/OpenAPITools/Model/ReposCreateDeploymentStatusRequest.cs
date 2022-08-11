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
  public class ReposCreateDeploymentStatusRequest {
    /// <summary>
    /// The state of the status. When you set a transient deployment to `inactive`, the deployment will be shown as `destroyed` in GitHub.
    /// </summary>
    /// <value>The state of the status. When you set a transient deployment to `inactive`, the deployment will be shown as `destroyed` in GitHub.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// The target URL to associate with this status. This URL should contain output to keep the user updated while the task is running or serve as historical information for what happened in the deployment. **Note:** It's recommended to use the `log_url` parameter, which replaces `target_url`.
    /// </summary>
    /// <value>The target URL to associate with this status. This URL should contain output to keep the user updated while the task is running or serve as historical information for what happened in the deployment. **Note:** It's recommended to use the `log_url` parameter, which replaces `target_url`.</value>
    [DataMember(Name="target_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target_url")]
    public string TargetUrl { get; set; }

    /// <summary>
    /// The full URL of the deployment's output. This parameter replaces `target_url`. We will continue to accept `target_url` to support legacy uses, but we recommend replacing `target_url` with `log_url`. Setting `log_url` will automatically set `target_url` to the same value. Default: `\"\"`
    /// </summary>
    /// <value>The full URL of the deployment's output. This parameter replaces `target_url`. We will continue to accept `target_url` to support legacy uses, but we recommend replacing `target_url` with `log_url`. Setting `log_url` will automatically set `target_url` to the same value. Default: `\"\"`</value>
    [DataMember(Name="log_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "log_url")]
    public string LogUrl { get; set; }

    /// <summary>
    /// A short description of the status. The maximum description length is 140 characters.
    /// </summary>
    /// <value>A short description of the status. The maximum description length is 140 characters.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Name for the target deployment environment, which can be changed when setting a deploy status. For example, `production`, `staging`, or `qa`.
    /// </summary>
    /// <value>Name for the target deployment environment, which can be changed when setting a deploy status. For example, `production`, `staging`, or `qa`.</value>
    [DataMember(Name="environment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "environment")]
    public string Environment { get; set; }

    /// <summary>
    /// Sets the URL for accessing your environment. Default: `\"\"`
    /// </summary>
    /// <value>Sets the URL for accessing your environment. Default: `\"\"`</value>
    [DataMember(Name="environment_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "environment_url")]
    public string EnvironmentUrl { get; set; }

    /// <summary>
    /// Adds a new `inactive` status to all prior non-transient, non-production environment deployments with the same repository and `environment` name as the created status's deployment. An `inactive` status is only added to deployments that had a `success` state. Default: `true`
    /// </summary>
    /// <value>Adds a new `inactive` status to all prior non-transient, non-production environment deployments with the same repository and `environment` name as the created status's deployment. An `inactive` status is only added to deployments that had a `success` state. Default: `true`</value>
    [DataMember(Name="auto_inactive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "auto_inactive")]
    public bool? AutoInactive { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposCreateDeploymentStatusRequest {\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  TargetUrl: ").Append(TargetUrl).Append("\n");
      sb.Append("  LogUrl: ").Append(LogUrl).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Environment: ").Append(Environment).Append("\n");
      sb.Append("  EnvironmentUrl: ").Append(EnvironmentUrl).Append("\n");
      sb.Append("  AutoInactive: ").Append(AutoInactive).Append("\n");
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
