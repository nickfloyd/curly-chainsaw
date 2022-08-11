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
  public class AppsCreateInstallationAccessTokenRequest {
    /// <summary>
    /// List of repository names that the token should have access to
    /// </summary>
    /// <value>List of repository names that the token should have access to</value>
    [DataMember(Name="repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repositories")]
    public List<string> Repositories { get; set; }

    /// <summary>
    /// List of repository IDs that the token should have access to
    /// </summary>
    /// <value>List of repository IDs that the token should have access to</value>
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
      sb.Append("class AppsCreateInstallationAccessTokenRequest {\n");
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
