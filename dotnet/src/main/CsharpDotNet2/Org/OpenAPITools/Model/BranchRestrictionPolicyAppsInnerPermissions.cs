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
  public class BranchRestrictionPolicyAppsInnerPermissions {
    /// <summary>
    /// Gets or Sets Metadata
    /// </summary>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public string Metadata { get; set; }

    /// <summary>
    /// Gets or Sets Contents
    /// </summary>
    [DataMember(Name="contents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contents")]
    public string Contents { get; set; }

    /// <summary>
    /// Gets or Sets Issues
    /// </summary>
    [DataMember(Name="issues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issues")]
    public string Issues { get; set; }

    /// <summary>
    /// Gets or Sets SingleFile
    /// </summary>
    [DataMember(Name="single_file", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "single_file")]
    public string SingleFile { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BranchRestrictionPolicyAppsInnerPermissions {\n");
      sb.Append("  Metadata: ").Append(Metadata).Append("\n");
      sb.Append("  Contents: ").Append(Contents).Append("\n");
      sb.Append("  Issues: ").Append(Issues).Append("\n");
      sb.Append("  SingleFile: ").Append(SingleFile).Append("\n");
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
