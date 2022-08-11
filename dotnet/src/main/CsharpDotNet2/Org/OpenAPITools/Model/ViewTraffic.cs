using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// View Traffic
  /// </summary>
  [DataContract]
  public class ViewTraffic {
    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// Gets or Sets Uniques
    /// </summary>
    [DataMember(Name="uniques", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uniques")]
    public int? Uniques { get; set; }

    /// <summary>
    /// Gets or Sets Views
    /// </summary>
    [DataMember(Name="views", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "views")]
    public List<Traffic> Views { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ViewTraffic {\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  Uniques: ").Append(Uniques).Append("\n");
      sb.Append("  Views: ").Append(Views).Append("\n");
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
