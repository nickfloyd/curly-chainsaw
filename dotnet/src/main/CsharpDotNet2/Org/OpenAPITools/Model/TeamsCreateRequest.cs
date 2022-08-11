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
  public class TeamsCreateRequest {
    /// <summary>
    /// The name of the team.
    /// </summary>
    /// <value>The name of the team.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The description of the team.
    /// </summary>
    /// <value>The description of the team.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// List GitHub IDs for organization members who will become team maintainers.
    /// </summary>
    /// <value>List GitHub IDs for organization members who will become team maintainers.</value>
    [DataMember(Name="maintainers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maintainers")]
    public List<string> Maintainers { get; set; }

    /// <summary>
    /// The full name (e.g., \"organization-name/repository-name\") of repositories to add the team to.
    /// </summary>
    /// <value>The full name (e.g., \"organization-name/repository-name\") of repositories to add the team to.</value>
    [DataMember(Name="repo_names", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repo_names")]
    public List<string> RepoNames { get; set; }

    /// <summary>
    /// The level of privacy this team should have. The options are:   **For a non-nested team:**   \\* `secret` - only visible to organization owners and members of this team.   \\* `closed` - visible to all members of this organization.   Default: `secret`   **For a parent or child team:**   \\* `closed` - visible to all members of this organization.   Default for child team: `closed`
    /// </summary>
    /// <value>The level of privacy this team should have. The options are:   **For a non-nested team:**   \\* `secret` - only visible to organization owners and members of this team.   \\* `closed` - visible to all members of this organization.   Default: `secret`   **For a parent or child team:**   \\* `closed` - visible to all members of this organization.   Default for child team: `closed`</value>
    [DataMember(Name="privacy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "privacy")]
    public string Privacy { get; set; }

    /// <summary>
    /// **Deprecated**. The permission that new repositories will be added to the team with when none is specified.
    /// </summary>
    /// <value>**Deprecated**. The permission that new repositories will be added to the team with when none is specified.</value>
    [DataMember(Name="permission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permission")]
    public string Permission { get; set; }

    /// <summary>
    /// The ID of a team to set as the parent team.
    /// </summary>
    /// <value>The ID of a team to set as the parent team.</value>
    [DataMember(Name="parent_team_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent_team_id")]
    public int? ParentTeamId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TeamsCreateRequest {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Maintainers: ").Append(Maintainers).Append("\n");
      sb.Append("  RepoNames: ").Append(RepoNames).Append("\n");
      sb.Append("  Privacy: ").Append(Privacy).Append("\n");
      sb.Append("  Permission: ").Append(Permission).Append("\n");
      sb.Append("  ParentTeamId: ").Append(ParentTeamId).Append("\n");
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
