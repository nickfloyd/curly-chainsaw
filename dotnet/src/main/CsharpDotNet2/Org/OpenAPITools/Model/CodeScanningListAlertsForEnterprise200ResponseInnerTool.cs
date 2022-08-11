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
  public class CodeScanningListAlertsForEnterprise200ResponseInnerTool {
    /// <summary>
    /// The name of the tool used to generate the code scanning analysis.
    /// </summary>
    /// <value>The name of the tool used to generate the code scanning analysis.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The version of the tool used to generate the code scanning analysis.
    /// </summary>
    /// <value>The version of the tool used to generate the code scanning analysis.</value>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string _Version { get; set; }

    /// <summary>
    /// The GUID of the tool used to generate the code scanning analysis, if provided in the uploaded SARIF data.
    /// </summary>
    /// <value>The GUID of the tool used to generate the code scanning analysis, if provided in the uploaded SARIF data.</value>
    [DataMember(Name="guid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guid")]
    public string Guid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CodeScanningListAlertsForEnterprise200ResponseInnerTool {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  _Version: ").Append(_Version).Append("\n");
      sb.Append("  Guid: ").Append(Guid).Append("\n");
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
