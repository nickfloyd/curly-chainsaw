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
  public class ActionsReRunJobForWorkflowRunRequest {
    /// <summary>
    /// Whether to enable debug logging for the re-run.
    /// </summary>
    /// <value>Whether to enable debug logging for the re-run.</value>
    [DataMember(Name="enable_debug_logging", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enable_debug_logging")]
    public bool? EnableDebugLogging { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActionsReRunJobForWorkflowRunRequest {\n");
      sb.Append("  EnableDebugLogging: ").Append(EnableDebugLogging).Append("\n");
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
