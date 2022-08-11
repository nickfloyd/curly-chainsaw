using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The status of a deployment.
  /// </summary>
  [DataContract]
  public class DeploymentStatus {
    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }

    /// <summary>
    /// The state of the status.
    /// </summary>
    /// <value>The state of the status.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets Creator
    /// </summary>
    [DataMember(Name="creator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creator")]
    public SimpleUser Creator { get; set; }

    /// <summary>
    /// A short description of the status.
    /// </summary>
    /// <value>A short description of the status.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The environment of the deployment that the status is for.
    /// </summary>
    /// <value>The environment of the deployment that the status is for.</value>
    [DataMember(Name="environment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "environment")]
    public string Environment { get; set; }

    /// <summary>
    /// Deprecated: the URL to associate with this status.
    /// </summary>
    /// <value>Deprecated: the URL to associate with this status.</value>
    [DataMember(Name="target_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target_url")]
    public string TargetUrl { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedAt
    /// </summary>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets or Sets DeploymentUrl
    /// </summary>
    [DataMember(Name="deployment_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deployment_url")]
    public string DeploymentUrl { get; set; }

    /// <summary>
    /// Gets or Sets RepositoryUrl
    /// </summary>
    [DataMember(Name="repository_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository_url")]
    public string RepositoryUrl { get; set; }

    /// <summary>
    /// The URL for accessing your environment.
    /// </summary>
    /// <value>The URL for accessing your environment.</value>
    [DataMember(Name="environment_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "environment_url")]
    public string EnvironmentUrl { get; set; }

    /// <summary>
    /// The URL to associate with this status.
    /// </summary>
    /// <value>The URL to associate with this status.</value>
    [DataMember(Name="log_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "log_url")]
    public string LogUrl { get; set; }

    /// <summary>
    /// Gets or Sets PerformedViaGithubApp
    /// </summary>
    [DataMember(Name="performed_via_github_app", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "performed_via_github_app")]
    public GitHubApp1 PerformedViaGithubApp { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DeploymentStatus {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Creator: ").Append(Creator).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Environment: ").Append(Environment).Append("\n");
      sb.Append("  TargetUrl: ").Append(TargetUrl).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  DeploymentUrl: ").Append(DeploymentUrl).Append("\n");
      sb.Append("  RepositoryUrl: ").Append(RepositoryUrl).Append("\n");
      sb.Append("  EnvironmentUrl: ").Append(EnvironmentUrl).Append("\n");
      sb.Append("  LogUrl: ").Append(LogUrl).Append("\n");
      sb.Append("  PerformedViaGithubApp: ").Append(PerformedViaGithubApp).Append("\n");
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
