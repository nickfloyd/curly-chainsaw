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
  public class WorkflowRunUsageBillable {
    /// <summary>
    /// Gets or Sets UBUNTU
    /// </summary>
    [DataMember(Name="UBUNTU", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UBUNTU")]
    public WorkflowRunUsageBillableUBUNTU UBUNTU { get; set; }

    /// <summary>
    /// Gets or Sets MACOS
    /// </summary>
    [DataMember(Name="MACOS", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MACOS")]
    public WorkflowRunUsageBillableUBUNTU MACOS { get; set; }

    /// <summary>
    /// Gets or Sets WINDOWS
    /// </summary>
    [DataMember(Name="WINDOWS", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WINDOWS")]
    public WorkflowRunUsageBillableUBUNTU WINDOWS { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WorkflowRunUsageBillable {\n");
      sb.Append("  UBUNTU: ").Append(UBUNTU).Append("\n");
      sb.Append("  MACOS: ").Append(MACOS).Append("\n");
      sb.Append("  WINDOWS: ").Append(WINDOWS).Append("\n");
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
