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
  public class ReposCreateCommitStatusRequest {
    /// <summary>
    /// The state of the status.
    /// </summary>
    /// <value>The state of the status.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// The target URL to associate with this status. This URL will be linked from the GitHub UI to allow users to easily see the source of the status.   For example, if your continuous integration system is posting build status, you would want to provide the deep link for the build output for this specific SHA:   `http://ci.example.com/user/repo/build/sha`
    /// </summary>
    /// <value>The target URL to associate with this status. This URL will be linked from the GitHub UI to allow users to easily see the source of the status.   For example, if your continuous integration system is posting build status, you would want to provide the deep link for the build output for this specific SHA:   `http://ci.example.com/user/repo/build/sha`</value>
    [DataMember(Name="target_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target_url")]
    public string TargetUrl { get; set; }

    /// <summary>
    /// A short description of the status.
    /// </summary>
    /// <value>A short description of the status.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// A string label to differentiate this status from the status of other systems. This field is case-insensitive.
    /// </summary>
    /// <value>A string label to differentiate this status from the status of other systems. This field is case-insensitive.</value>
    [DataMember(Name="context", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "context")]
    public string Context { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposCreateCommitStatusRequest {\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  TargetUrl: ").Append(TargetUrl).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Context: ").Append(Context).Append("\n");
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
