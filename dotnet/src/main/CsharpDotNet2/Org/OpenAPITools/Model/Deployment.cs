using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// A request for a specific ref(branch,sha,tag) to be deployed
  /// </summary>
  [DataContract]
  public class Deployment {
    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Unique identifier of the deployment
    /// </summary>
    /// <value>Unique identifier of the deployment</value>
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
    /// Gets or Sets Sha
    /// </summary>
    [DataMember(Name="sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sha")]
    public string Sha { get; set; }

    /// <summary>
    /// The ref to deploy. This can be a branch, tag, or sha.
    /// </summary>
    /// <value>The ref to deploy. This can be a branch, tag, or sha.</value>
    [DataMember(Name="ref", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ref")]
    public string Ref { get; set; }

    /// <summary>
    /// Parameter to specify a task to execute
    /// </summary>
    /// <value>Parameter to specify a task to execute</value>
    [DataMember(Name="task", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "task")]
    public string Task { get; set; }

    /// <summary>
    /// Gets or Sets Payload
    /// </summary>
    [DataMember(Name="payload", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payload")]
    public DeploymentPayload Payload { get; set; }

    /// <summary>
    /// Gets or Sets OriginalEnvironment
    /// </summary>
    [DataMember(Name="original_environment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_environment")]
    public string OriginalEnvironment { get; set; }

    /// <summary>
    /// Name for the target deployment environment.
    /// </summary>
    /// <value>Name for the target deployment environment.</value>
    [DataMember(Name="environment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "environment")]
    public string Environment { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Creator
    /// </summary>
    [DataMember(Name="creator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creator")]
    public SimpleUser Creator { get; set; }

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
    /// Gets or Sets StatusesUrl
    /// </summary>
    [DataMember(Name="statuses_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statuses_url")]
    public string StatusesUrl { get; set; }

    /// <summary>
    /// Gets or Sets RepositoryUrl
    /// </summary>
    [DataMember(Name="repository_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository_url")]
    public string RepositoryUrl { get; set; }

    /// <summary>
    /// Specifies if the given environment is will no longer exist at some point in the future. Default: false.
    /// </summary>
    /// <value>Specifies if the given environment is will no longer exist at some point in the future. Default: false.</value>
    [DataMember(Name="transient_environment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transient_environment")]
    public bool? TransientEnvironment { get; set; }

    /// <summary>
    /// Specifies if the given environment is one that end-users directly interact with. Default: false.
    /// </summary>
    /// <value>Specifies if the given environment is one that end-users directly interact with. Default: false.</value>
    [DataMember(Name="production_environment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "production_environment")]
    public bool? ProductionEnvironment { get; set; }

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
      sb.Append("class Deployment {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  Sha: ").Append(Sha).Append("\n");
      sb.Append("  Ref: ").Append(Ref).Append("\n");
      sb.Append("  Task: ").Append(Task).Append("\n");
      sb.Append("  Payload: ").Append(Payload).Append("\n");
      sb.Append("  OriginalEnvironment: ").Append(OriginalEnvironment).Append("\n");
      sb.Append("  Environment: ").Append(Environment).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Creator: ").Append(Creator).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  StatusesUrl: ").Append(StatusesUrl).Append("\n");
      sb.Append("  RepositoryUrl: ").Append(RepositoryUrl).Append("\n");
      sb.Append("  TransientEnvironment: ").Append(TransientEnvironment).Append("\n");
      sb.Append("  ProductionEnvironment: ").Append(ProductionEnvironment).Append("\n");
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
