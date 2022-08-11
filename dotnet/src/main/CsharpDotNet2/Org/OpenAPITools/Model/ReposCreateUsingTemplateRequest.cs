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
  public class ReposCreateUsingTemplateRequest {
    /// <summary>
    /// The organization or person who will own the new repository. To create a new repository in an organization, the authenticated user must be a member of the specified organization.
    /// </summary>
    /// <value>The organization or person who will own the new repository. To create a new repository in an organization, the authenticated user must be a member of the specified organization.</value>
    [DataMember(Name="owner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner")]
    public string Owner { get; set; }

    /// <summary>
    /// The name of the new repository.
    /// </summary>
    /// <value>The name of the new repository.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A short description of the new repository.
    /// </summary>
    /// <value>A short description of the new repository.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Set to `true` to include the directory structure and files from all branches in the template repository, and not just the default branch. Default: `false`.
    /// </summary>
    /// <value>Set to `true` to include the directory structure and files from all branches in the template repository, and not just the default branch. Default: `false`.</value>
    [DataMember(Name="include_all_branches", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "include_all_branches")]
    public bool? IncludeAllBranches { get; set; }

    /// <summary>
    /// Either `true` to create a new private repository or `false` to create a new public one.
    /// </summary>
    /// <value>Either `true` to create a new private repository or `false` to create a new public one.</value>
    [DataMember(Name="private", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "private")]
    public bool? Private { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposCreateUsingTemplateRequest {\n");
      sb.Append("  Owner: ").Append(Owner).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  IncludeAllBranches: ").Append(IncludeAllBranches).Append("\n");
      sb.Append("  Private: ").Append(Private).Append("\n");
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
