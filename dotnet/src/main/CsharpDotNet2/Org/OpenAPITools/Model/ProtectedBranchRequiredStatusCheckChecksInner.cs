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
  public class ProtectedBranchRequiredStatusCheckChecksInner {
    /// <summary>
    /// Gets or Sets Context
    /// </summary>
    [DataMember(Name="context", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "context")]
    public string Context { get; set; }

    /// <summary>
    /// Gets or Sets AppId
    /// </summary>
    [DataMember(Name="app_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "app_id")]
    public int? AppId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProtectedBranchRequiredStatusCheckChecksInner {\n");
      sb.Append("  Context: ").Append(Context).Append("\n");
      sb.Append("  AppId: ").Append(AppId).Append("\n");
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
