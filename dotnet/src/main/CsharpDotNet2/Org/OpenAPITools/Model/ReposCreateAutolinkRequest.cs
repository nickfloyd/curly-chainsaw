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
  public class ReposCreateAutolinkRequest {
    /// <summary>
    /// The prefix appended by alphanumeric characters will generate a link any time it is found in an issue, pull request, or commit.
    /// </summary>
    /// <value>The prefix appended by alphanumeric characters will generate a link any time it is found in an issue, pull request, or commit.</value>
    [DataMember(Name="key_prefix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key_prefix")]
    public string KeyPrefix { get; set; }

    /// <summary>
    /// The URL must contain `<num>` for the reference number. `<num>` matches alphanumeric characters `A-Z` (case insensitive), `0-9`, and `-`.
    /// </summary>
    /// <value>The URL must contain `<num>` for the reference number. `<num>` matches alphanumeric characters `A-Z` (case insensitive), `0-9`, and `-`.</value>
    [DataMember(Name="url_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url_template")]
    public string UrlTemplate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposCreateAutolinkRequest {\n");
      sb.Append("  KeyPrefix: ").Append(KeyPrefix).Append("\n");
      sb.Append("  UrlTemplate: ").Append(UrlTemplate).Append("\n");
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
