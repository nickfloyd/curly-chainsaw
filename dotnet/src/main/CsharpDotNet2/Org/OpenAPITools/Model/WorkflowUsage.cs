using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Workflow Usage
  /// </summary>
  [DataContract]
  public class WorkflowUsage {
    /// <summary>
    /// Gets or Sets Billable
    /// </summary>
    [DataMember(Name="billable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billable")]
    public WorkflowUsageBillable Billable { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WorkflowUsage {\n");
      sb.Append("  Billable: ").Append(Billable).Append("\n");
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
