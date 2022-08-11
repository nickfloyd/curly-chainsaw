using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The hierarchy between files in a Git repository.
  /// </summary>
  [DataContract]
  public class GitTree {
    /// <summary>
    /// Gets or Sets Sha
    /// </summary>
    [DataMember(Name="sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sha")]
    public string Sha { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets Truncated
    /// </summary>
    [DataMember(Name="truncated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "truncated")]
    public bool? Truncated { get; set; }

    /// <summary>
    /// Objects specifying a tree structure
    /// </summary>
    /// <value>Objects specifying a tree structure</value>
    [DataMember(Name="tree", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tree")]
    public List<GitTreeTreeInner> Tree { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GitTree {\n");
      sb.Append("  Sha: ").Append(Sha).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Truncated: ").Append(Truncated).Append("\n");
      sb.Append("  Tree: ").Append(Tree).Append("\n");
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
