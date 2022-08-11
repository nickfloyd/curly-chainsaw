using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Metadata for a Git tag
  /// </summary>
  [DataContract]
  public class GitTag {
    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }

    /// <summary>
    /// Name of the tag
    /// </summary>
    /// <value>Name of the tag</value>
    [DataMember(Name="tag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tag")]
    public string Tag { get; set; }

    /// <summary>
    /// Gets or Sets Sha
    /// </summary>
    [DataMember(Name="sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sha")]
    public string Sha { get; set; }

    /// <summary>
    /// URL for the tag
    /// </summary>
    /// <value>URL for the tag</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Message describing the purpose of the tag
    /// </summary>
    /// <value>Message describing the purpose of the tag</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets Tagger
    /// </summary>
    [DataMember(Name="tagger", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tagger")]
    public GitTagTagger Tagger { get; set; }

    /// <summary>
    /// Gets or Sets Object
    /// </summary>
    [DataMember(Name="object", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "object")]
    public GitTagObject Object { get; set; }

    /// <summary>
    /// Gets or Sets Verification
    /// </summary>
    [DataMember(Name="verification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verification")]
    public Verification Verification { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GitTag {\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  Tag: ").Append(Tag).Append("\n");
      sb.Append("  Sha: ").Append(Sha).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Tagger: ").Append(Tagger).Append("\n");
      sb.Append("  Object: ").Append(Object).Append("\n");
      sb.Append("  Verification: ").Append(Verification).Append("\n");
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
