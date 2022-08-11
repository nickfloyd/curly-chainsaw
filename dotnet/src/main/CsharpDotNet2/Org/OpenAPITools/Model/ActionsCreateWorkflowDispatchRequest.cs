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
  public class ActionsCreateWorkflowDispatchRequest {
    /// <summary>
    /// The git reference for the workflow. The reference can be a branch or tag name.
    /// </summary>
    /// <value>The git reference for the workflow. The reference can be a branch or tag name.</value>
    [DataMember(Name="ref", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ref")]
    public string Ref { get; set; }

    /// <summary>
    /// Input keys and values configured in the workflow file. The maximum number of properties is 10. Any default properties configured in the workflow file will be used when `inputs` are omitted.
    /// </summary>
    /// <value>Input keys and values configured in the workflow file. The maximum number of properties is 10. Any default properties configured in the workflow file will be used when `inputs` are omitted.</value>
    [DataMember(Name="inputs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inputs")]
    public Dictionary<string, string> Inputs { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActionsCreateWorkflowDispatchRequest {\n");
      sb.Append("  Ref: ").Append(Ref).Append("\n");
      sb.Append("  Inputs: ").Append(Inputs).Append("\n");
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
