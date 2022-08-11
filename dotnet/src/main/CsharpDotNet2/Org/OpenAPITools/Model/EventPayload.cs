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
  public class EventPayload {
    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    [DataMember(Name="action", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "action")]
    public string Action { get; set; }

    /// <summary>
    /// Gets or Sets Issue
    /// </summary>
    [DataMember(Name="issue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issue")]
    public Issue Issue { get; set; }

    /// <summary>
    /// Gets or Sets Comment
    /// </summary>
    [DataMember(Name="comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment")]
    public IssueComment Comment { get; set; }

    /// <summary>
    /// Gets or Sets Pages
    /// </summary>
    [DataMember(Name="pages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pages")]
    public List<EventPayloadPagesInner> Pages { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EventPayload {\n");
      sb.Append("  Action: ").Append(Action).Append("\n");
      sb.Append("  Issue: ").Append(Issue).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  Pages: ").Append(Pages).Append("\n");
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
