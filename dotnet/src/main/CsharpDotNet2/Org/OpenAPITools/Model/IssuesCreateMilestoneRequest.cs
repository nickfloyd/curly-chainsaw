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
  public class IssuesCreateMilestoneRequest {
    /// <summary>
    /// The title of the milestone.
    /// </summary>
    /// <value>The title of the milestone.</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// The state of the milestone. Either `open` or `closed`.
    /// </summary>
    /// <value>The state of the milestone. Either `open` or `closed`.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// A description of the milestone.
    /// </summary>
    /// <value>A description of the milestone.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The milestone due date. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
    /// </summary>
    /// <value>The milestone due date. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.</value>
    [DataMember(Name="due_on", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "due_on")]
    public DateTime? DueOn { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssuesCreateMilestoneRequest {\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DueOn: ").Append(DueOn).Append("\n");
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
