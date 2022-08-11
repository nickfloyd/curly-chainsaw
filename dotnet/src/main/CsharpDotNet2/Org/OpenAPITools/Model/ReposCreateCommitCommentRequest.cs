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
  public class ReposCreateCommitCommentRequest {
    /// <summary>
    /// The contents of the comment.
    /// </summary>
    /// <value>The contents of the comment.</value>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public string Body { get; set; }

    /// <summary>
    /// Relative path of the file to comment on.
    /// </summary>
    /// <value>Relative path of the file to comment on.</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// Line index in the diff to comment on.
    /// </summary>
    /// <value>Line index in the diff to comment on.</value>
    [DataMember(Name="position", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "position")]
    public int? Position { get; set; }

    /// <summary>
    /// **Deprecated**. Use **position** parameter instead. Line number in the file to comment on.
    /// </summary>
    /// <value>**Deprecated**. Use **position** parameter instead. Line number in the file to comment on.</value>
    [DataMember(Name="line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "line")]
    public int? Line { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposCreateCommitCommentRequest {\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  Position: ").Append(Position).Append("\n");
      sb.Append("  Line: ").Append(Line).Append("\n");
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
