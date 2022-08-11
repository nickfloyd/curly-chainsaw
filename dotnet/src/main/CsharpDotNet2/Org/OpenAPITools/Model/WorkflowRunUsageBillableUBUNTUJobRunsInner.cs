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
  public class WorkflowRunUsageBillableUBUNTUJobRunsInner {
    /// <summary>
    /// Gets or Sets JobId
    /// </summary>
    [DataMember(Name="job_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "job_id")]
    public int? JobId { get; set; }

    /// <summary>
    /// Gets or Sets DurationMs
    /// </summary>
    [DataMember(Name="duration_ms", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration_ms")]
    public int? DurationMs { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WorkflowRunUsageBillableUBUNTUJobRunsInner {\n");
      sb.Append("  JobId: ").Append(JobId).Append("\n");
      sb.Append("  DurationMs: ").Append(DurationMs).Append("\n");
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
