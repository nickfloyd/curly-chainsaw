using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Commit Activity
  /// </summary>
  [DataContract]
  public class CommitActivity {
    /// <summary>
    /// Gets or Sets Days
    /// </summary>
    [DataMember(Name="days", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "days")]
    public List<int?> Days { get; set; }

    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public int? Total { get; set; }

    /// <summary>
    /// Gets or Sets Week
    /// </summary>
    [DataMember(Name="week", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "week")]
    public int? Week { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CommitActivity {\n");
      sb.Append("  Days: ").Append(Days).Append("\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
      sb.Append("  Week: ").Append(Week).Append("\n");
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
