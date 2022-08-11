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
  public class ReposCreatePagesSiteRequestSource {
    /// <summary>
    /// The repository branch used to publish your site's source files.
    /// </summary>
    /// <value>The repository branch used to publish your site's source files.</value>
    [DataMember(Name="branch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "branch")]
    public string Branch { get; set; }

    /// <summary>
    /// The repository directory that includes the source files for the Pages site. Allowed paths are `/` or `/docs`. Default: `/`
    /// </summary>
    /// <value>The repository directory that includes the source files for the Pages site. Allowed paths are `/` or `/docs`. Default: `/`</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposCreatePagesSiteRequestSource {\n");
      sb.Append("  Branch: ").Append(Branch).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
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
