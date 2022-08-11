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
  public class GistHistoryChangeStatus {
    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public int? Total { get; set; }

    /// <summary>
    /// Gets or Sets Additions
    /// </summary>
    [DataMember(Name="additions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additions")]
    public int? Additions { get; set; }

    /// <summary>
    /// Gets or Sets Deletions
    /// </summary>
    [DataMember(Name="deletions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deletions")]
    public int? Deletions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GistHistoryChangeStatus {\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
      sb.Append("  Additions: ").Append(Additions).Append("\n");
      sb.Append("  Deletions: ").Append(Deletions).Append("\n");
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
