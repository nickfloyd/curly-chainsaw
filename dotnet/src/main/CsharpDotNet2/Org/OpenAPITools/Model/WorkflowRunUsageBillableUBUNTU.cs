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
  public class WorkflowRunUsageBillableUBUNTU {
    /// <summary>
    /// Gets or Sets TotalMs
    /// </summary>
    [DataMember(Name="total_ms", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_ms")]
    public int? TotalMs { get; set; }

    /// <summary>
    /// Gets or Sets Jobs
    /// </summary>
    [DataMember(Name="jobs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs")]
    public int? Jobs { get; set; }

    /// <summary>
    /// Gets or Sets JobRuns
    /// </summary>
    [DataMember(Name="job_runs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "job_runs")]
    public List<WorkflowRunUsageBillableUBUNTUJobRunsInner> JobRuns { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WorkflowRunUsageBillableUBUNTU {\n");
      sb.Append("  TotalMs: ").Append(TotalMs).Append("\n");
      sb.Append("  Jobs: ").Append(Jobs).Append("\n");
      sb.Append("  JobRuns: ").Append(JobRuns).Append("\n");
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
