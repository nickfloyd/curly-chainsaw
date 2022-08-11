using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Authentication token for a GitHub App installed on a user or org.
  /// </summary>
  [DataContract]
  public class InstallationToken {
    /// <summary>
    /// Gets or Sets Token
    /// </summary>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }

    /// <summary>
    /// Gets or Sets ExpiresAt
    /// </summary>
    [DataMember(Name="expires_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expires_at")]
    public string ExpiresAt { get; set; }

    /// <summary>
    /// Gets or Sets Permissions
    /// </summary>
    [DataMember(Name="permissions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permissions")]
    public AppPermissions Permissions { get; set; }

    /// <summary>
    /// Gets or Sets RepositorySelection
    /// </summary>
    [DataMember(Name="repository_selection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository_selection")]
    public string RepositorySelection { get; set; }

    /// <summary>
    /// Gets or Sets Repositories
    /// </summary>
    [DataMember(Name="repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repositories")]
    public List<Repository> Repositories { get; set; }

    /// <summary>
    /// Gets or Sets SingleFile
    /// </summary>
    [DataMember(Name="single_file", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "single_file")]
    public string SingleFile { get; set; }

    /// <summary>
    /// Gets or Sets HasMultipleSingleFiles
    /// </summary>
    [DataMember(Name="has_multiple_single_files", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_multiple_single_files")]
    public bool? HasMultipleSingleFiles { get; set; }

    /// <summary>
    /// Gets or Sets SingleFilePaths
    /// </summary>
    [DataMember(Name="single_file_paths", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "single_file_paths")]
    public List<string> SingleFilePaths { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InstallationToken {\n");
      sb.Append("  Token: ").Append(Token).Append("\n");
      sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
      sb.Append("  Permissions: ").Append(Permissions).Append("\n");
      sb.Append("  RepositorySelection: ").Append(RepositorySelection).Append("\n");
      sb.Append("  Repositories: ").Append(Repositories).Append("\n");
      sb.Append("  SingleFile: ").Append(SingleFile).Append("\n");
      sb.Append("  HasMultipleSingleFiles: ").Append(HasMultipleSingleFiles).Append("\n");
      sb.Append("  SingleFilePaths: ").Append(SingleFilePaths).Append("\n");
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
