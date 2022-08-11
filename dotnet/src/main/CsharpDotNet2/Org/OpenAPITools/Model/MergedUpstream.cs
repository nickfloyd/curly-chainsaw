using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Results of a successful merge upstream request
  /// </summary>
  [DataContract]
  public class MergedUpstream {
    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets MergeType
    /// </summary>
    [DataMember(Name="merge_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merge_type")]
    public string MergeType { get; set; }

    /// <summary>
    /// Gets or Sets BaseBranch
    /// </summary>
    [DataMember(Name="base_branch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "base_branch")]
    public string BaseBranch { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MergedUpstream {\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  MergeType: ").Append(MergeType).Append("\n");
      sb.Append("  BaseBranch: ").Append(BaseBranch).Append("\n");
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
