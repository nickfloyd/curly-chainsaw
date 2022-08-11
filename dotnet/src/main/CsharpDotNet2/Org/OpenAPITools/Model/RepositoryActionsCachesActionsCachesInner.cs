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
  public class RepositoryActionsCachesActionsCachesInner {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Ref
    /// </summary>
    [DataMember(Name="ref", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ref")]
    public string Ref { get; set; }

    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// Gets or Sets _Version
    /// </summary>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string _Version { get; set; }

    /// <summary>
    /// Gets or Sets LastAccessedAt
    /// </summary>
    [DataMember(Name="last_accessed_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_accessed_at")]
    public DateTime? LastAccessedAt { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets SizeInBytes
    /// </summary>
    [DataMember(Name="size_in_bytes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size_in_bytes")]
    public int? SizeInBytes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RepositoryActionsCachesActionsCachesInner {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Ref: ").Append(Ref).Append("\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  _Version: ").Append(_Version).Append("\n");
      sb.Append("  LastAccessedAt: ").Append(LastAccessedAt).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  SizeInBytes: ").Append(SizeInBytes).Append("\n");
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
