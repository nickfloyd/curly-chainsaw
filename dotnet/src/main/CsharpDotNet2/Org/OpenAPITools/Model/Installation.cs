using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Installation
  /// </summary>
  [DataContract]
  public class Installation {
    /// <summary>
    /// The ID of the installation.
    /// </summary>
    /// <value>The ID of the installation.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Account
    /// </summary>
    [DataMember(Name="account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account")]
    public InstallationAccount Account { get; set; }

    /// <summary>
    /// Describe whether all repositories have been selected or there's a selection involved
    /// </summary>
    /// <value>Describe whether all repositories have been selected or there's a selection involved</value>
    [DataMember(Name="repository_selection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository_selection")]
    public string RepositorySelection { get; set; }

    /// <summary>
    /// Gets or Sets AccessTokensUrl
    /// </summary>
    [DataMember(Name="access_tokens_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "access_tokens_url")]
    public string AccessTokensUrl { get; set; }

    /// <summary>
    /// Gets or Sets RepositoriesUrl
    /// </summary>
    [DataMember(Name="repositories_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repositories_url")]
    public string RepositoriesUrl { get; set; }

    /// <summary>
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Gets or Sets AppId
    /// </summary>
    [DataMember(Name="app_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "app_id")]
    public int? AppId { get; set; }

    /// <summary>
    /// The ID of the user or organization this token is being scoped to.
    /// </summary>
    /// <value>The ID of the user or organization this token is being scoped to.</value>
    [DataMember(Name="target_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target_id")]
    public int? TargetId { get; set; }

    /// <summary>
    /// Gets or Sets TargetType
    /// </summary>
    [DataMember(Name="target_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target_type")]
    public string TargetType { get; set; }

    /// <summary>
    /// Gets or Sets Permissions
    /// </summary>
    [DataMember(Name="permissions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permissions")]
    public AppPermissions Permissions { get; set; }

    /// <summary>
    /// Gets or Sets Events
    /// </summary>
    [DataMember(Name="events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events")]
    public List<string> Events { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedAt
    /// </summary>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

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
    /// Gets or Sets AppSlug
    /// </summary>
    [DataMember(Name="app_slug", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "app_slug")]
    public string AppSlug { get; set; }

    /// <summary>
    /// Gets or Sets SuspendedBy
    /// </summary>
    [DataMember(Name="suspended_by", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suspended_by")]
    public SimpleUser SuspendedBy { get; set; }

    /// <summary>
    /// Gets or Sets SuspendedAt
    /// </summary>
    [DataMember(Name="suspended_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suspended_at")]
    public DateTime? SuspendedAt { get; set; }

    /// <summary>
    /// Gets or Sets ContactEmail
    /// </summary>
    [DataMember(Name="contact_email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contact_email")]
    public string ContactEmail { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Installation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Account: ").Append(Account).Append("\n");
      sb.Append("  RepositorySelection: ").Append(RepositorySelection).Append("\n");
      sb.Append("  AccessTokensUrl: ").Append(AccessTokensUrl).Append("\n");
      sb.Append("  RepositoriesUrl: ").Append(RepositoriesUrl).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  AppId: ").Append(AppId).Append("\n");
      sb.Append("  TargetId: ").Append(TargetId).Append("\n");
      sb.Append("  TargetType: ").Append(TargetType).Append("\n");
      sb.Append("  Permissions: ").Append(Permissions).Append("\n");
      sb.Append("  Events: ").Append(Events).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  SingleFileName: ").Append(SingleFileName).Append("\n");
      sb.Append("  HasMultipleSingleFiles: ").Append(HasMultipleSingleFiles).Append("\n");
      sb.Append("  SingleFilePaths: ").Append(SingleFilePaths).Append("\n");
      sb.Append("  AppSlug: ").Append(AppSlug).Append("\n");
      sb.Append("  SuspendedBy: ").Append(SuspendedBy).Append("\n");
      sb.Append("  SuspendedAt: ").Append(SuspendedAt).Append("\n");
      sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
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
