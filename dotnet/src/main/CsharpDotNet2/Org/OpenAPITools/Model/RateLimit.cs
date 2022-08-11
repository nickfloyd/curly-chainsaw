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
  public class RateLimit {
    /// <summary>
    /// Gets or Sets Limit
    /// </summary>
    [DataMember(Name="limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Gets or Sets Remaining
    /// </summary>
    [DataMember(Name="remaining", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remaining")]
    public int? Remaining { get; set; }

    /// <summary>
    /// Gets or Sets Reset
    /// </summary>
    [DataMember(Name="reset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reset")]
    public int? Reset { get; set; }

    /// <summary>
    /// Gets or Sets Used
    /// </summary>
    [DataMember(Name="used", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "used")]
    public int? Used { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RateLimit {\n");
      sb.Append("  Limit: ").Append(Limit).Append("\n");
      sb.Append("  Remaining: ").Append(Remaining).Append("\n");
      sb.Append("  Reset: ").Append(Reset).Append("\n");
      sb.Append("  Used: ").Append(Used).Append("\n");
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
