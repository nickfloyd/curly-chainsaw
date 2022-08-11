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
  public class PullsCreateReviewRequestCommentsInner {
    /// <summary>
    /// The relative path to the file that necessitates a review comment.
    /// </summary>
    /// <value>The relative path to the file that necessitates a review comment.</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// The position in the diff where you want to add a review comment. Note this value is not the same as the line number in the file. For help finding the position value, read the note below.
    /// </summary>
    /// <value>The position in the diff where you want to add a review comment. Note this value is not the same as the line number in the file. For help finding the position value, read the note below.</value>
    [DataMember(Name="position", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "position")]
    public int? Position { get; set; }

    /// <summary>
    /// Text of the review comment.
    /// </summary>
    /// <value>Text of the review comment.</value>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public string Body { get; set; }

    /// <summary>
    /// Gets or Sets Line
    /// </summary>
    [DataMember(Name="line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "line")]
    public int? Line { get; set; }

    /// <summary>
    /// Gets or Sets Side
    /// </summary>
    [DataMember(Name="side", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "side")]
    public string Side { get; set; }

    /// <summary>
    /// Gets or Sets StartLine
    /// </summary>
    [DataMember(Name="start_line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_line")]
    public int? StartLine { get; set; }

    /// <summary>
    /// Gets or Sets StartSide
    /// </summary>
    [DataMember(Name="start_side", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_side")]
    public string StartSide { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PullsCreateReviewRequestCommentsInner {\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  Position: ").Append(Position).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  Line: ").Append(Line).Append("\n");
      sb.Append("  Side: ").Append(Side).Append("\n");
      sb.Append("  StartLine: ").Append(StartLine).Append("\n");
      sb.Append("  StartSide: ").Append(StartSide).Append("\n");
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
