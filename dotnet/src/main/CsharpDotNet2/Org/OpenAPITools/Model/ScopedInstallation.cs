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
  public class ScopedInstallation {
    /// <summary>
    /// Gets or Sets Permissions
    /// </summary>
    [DataMember(Name="permissions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permissions")]
    public AppPermissions Permissions { get; set; }

    /// <summary>
    /// Describe whether all repositories have been selected or there's a selection involved
    /// </summary>
    /// <value>Describe whether all repositories have been selected or there's a selection involved</value>
    [DataMember(Name="repository_selection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository_selection")]
    public string RepositorySelection { get; set; }

    /// <summary>
    /// Gets or Sets SingleFileName
    /// </summary>
    [DataMember(Name="single_file_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "single_file_name")]
    public string SingleFileName { get; set; }

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
    /// Gets or Sets RepositoriesUrl
    /// </summary>
    [DataMember(Name="repositories_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repositories_url")]
    public string RepositoriesUrl { get; set; }

    /// <summary>
    /// Gets or Sets Account
    /// </summary>
    [DataMember(Name="account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account")]
    public SimpleUser1 Account { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ScopedInstallation {\n");
      sb.Append("  Permissions: ").Append(Permissions).Append("\n");
      sb.Append("  RepositorySelection: ").Append(RepositorySelection).Append("\n");
      sb.Append("  SingleFileName: ").Append(SingleFileName).Append("\n");
      sb.Append("  HasMultipleSingleFiles: ").Append(HasMultipleSingleFiles).Append("\n");
      sb.Append("  SingleFilePaths: ").Append(SingleFilePaths).Append("\n");
      sb.Append("  RepositoriesUrl: ").Append(RepositoriesUrl).Append("\n");
      sb.Append("  Account: ").Append(Account).Append("\n");
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
