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
  public class ActionsGetGithubActionsPermissionsOrganization200Response {
    /// <summary>
    /// The policy that controls the repositories in the organization that are allowed to run GitHub Actions.
    /// </summary>
    /// <value>The policy that controls the repositories in the organization that are allowed to run GitHub Actions.</value>
    [DataMember(Name="enabled_repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled_repositories")]
    public string EnabledRepositories { get; set; }

    /// <summary>
    /// The API URL to use to get or set the selected repositories that are allowed to run GitHub Actions, when `enabled_repositories` is set to `selected`.
    /// </summary>
    /// <value>The API URL to use to get or set the selected repositories that are allowed to run GitHub Actions, when `enabled_repositories` is set to `selected`.</value>
    [DataMember(Name="selected_repositories_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selected_repositories_url")]
    public string SelectedRepositoriesUrl { get; set; }

    /// <summary>
    /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
    /// </summary>
    /// <value>The permissions policy that controls the actions and reusable workflows that are allowed to run.</value>
    [DataMember(Name="allowed_actions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowed_actions")]
    public string AllowedActions { get; set; }

    /// <summary>
    /// The API URL to use to get or set the actions and reusable workflows that are allowed to run, when `allowed_actions` is set to `selected`.
    /// </summary>
    /// <value>The API URL to use to get or set the actions and reusable workflows that are allowed to run, when `allowed_actions` is set to `selected`.</value>
    [DataMember(Name="selected_actions_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selected_actions_url")]
    public string SelectedActionsUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActionsGetGithubActionsPermissionsOrganization200Response {\n");
      sb.Append("  EnabledRepositories: ").Append(EnabledRepositories).Append("\n");
      sb.Append("  SelectedRepositoriesUrl: ").Append(SelectedRepositoriesUrl).Append("\n");
      sb.Append("  AllowedActions: ").Append(AllowedActions).Append("\n");
      sb.Append("  SelectedActionsUrl: ").Append(SelectedActionsUrl).Append("\n");
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
