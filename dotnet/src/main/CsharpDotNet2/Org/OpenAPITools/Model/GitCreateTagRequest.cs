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
  public class GitCreateTagRequest {
    /// <summary>
    /// The tag's name. This is typically a version (e.g., \"v0.0.1\").
    /// </summary>
    /// <value>The tag's name. This is typically a version (e.g., \"v0.0.1\").</value>
    [DataMember(Name="tag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tag")]
    public string Tag { get; set; }

    /// <summary>
    /// The tag message.
    /// </summary>
    /// <value>The tag message.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// The SHA of the git object this is tagging.
    /// </summary>
    /// <value>The SHA of the git object this is tagging.</value>
    [DataMember(Name="object", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "object")]
    public string Object { get; set; }

    /// <summary>
    /// The type of the object we're tagging. Normally this is a `commit` but it can also be a `tree` or a `blob`.
    /// </summary>
    /// <value>The type of the object we're tagging. Normally this is a `commit` but it can also be a `tree` or a `blob`.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Tagger
    /// </summary>
    [DataMember(Name="tagger", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tagger")]
    public GitCreateTagRequestTagger Tagger { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GitCreateTagRequest {\n");
      sb.Append("  Tag: ").Append(Tag).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Object: ").Append(Object).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Tagger: ").Append(Tagger).Append("\n");
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
