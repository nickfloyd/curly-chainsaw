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
  public class ReposUpdateBranchProtectionRequestRequiredStatusChecksChecksInner {
    /// <summary>
    /// The name of the required check
    /// </summary>
    /// <value>The name of the required check</value>
    [DataMember(Name="context", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "context")]
    public string Context { get; set; }

    /// <summary>
    /// The ID of the GitHub App that must provide this check. Omit this field to automatically select the GitHub App that has recently provided this check, or any app if it was not set by a GitHub App. Pass -1 to explicitly allow any app to set the status.
    /// </summary>
    /// <value>The ID of the GitHub App that must provide this check. Omit this field to automatically select the GitHub App that has recently provided this check, or any app if it was not set by a GitHub App. Pass -1 to explicitly allow any app to set the status.</value>
    [DataMember(Name="app_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "app_id")]
    public int? AppId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposUpdateBranchProtectionRequestRequiredStatusChecksChecksInner {\n");
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
