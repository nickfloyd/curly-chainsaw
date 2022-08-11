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
  public class EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response {
    /// <summary>
    /// The policy that controls the organizations in the enterprise that are allowed to run GitHub Actions.
    /// </summary>
    /// <value>The policy that controls the organizations in the enterprise that are allowed to run GitHub Actions.</value>
    [DataMember(Name="enabled_organizations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled_organizations")]
    public string EnabledOrganizations { get; set; }

    /// <summary>
    /// The API URL to use to get or set the selected organizations that are allowed to run GitHub Actions, when `enabled_organizations` is set to `selected`.
    /// </summary>
    /// <value>The API URL to use to get or set the selected organizations that are allowed to run GitHub Actions, when `enabled_organizations` is set to `selected`.</value>
    [DataMember(Name="selected_organizations_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selected_organizations_url")]
    public string SelectedOrganizationsUrl { get; set; }

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
      sb.Append("class EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response {\n");
      sb.Append("  EnabledOrganizations: ").Append(EnabledOrganizations).Append("\n");
      sb.Append("  SelectedOrganizationsUrl: ").Append(SelectedOrganizationsUrl).Append("\n");
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
