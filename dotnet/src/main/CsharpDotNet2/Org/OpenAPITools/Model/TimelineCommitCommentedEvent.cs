using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Timeline Commit Commented Event
  /// </summary>
  [DataContract]
  public class TimelineCommitCommentedEvent {
    /// <summary>
    /// Gets or Sets Event
    /// </summary>
    [DataMember(Name="event", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event")]
    public string Event { get; set; }

    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }

    /// <summary>
    /// Gets or Sets CommitId
    /// </summary>
    [DataMember(Name="commit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit_id")]
    public string CommitId { get; set; }

    /// <summary>
    /// Gets or Sets Comments
    /// </summary>
    [DataMember(Name="comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments")]
    public List<CommitComment> Comments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TimelineCommitCommentedEvent {\n");
      sb.Append("  Event: ").Append(Event).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  CommitId: ").Append(CommitId).Append("\n");
      sb.Append("  Comments: ").Append(Comments).Append("\n");
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
