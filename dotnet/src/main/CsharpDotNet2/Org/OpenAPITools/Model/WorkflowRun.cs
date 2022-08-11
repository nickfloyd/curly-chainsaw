using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// An invocation of a workflow
  /// </summary>
  [DataContract]
  public class WorkflowRun {
    /// <summary>
    /// The ID of the workflow run.
    /// </summary>
    /// <value>The ID of the workflow run.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The name of the workflow run.
    /// </summary>
    /// <value>The name of the workflow run.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }

    /// <summary>
    /// The ID of the associated check suite.
    /// </summary>
    /// <value>The ID of the associated check suite.</value>
    [DataMember(Name="check_suite_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "check_suite_id")]
    public int? CheckSuiteId { get; set; }

    /// <summary>
    /// The node ID of the associated check suite.
    /// </summary>
    /// <value>The node ID of the associated check suite.</value>
    [DataMember(Name="check_suite_node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "check_suite_node_id")]
    public string CheckSuiteNodeId { get; set; }

    /// <summary>
    /// Gets or Sets HeadBranch
    /// </summary>
    [DataMember(Name="head_branch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "head_branch")]
    public string HeadBranch { get; set; }

    /// <summary>
    /// The SHA of the head commit that points to the version of the workflow being run.
    /// </summary>
    /// <value>The SHA of the head commit that points to the version of the workflow being run.</value>
    [DataMember(Name="head_sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "head_sha")]
    public string HeadSha { get; set; }

    /// <summary>
    /// The full path of the workflow
    /// </summary>
    /// <value>The full path of the workflow</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// The auto incrementing run number for the workflow run.
    /// </summary>
    /// <value>The auto incrementing run number for the workflow run.</value>
    [DataMember(Name="run_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "run_number")]
    public int? RunNumber { get; set; }

    /// <summary>
    /// Attempt number of the run, 1 for first attempt and higher if the workflow was re-run.
    /// </summary>
    /// <value>Attempt number of the run, 1 for first attempt and higher if the workflow was re-run.</value>
    [DataMember(Name="run_attempt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "run_attempt")]
    public int? RunAttempt { get; set; }

    /// <summary>
    /// Gets or Sets ReferencedWorkflows
    /// </summary>
    [DataMember(Name="referenced_workflows", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referenced_workflows")]
    public List<ReferencedWorkflow> ReferencedWorkflows { get; set; }

    /// <summary>
    /// Gets or Sets Event
    /// </summary>
    [DataMember(Name="event", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event")]
    public string Event { get; set; }

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
    /// The ID of the parent workflow.
    /// </summary>
    /// <value>The ID of the parent workflow.</value>
    [DataMember(Name="workflow_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workflow_id")]
    public int? WorkflowId { get; set; }

    /// <summary>
    /// The URL to the workflow run.
    /// </summary>
    /// <value>The URL to the workflow run.</value>
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
    /// Gets or Sets PullRequests
    /// </summary>
    [DataMember(Name="pull_requests", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pull_requests")]
    public List<PullRequestMinimal> PullRequests { get; set; }

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
    /// Gets or Sets Actor
    /// </summary>
    [DataMember(Name="actor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actor")]
    public SimpleUser1 Actor { get; set; }

    /// <summary>
    /// Gets or Sets TriggeringActor
    /// </summary>
    [DataMember(Name="triggering_actor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "triggering_actor")]
    public SimpleUser1 TriggeringActor { get; set; }

    /// <summary>
    /// The start time of the latest run. Resets on re-run.
    /// </summary>
    /// <value>The start time of the latest run. Resets on re-run.</value>
    [DataMember(Name="run_started_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "run_started_at")]
    public DateTime? RunStartedAt { get; set; }

    /// <summary>
    /// The URL to the jobs for the workflow run.
    /// </summary>
    /// <value>The URL to the jobs for the workflow run.</value>
    [DataMember(Name="jobs_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_url")]
    public string JobsUrl { get; set; }

    /// <summary>
    /// The URL to download the logs for the workflow run.
    /// </summary>
    /// <value>The URL to download the logs for the workflow run.</value>
    [DataMember(Name="logs_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logs_url")]
    public string LogsUrl { get; set; }

    /// <summary>
    /// The URL to the associated check suite.
    /// </summary>
    /// <value>The URL to the associated check suite.</value>
    [DataMember(Name="check_suite_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "check_suite_url")]
    public string CheckSuiteUrl { get; set; }

    /// <summary>
    /// The URL to the artifacts for the workflow run.
    /// </summary>
    /// <value>The URL to the artifacts for the workflow run.</value>
    [DataMember(Name="artifacts_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "artifacts_url")]
    public string ArtifactsUrl { get; set; }

    /// <summary>
    /// The URL to cancel the workflow run.
    /// </summary>
    /// <value>The URL to cancel the workflow run.</value>
    [DataMember(Name="cancel_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cancel_url")]
    public string CancelUrl { get; set; }

    /// <summary>
    /// The URL to rerun the workflow run.
    /// </summary>
    /// <value>The URL to rerun the workflow run.</value>
    [DataMember(Name="rerun_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rerun_url")]
    public string RerunUrl { get; set; }

    /// <summary>
    /// The URL to the previous attempted run of this workflow, if one exists.
    /// </summary>
    /// <value>The URL to the previous attempted run of this workflow, if one exists.</value>
    [DataMember(Name="previous_attempt_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previous_attempt_url")]
    public string PreviousAttemptUrl { get; set; }

    /// <summary>
    /// The URL to the workflow.
    /// </summary>
    /// <value>The URL to the workflow.</value>
    [DataMember(Name="workflow_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workflow_url")]
    public string WorkflowUrl { get; set; }

    /// <summary>
    /// Gets or Sets HeadCommit
    /// </summary>
    [DataMember(Name="head_commit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "head_commit")]
    public SimpleCommit HeadCommit { get; set; }

    /// <summary>
    /// Gets or Sets Repository
    /// </summary>
    [DataMember(Name="repository", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository")]
    public MinimalRepository Repository { get; set; }

    /// <summary>
    /// Gets or Sets HeadRepository
    /// </summary>
    [DataMember(Name="head_repository", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "head_repository")]
    public MinimalRepository HeadRepository { get; set; }

    /// <summary>
    /// Gets or Sets HeadRepositoryId
    /// </summary>
    [DataMember(Name="head_repository_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "head_repository_id")]
    public int? HeadRepositoryId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WorkflowRun {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  CheckSuiteId: ").Append(CheckSuiteId).Append("\n");
      sb.Append("  CheckSuiteNodeId: ").Append(CheckSuiteNodeId).Append("\n");
      sb.Append("  HeadBranch: ").Append(HeadBranch).Append("\n");
      sb.Append("  HeadSha: ").Append(HeadSha).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  RunNumber: ").Append(RunNumber).Append("\n");
      sb.Append("  RunAttempt: ").Append(RunAttempt).Append("\n");
      sb.Append("  ReferencedWorkflows: ").Append(ReferencedWorkflows).Append("\n");
      sb.Append("  Event: ").Append(Event).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Conclusion: ").Append(Conclusion).Append("\n");
      sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  PullRequests: ").Append(PullRequests).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Actor: ").Append(Actor).Append("\n");
      sb.Append("  TriggeringActor: ").Append(TriggeringActor).Append("\n");
      sb.Append("  RunStartedAt: ").Append(RunStartedAt).Append("\n");
      sb.Append("  JobsUrl: ").Append(JobsUrl).Append("\n");
      sb.Append("  LogsUrl: ").Append(LogsUrl).Append("\n");
      sb.Append("  CheckSuiteUrl: ").Append(CheckSuiteUrl).Append("\n");
      sb.Append("  ArtifactsUrl: ").Append(ArtifactsUrl).Append("\n");
      sb.Append("  CancelUrl: ").Append(CancelUrl).Append("\n");
      sb.Append("  RerunUrl: ").Append(RerunUrl).Append("\n");
      sb.Append("  PreviousAttemptUrl: ").Append(PreviousAttemptUrl).Append("\n");
      sb.Append("  WorkflowUrl: ").Append(WorkflowUrl).Append("\n");
      sb.Append("  HeadCommit: ").Append(HeadCommit).Append("\n");
      sb.Append("  Repository: ").Append(Repository).Append("\n");
      sb.Append("  HeadRepository: ").Append(HeadRepository).Append("\n");
      sb.Append("  HeadRepositoryId: ").Append(HeadRepositoryId).Append("\n");
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
