using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The source branch and directory used to publish your Pages site.
  /// </summary>
  [DataContract]
  public class ReposCreatePagesSiteRequest {
    /// <summary>
    /// The process in which the Page will be built. Possible values are `\"legacy\"` and `\"workflow\"`.
    /// </summary>
    /// <value>The process in which the Page will be built. Possible values are `\"legacy\"` and `\"workflow\"`.</value>
    [DataMember(Name="build_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "build_type")]
    public string BuildType { get; set; }

    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public ReposCreatePagesSiteRequestSource Source { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposCreatePagesSiteRequest {\n");
      sb.Append("  BuildType: ").Append(BuildType).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
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
