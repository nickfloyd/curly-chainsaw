using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// A suite of checks performed on the code of a given code change
  /// </summary>
  [DataContract]
  public class CheckSuite {
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
    /// Gets or Sets HeadBranch
    /// </summary>
    [DataMember(Name="head_branch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "head_branch")]
    public string HeadBranch { get; set; }

    /// <summary>
    /// The SHA of the head commit that is being checked.
    /// </summary>
    /// <value>The SHA of the head commit that is being checked.</value>
    [DataMember(Name="head_sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "head_sha")]
    public string HeadSha { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
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
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets Before
    /// </summary>
    [DataMember(Name="before", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "before")]
    public string Before { get; set; }

    /// <summary>
    /// Gets or Sets After
    /// </summary>
    [DataMember(Name="after", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "after")]
    public string After { get; set; }

    /// <summary>
    /// Gets or Sets PullRequests
    /// </summary>
    [DataMember(Name="pull_requests", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pull_requests")]
    public List<PullRequestMinimal> PullRequests { get; set; }

    /// <summary>
    /// Gets or Sets App
    /// </summary>
    [DataMember(Name="app", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "app")]
    public GitHubApp1 App { get; set; }

    /// <summary>
    /// Gets or Sets Repository
    /// </summary>
    [DataMember(Name="repository", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository")]
    public MinimalRepository Repository { get; set; }

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
    /// Gets or Sets HeadCommit
    /// </summary>
    [DataMember(Name="head_commit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "head_commit")]
    public SimpleCommit1 HeadCommit { get; set; }

    /// <summary>
    /// Gets or Sets LatestCheckRunsCount
    /// </summary>
    [DataMember(Name="latest_check_runs_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latest_check_runs_count")]
    public int? LatestCheckRunsCount { get; set; }

    /// <summary>
    /// Gets or Sets CheckRunsUrl
    /// </summary>
    [DataMember(Name="check_runs_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "check_runs_url")]
    public string CheckRunsUrl { get; set; }

    /// <summary>
    /// Gets or Sets Rerequestable
    /// </summary>
    [DataMember(Name="rerequestable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rerequestable")]
    public bool? Rerequestable { get; set; }

    /// <summary>
    /// Gets or Sets RunsRerequestable
    /// </summary>
    [DataMember(Name="runs_rerequestable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runs_rerequestable")]
    public bool? RunsRerequestable { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckSuite {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  HeadBranch: ").Append(HeadBranch).Append("\n");
      sb.Append("  HeadSha: ").Append(HeadSha).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Conclusion: ").Append(Conclusion).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Before: ").Append(Before).Append("\n");
      sb.Append("  After: ").Append(After).Append("\n");
      sb.Append("  PullRequests: ").Append(PullRequests).Append("\n");
      sb.Append("  App: ").Append(App).Append("\n");
      sb.Append("  Repository: ").Append(Repository).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  HeadCommit: ").Append(HeadCommit).Append("\n");
      sb.Append("  LatestCheckRunsCount: ").Append(LatestCheckRunsCount).Append("\n");
      sb.Append("  CheckRunsUrl: ").Append(CheckRunsUrl).Append("\n");
      sb.Append("  Rerequestable: ").Append(Rerequestable).Append("\n");
      sb.Append("  RunsRerequestable: ").Append(RunsRerequestable).Append("\n");
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
