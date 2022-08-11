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
  public class Traffic {
    /// <summary>
    /// Gets or Sets Timestamp
    /// </summary>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public DateTime? Timestamp { get; set; }

    /// <summary>
    /// Gets or Sets Uniques
    /// </summary>
    [DataMember(Name="uniques", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uniques")]
    public int? Uniques { get; set; }

    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Traffic {\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  Uniques: ").Append(Uniques).Append("\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
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
