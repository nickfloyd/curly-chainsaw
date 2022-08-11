using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Information of a job execution in a workflow run
  /// </summary>
  [DataContract]
  public class Job {
    /// <summary>
    /// The id of the job.
    /// </summary>
    /// <value>The id of the job.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The id of the associated workflow run.
    /// </summary>
    /// <value>The id of the associated workflow run.</value>
    [DataMember(Name="run_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "run_id")]
    public int? RunId { get; set; }

    /// <summary>
    /// Gets or Sets RunUrl
    /// </summary>
    [DataMember(Name="run_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "run_url")]
    public string RunUrl { get; set; }

    /// <summary>
    /// Attempt number of the associated workflow run, 1 for first attempt and higher if the workflow was re-run.
    /// </summary>
    /// <value>Attempt number of the associated workflow run, 1 for first attempt and higher if the workflow was re-run.</value>
    [DataMember(Name="run_attempt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "run_attempt")]
    public int? RunAttempt { get; set; }

    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }

    /// <summary>
    /// The SHA of the commit that is being run.
    /// </summary>
    /// <value>The SHA of the commit that is being run.</value>
    [DataMember(Name="head_sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "head_sha")]
    public string HeadSha { get; set; }

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
    /// The phase of the lifecycle that the job is currently in.
    /// </summary>
    /// <value>The phase of the lifecycle that the job is currently in.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The outcome of the job.
    /// </summary>
    /// <value>The outcome of the job.</value>
    [DataMember(Name="conclusion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conclusion")]
    public string Conclusion { get; set; }

    /// <summary>
    /// The time that the job started, in ISO 8601 format.
    /// </summary>
    /// <value>The time that the job started, in ISO 8601 format.</value>
    [DataMember(Name="started_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "started_at")]
    public DateTime? StartedAt { get; set; }

    /// <summary>
    /// The time that the job finished, in ISO 8601 format.
    /// </summary>
    /// <value>The time that the job finished, in ISO 8601 format.</value>
    [DataMember(Name="completed_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completed_at")]
    public DateTime? CompletedAt { get; set; }

    /// <summary>
    /// The name of the job.
    /// </summary>
    /// <value>The name of the job.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Steps in this job.
    /// </summary>
    /// <value>Steps in this job.</value>
    [DataMember(Name="steps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "steps")]
    public List<JobStepsInner> Steps { get; set; }

    /// <summary>
    /// Gets or Sets CheckRunUrl
    /// </summary>
    [DataMember(Name="check_run_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "check_run_url")]
    public string CheckRunUrl { get; set; }

    /// <summary>
    /// Labels for the workflow job. Specified by the \"runs_on\" attribute in the action's workflow file.
    /// </summary>
    /// <value>Labels for the workflow job. Specified by the \"runs_on\" attribute in the action's workflow file.</value>
    [DataMember(Name="labels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labels")]
    public List<string> Labels { get; set; }

    /// <summary>
    /// The ID of the runner to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)
    /// </summary>
    /// <value>The ID of the runner to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)</value>
    [DataMember(Name="runner_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runner_id")]
    public int? RunnerId { get; set; }

    /// <summary>
    /// The name of the runner to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)
    /// </summary>
    /// <value>The name of the runner to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)</value>
    [DataMember(Name="runner_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runner_name")]
    public string RunnerName { get; set; }

    /// <summary>
    /// The ID of the runner group to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)
    /// </summary>
    /// <value>The ID of the runner group to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)</value>
    [DataMember(Name="runner_group_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runner_group_id")]
    public int? RunnerGroupId { get; set; }

    /// <summary>
    /// The name of the runner group to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)
    /// </summary>
    /// <value>The name of the runner group to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)</value>
    [DataMember(Name="runner_group_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runner_group_name")]
    public string RunnerGroupName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Job {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  RunId: ").Append(RunId).Append("\n");
      sb.Append("  RunUrl: ").Append(RunUrl).Append("\n");
      sb.Append("  RunAttempt: ").Append(RunAttempt).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  HeadSha: ").Append(HeadSha).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Conclusion: ").Append(Conclusion).Append("\n");
      sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
      sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Steps: ").Append(Steps).Append("\n");
      sb.Append("  CheckRunUrl: ").Append(CheckRunUrl).Append("\n");
      sb.Append("  Labels: ").Append(Labels).Append("\n");
      sb.Append("  RunnerId: ").Append(RunnerId).Append("\n");
      sb.Append("  RunnerName: ").Append(RunnerName).Append("\n");
      sb.Append("  RunnerGroupId: ").Append(RunnerGroupId).Append("\n");
      sb.Append("  RunnerGroupName: ").Append(RunnerGroupName).Append("\n");
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
