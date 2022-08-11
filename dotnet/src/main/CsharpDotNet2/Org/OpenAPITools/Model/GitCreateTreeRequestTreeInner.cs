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
  public class GitCreateTreeRequestTreeInner {
    /// <summary>
    /// The file referenced in the tree.
    /// </summary>
    /// <value>The file referenced in the tree.</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// The file mode; one of `100644` for file (blob), `100755` for executable (blob), `040000` for subdirectory (tree), `160000` for submodule (commit), or `120000` for a blob that specifies the path of a symlink.
    /// </summary>
    /// <value>The file mode; one of `100644` for file (blob), `100755` for executable (blob), `040000` for subdirectory (tree), `160000` for submodule (commit), or `120000` for a blob that specifies the path of a symlink.</value>
    [DataMember(Name="mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mode")]
    public string Mode { get; set; }

    /// <summary>
    /// Either `blob`, `tree`, or `commit`.
    /// </summary>
    /// <value>Either `blob`, `tree`, or `commit`.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The SHA1 checksum ID of the object in the tree. Also called `tree.sha`. If the value is `null` then the file will be deleted.      **Note:** Use either `tree.sha` or `content` to specify the contents of the entry. Using both `tree.sha` and `content` will return an error.
    /// </summary>
    /// <value>The SHA1 checksum ID of the object in the tree. Also called `tree.sha`. If the value is `null` then the file will be deleted.      **Note:** Use either `tree.sha` or `content` to specify the contents of the entry. Using both `tree.sha` and `content` will return an error.</value>
    [DataMember(Name="sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sha")]
    public string Sha { get; set; }

    /// <summary>
    /// The content you want this file to have. GitHub will write this blob out and use that SHA for this entry. Use either this, or `tree.sha`.      **Note:** Use either `tree.sha` or `content` to specify the contents of the entry. Using both `tree.sha` and `content` will return an error.
    /// </summary>
    /// <value>The content you want this file to have. GitHub will write this blob out and use that SHA for this entry. Use either this, or `tree.sha`.      **Note:** Use either `tree.sha` or `content` to specify the contents of the entry. Using both `tree.sha` and `content` will return an error.</value>
    [DataMember(Name="content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content")]
    public string Content { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GitCreateTreeRequestTreeInner {\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  Mode: ").Append(Mode).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Sha: ").Append(Sha).Append("\n");
      sb.Append("  Content: ").Append(Content).Append("\n");
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
