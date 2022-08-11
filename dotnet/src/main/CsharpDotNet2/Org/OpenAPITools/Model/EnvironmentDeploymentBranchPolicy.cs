using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The type of deployment branch policy for this environment. To allow all branches to deploy, set to &#x60;null&#x60;.
  /// </summary>
  [DataContract]
  public class EnvironmentDeploymentBranchPolicy {
    /// <summary>
    /// Whether only branches with branch protection rules can deploy to this environment. If `protected_branches` is `true`, `custom_branch_policies` must be `false`; if `protected_branches` is `false`, `custom_branch_policies` must be `true`.
    /// </summary>
    /// <value>Whether only branches with branch protection rules can deploy to this environment. If `protected_branches` is `true`, `custom_branch_policies` must be `false`; if `protected_branches` is `false`, `custom_branch_policies` must be `true`.</value>
    [DataMember(Name="protected_branches", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protected_branches")]
    public bool? ProtectedBranches { get; set; }

    /// <summary>
    /// Whether only branches that match the specified name patterns can deploy to this environment.  If `custom_branch_policies` is `true`, `protected_branches` must be `false`; if `custom_branch_policies` is `false`, `protected_branches` must be `true`.
    /// </summary>
    /// <value>Whether only branches that match the specified name patterns can deploy to this environment.  If `custom_branch_policies` is `true`, `protected_branches` must be `false`; if `custom_branch_policies` is `false`, `protected_branches` must be `true`.</value>
    [DataMember(Name="custom_branch_policies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_branch_policies")]
    public bool? CustomBranchPolicies { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EnvironmentDeploymentBranchPolicy {\n");
      sb.Append("  ProtectedBranches: ").Append(ProtectedBranches).Append("\n");
      sb.Append("  CustomBranchPolicies: ").Append(CustomBranchPolicies).Append("\n");
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
