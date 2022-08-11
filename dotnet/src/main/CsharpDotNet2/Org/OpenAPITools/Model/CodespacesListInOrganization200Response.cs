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
  public class CodespacesListInOrganization200Response {
    /// <summary>
    /// Gets or Sets TotalCount
    /// </summary>
    [DataMember(Name="total_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_count")]
    public int? TotalCount { get; set; }

    /// <summary>
    /// Gets or Sets Codespaces
    /// </summary>
    [DataMember(Name="codespaces", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "codespaces")]
    public List<Codespace> Codespaces { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CodespacesListInOrganization200Response {\n");
      sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
      sb.Append("  Codespaces: ").Append(Codespaces).Append("\n");
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
