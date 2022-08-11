using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Contributor Activity
  /// </summary>
  [DataContract]
  public class ContributorActivity {
    /// <summary>
    /// Gets or Sets Author
    /// </summary>
    [DataMember(Name="author", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "author")]
    public SimpleUser Author { get; set; }

    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public int? Total { get; set; }

    /// <summary>
    /// Gets or Sets Weeks
    /// </summary>
    [DataMember(Name="weeks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weeks")]
    public List<ContributorActivityWeeksInner> Weeks { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ContributorActivity {\n");
      sb.Append("  Author: ").Append(Author).Append("\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
      sb.Append("  Weeks: ").Append(Weeks).Append("\n");
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
