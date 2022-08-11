using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Workflow Run Usage
  /// </summary>
  [DataContract]
  public class WorkflowRunUsage {
    /// <summary>
    /// Gets or Sets Billable
    /// </summary>
    [DataMember(Name="billable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billable")]
    public WorkflowRunUsageBillable Billable { get; set; }

    /// <summary>
    /// Gets or Sets RunDurationMs
    /// </summary>
    [DataMember(Name="run_duration_ms", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "run_duration_ms")]
    public int? RunDurationMs { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WorkflowRunUsage {\n");
      sb.Append("  Billable: ").Append(Billable).Append("\n");
      sb.Append("  RunDurationMs: ").Append(RunDurationMs).Append("\n");
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
