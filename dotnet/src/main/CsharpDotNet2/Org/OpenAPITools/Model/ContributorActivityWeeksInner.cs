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
  public class ContributorActivityWeeksInner {
    /// <summary>
    /// Gets or Sets W
    /// </summary>
    [DataMember(Name="w", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "w")]
    public int? W { get; set; }

    /// <summary>
    /// Gets or Sets A
    /// </summary>
    [DataMember(Name="a", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "a")]
    public int? A { get; set; }

    /// <summary>
    /// Gets or Sets D
    /// </summary>
    [DataMember(Name="d", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "d")]
    public int? D { get; set; }

    /// <summary>
    /// Gets or Sets C
    /// </summary>
    [DataMember(Name="c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "c")]
    public int? C { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ContributorActivityWeeksInner {\n");
      sb.Append("  W: ").Append(W).Append("\n");
      sb.Append("  A: ").Append(A).Append("\n");
      sb.Append("  D: ").Append(D).Append("\n");
      sb.Append("  C: ").Append(C).Append("\n");
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
