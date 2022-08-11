using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// A check performed on the code of a given code change
  /// </summary>
  [DataContract]
  public class CheckRun {
    /// <summary>
    /// The id of the check.
    /// </summary>
    /// <value>The id of the check.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The SHA of the commit that is being checked.
    /// </summary>
    /// <value>The SHA of the commit that is being checked.</value>
    [DataMember(Name="head_sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "head_sha")]
    public string HeadSha { get; set; }

    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }

    /// <summary>
    /// Gets or Sets ExternalId
    /// </summary>
    [DataMember(Name="external_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "external_id")]
    public string ExternalId { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Gets or Sets DetailsUrl
    /// </summary>
    [DataMember(Name="details_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "details_url")]
    public string DetailsUrl { get; set; }

    /// <summary>
    /// The phase of the lifecycle that the check is currently in.
    /// </summary>
    /// <value>The phase of the lifecycle that the check is currently in.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets Conclusion
    /// </summary>
    [DataMember(Name="conclusion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conclusion")]
    public string Conclusion { get; set; }

    /// <summary>
    /// Gets or Sets StartedAt
    /// </summary>
    [DataMember(Name="started_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "started_at")]
    public DateTime? StartedAt { get; set; }

    /// <summary>
    /// Gets or Sets CompletedAt
    /// </summary>
    [DataMember(Name="completed_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completed_at")]
    public DateTime? CompletedAt { get; set; }

    /// <summary>
    /// Gets or Sets Output
    /// </summary>
    [DataMember(Name="output", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "output")]
    public CheckRunOutput Output { get; set; }

    /// <summary>
    /// The name of the check.
    /// </summary>
    /// <value>The name of the check.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets CheckSuite
    /// </summary>
    [DataMember(Name="check_suite", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "check_suite")]
    public CheckRunCheckSuite CheckSuite { get; set; }

    /// <summary>
    /// Gets or Sets App
    /// </summary>
    [DataMember(Name="app", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "app")]
    public GitHubApp1 App { get; set; }

    /// <summary>
    /// Gets or Sets PullRequests
    /// </summary>
    [DataMember(Name="pull_requests", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pull_requests")]
    public List<PullRequestMinimal> PullRequests { get; set; }

    /// <summary>
    /// Gets or Sets Deployment
    /// </summary>
    [DataMember(Name="deployment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deployment")]
    public Deployment1 Deployment { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckRun {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  HeadSha: ").Append(HeadSha).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  DetailsUrl: ").Append(DetailsUrl).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Conclusion: ").Append(Conclusion).Append("\n");
      sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
      sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
      sb.Append("  Output: ").Append(Output).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  CheckSuite: ").Append(CheckSuite).Append("\n");
      sb.Append("  App: ").Append(App).Append("\n");
      sb.Append("  PullRequests: ").Append(PullRequests).Append("\n");
      sb.Append("  Deployment: ").Append(Deployment).Append("\n");
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
