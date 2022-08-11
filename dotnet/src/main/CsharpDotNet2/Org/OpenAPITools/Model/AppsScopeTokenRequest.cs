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
  public class AppsScopeTokenRequest {
    /// <summary>
    /// The OAuth access token used to authenticate to the GitHub API.
    /// </summary>
    /// <value>The OAuth access token used to authenticate to the GitHub API.</value>
    [DataMember(Name="access_token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "access_token")]
    public string AccessToken { get; set; }

    /// <summary>
    /// The name of the user or organization to scope the user-to-server access token to. **Required** unless `target_id` is specified.
    /// </summary>
    /// <value>The name of the user or organization to scope the user-to-server access token to. **Required** unless `target_id` is specified.</value>
    [DataMember(Name="target", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target")]
    public string Target { get; set; }

    /// <summary>
    /// The ID of the user or organization to scope the user-to-server access token to. **Required** unless `target` is specified.
    /// </summary>
    /// <value>The ID of the user or organization to scope the user-to-server access token to. **Required** unless `target` is specified.</value>
    [DataMember(Name="target_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target_id")]
    public int? TargetId { get; set; }

    /// <summary>
    /// The list of repository names to scope the user-to-server access token to. `repositories` may not be specified if `repository_ids` is specified.
    /// </summary>
    /// <value>The list of repository names to scope the user-to-server access token to. `repositories` may not be specified if `repository_ids` is specified.</value>
    [DataMember(Name="repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repositories")]
    public List<string> Repositories { get; set; }

    /// <summary>
    /// The list of repository IDs to scope the user-to-server access token to. `repository_ids` may not be specified if `repositories` is specified.
    /// </summary>
    /// <value>The list of repository IDs to scope the user-to-server access token to. `repository_ids` may not be specified if `repositories` is specified.</value>
    [DataMember(Name="repository_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository_ids")]
    public List<int?> RepositoryIds { get; set; }

    /// <summary>
    /// Gets or Sets Permissions
    /// </summary>
    [DataMember(Name="permissions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permissions")]
    public AppPermissions Permissions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppsScopeTokenRequest {\n");
      sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
      sb.Append("  Target: ").Append(Target).Append("\n");
      sb.Append("  TargetId: ").Append(TargetId).Append("\n");
      sb.Append("  Repositories: ").Append(Repositories).Append("\n");
      sb.Append("  RepositoryIds: ").Append(RepositoryIds).Append("\n");
      sb.Append("  Permissions: ").Append(Permissions).Append("\n");
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
