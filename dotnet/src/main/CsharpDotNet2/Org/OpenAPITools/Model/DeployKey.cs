using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// An SSH key granting access to a single repository.
  /// </summary>
  [DataContract]
  public class DeployKey {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets Verified
    /// </summary>
    [DataMember(Name="verified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verified")]
    public bool? Verified { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets ReadOnly
    /// </summary>
    [DataMember(Name="read_only", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "read_only")]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// Gets or Sets AddedBy
    /// </summary>
    [DataMember(Name="added_by", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "added_by")]
    public string AddedBy { get; set; }

    /// <summary>
    /// Gets or Sets LastUsed
    /// </summary>
    [DataMember(Name="last_used", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_used")]
    public string LastUsed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DeployKey {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Verified: ").Append(Verified).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
      sb.Append("  AddedBy: ").Append(AddedBy).Append("\n");
      sb.Append("  LastUsed: ").Append(LastUsed).Append("\n");
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
