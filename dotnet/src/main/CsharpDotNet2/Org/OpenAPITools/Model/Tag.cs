using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Tag
  /// </summary>
  [DataContract]
  public class Tag {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Commit
    /// </summary>
    [DataMember(Name="commit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit")]
    public ShortBranchCommit Commit { get; set; }

    /// <summary>
    /// Gets or Sets ZipballUrl
    /// </summary>
    [DataMember(Name="zipball_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zipball_url")]
    public string ZipballUrl { get; set; }

    /// <summary>
    /// Gets or Sets TarballUrl
    /// </summary>
    [DataMember(Name="tarball_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tarball_url")]
    public string TarballUrl { get; set; }

    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Tag {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Commit: ").Append(Commit).Append("\n");
      sb.Append("  ZipballUrl: ").Append(ZipballUrl).Append("\n");
      sb.Append("  TarballUrl: ").Append(TarballUrl).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
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
