using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Tag protection
  /// </summary>
  [DataContract]
  public class TagProtection {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedAt
    /// </summary>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public string UpdatedAt { get; set; }

    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets Pattern
    /// </summary>
    [DataMember(Name="pattern", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pattern")]
    public string Pattern { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TagProtection {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  Pattern: ").Append(Pattern).Append("\n");
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
