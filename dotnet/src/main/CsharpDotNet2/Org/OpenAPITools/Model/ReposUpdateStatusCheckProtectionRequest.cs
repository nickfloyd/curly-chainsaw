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
  public class ReposUpdateStatusCheckProtectionRequest {
    /// <summary>
    /// Require branches to be up to date before merging.
    /// </summary>
    /// <value>Require branches to be up to date before merging.</value>
    [DataMember(Name="strict", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "strict")]
    public bool? Strict { get; set; }

    /// <summary>
    /// **Deprecated**: The list of status checks to require in order to merge into this branch. If any of these checks have recently been set by a particular GitHub App, they will be required to come from that app in future for the branch to merge. Use `checks` instead of `contexts` for more fine-grained control. 
    /// </summary>
    /// <value>**Deprecated**: The list of status checks to require in order to merge into this branch. If any of these checks have recently been set by a particular GitHub App, they will be required to come from that app in future for the branch to merge. Use `checks` instead of `contexts` for more fine-grained control. </value>
    [DataMember(Name="contexts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contexts")]
    [Obsolete]
    public List<string> Contexts { get; set; }

    /// <summary>
    /// The list of status checks to require in order to merge into this branch.
    /// </summary>
    /// <value>The list of status checks to require in order to merge into this branch.</value>
    [DataMember(Name="checks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checks")]
    public List<ReposUpdateBranchProtectionRequestRequiredStatusChecksChecksInner> Checks { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposUpdateStatusCheckProtectionRequest {\n");
      sb.Append("  Strict: ").Append(Strict).Append("\n");
      sb.Append("  Contexts: ").Append(Contexts).Append("\n");
      sb.Append("  Checks: ").Append(Checks).Append("\n");
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
