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
  public class EnterpriseAdminGetAllowedActionsEnterprise200Response {
    /// <summary>
    /// Whether GitHub-owned actions are allowed. For example, this includes the actions in the `actions` organization.
    /// </summary>
    /// <value>Whether GitHub-owned actions are allowed. For example, this includes the actions in the `actions` organization.</value>
    [DataMember(Name="github_owned_allowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "github_owned_allowed")]
    public bool? GithubOwnedAllowed { get; set; }

    /// <summary>
    /// Whether actions from GitHub Marketplace verified creators are allowed. Set to `true` to allow all actions by GitHub Marketplace verified creators.
    /// </summary>
    /// <value>Whether actions from GitHub Marketplace verified creators are allowed. Set to `true` to allow all actions by GitHub Marketplace verified creators.</value>
    [DataMember(Name="verified_allowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verified_allowed")]
    public bool? VerifiedAllowed { get; set; }

    /// <summary>
    /// Specifies a list of string-matching patterns to allow specific action(s) and reusable workflow(s). Wildcards, tags, and SHAs are allowed. For example, `monalisa/octocat@*`, `monalisa/octocat@v2`, `monalisa/_*`.\"
    /// </summary>
    /// <value>Specifies a list of string-matching patterns to allow specific action(s) and reusable workflow(s). Wildcards, tags, and SHAs are allowed. For example, `monalisa/octocat@*`, `monalisa/octocat@v2`, `monalisa/_*`.\"</value>
    [DataMember(Name="patterns_allowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "patterns_allowed")]
    public List<string> PatternsAllowed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EnterpriseAdminGetAllowedActionsEnterprise200Response {\n");
      sb.Append("  GithubOwnedAllowed: ").Append(GithubOwnedAllowed).Append("\n");
      sb.Append("  VerifiedAllowed: ").Append(VerifiedAllowed).Append("\n");
      sb.Append("  PatternsAllowed: ").Append(PatternsAllowed).Append("\n");
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
