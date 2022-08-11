using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// A repository import from an external source.
  /// </summary>
  [DataContract]
  public class Import {
    /// <summary>
    /// Gets or Sets Vcs
    /// </summary>
    [DataMember(Name="vcs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vcs")]
    public string Vcs { get; set; }

    /// <summary>
    /// Gets or Sets UseLfs
    /// </summary>
    [DataMember(Name="use_lfs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "use_lfs")]
    public bool? UseLfs { get; set; }

    /// <summary>
    /// The URL of the originating repository.
    /// </summary>
    /// <value>The URL of the originating repository.</value>
    [DataMember(Name="vcs_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vcs_url")]
    public string VcsUrl { get; set; }

    /// <summary>
    /// Gets or Sets SvcRoot
    /// </summary>
    [DataMember(Name="svc_root", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "svc_root")]
    public string SvcRoot { get; set; }

    /// <summary>
    /// Gets or Sets TfvcProject
    /// </summary>
    [DataMember(Name="tfvc_project", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tfvc_project")]
    public string TfvcProject { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets StatusText
    /// </summary>
    [DataMember(Name="status_text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status_text")]
    public string StatusText { get; set; }

    /// <summary>
    /// Gets or Sets FailedStep
    /// </summary>
    [DataMember(Name="failed_step", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failed_step")]
    public string FailedStep { get; set; }

    /// <summary>
    /// Gets or Sets ErrorMessage
    /// </summary>
    [DataMember(Name="error_message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error_message")]
    public string ErrorMessage { get; set; }

    /// <summary>
    /// Gets or Sets ImportPercent
    /// </summary>
    [DataMember(Name="import_percent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "import_percent")]
    public int? ImportPercent { get; set; }

    /// <summary>
    /// Gets or Sets CommitCount
    /// </summary>
    [DataMember(Name="commit_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit_count")]
    public int? CommitCount { get; set; }

    /// <summary>
    /// Gets or Sets PushPercent
    /// </summary>
    [DataMember(Name="push_percent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "push_percent")]
    public int? PushPercent { get; set; }

    /// <summary>
    /// Gets or Sets HasLargeFiles
    /// </summary>
    [DataMember(Name="has_large_files", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_large_files")]
    public bool? HasLargeFiles { get; set; }

    /// <summary>
    /// Gets or Sets LargeFilesSize
    /// </summary>
    [DataMember(Name="large_files_size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "large_files_size")]
    public int? LargeFilesSize { get; set; }

    /// <summary>
    /// Gets or Sets LargeFilesCount
    /// </summary>
    [DataMember(Name="large_files_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "large_files_count")]
    public int? LargeFilesCount { get; set; }

    /// <summary>
    /// Gets or Sets ProjectChoices
    /// </summary>
    [DataMember(Name="project_choices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "project_choices")]
    public List<ImportProjectChoicesInner> ProjectChoices { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets AuthorsCount
    /// </summary>
    [DataMember(Name="authors_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authors_count")]
    public int? AuthorsCount { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Gets or Sets AuthorsUrl
    /// </summary>
    [DataMember(Name="authors_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authors_url")]
    public string AuthorsUrl { get; set; }

    /// <summary>
    /// Gets or Sets RepositoryUrl
    /// </summary>
    [DataMember(Name="repository_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository_url")]
    public string RepositoryUrl { get; set; }

    /// <summary>
    /// Gets or Sets SvnRoot
    /// </summary>
    [DataMember(Name="svn_root", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "svn_root")]
    public string SvnRoot { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Import {\n");
      sb.Append("  Vcs: ").Append(Vcs).Append("\n");
      sb.Append("  UseLfs: ").Append(UseLfs).Append("\n");
      sb.Append("  VcsUrl: ").Append(VcsUrl).Append("\n");
      sb.Append("  SvcRoot: ").Append(SvcRoot).Append("\n");
      sb.Append("  TfvcProject: ").Append(TfvcProject).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  StatusText: ").Append(StatusText).Append("\n");
      sb.Append("  FailedStep: ").Append(FailedStep).Append("\n");
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
      sb.Append("  ImportPercent: ").Append(ImportPercent).Append("\n");
      sb.Append("  CommitCount: ").Append(CommitCount).Append("\n");
      sb.Append("  PushPercent: ").Append(PushPercent).Append("\n");
      sb.Append("  HasLargeFiles: ").Append(HasLargeFiles).Append("\n");
      sb.Append("  LargeFilesSize: ").Append(LargeFilesSize).Append("\n");
      sb.Append("  LargeFilesCount: ").Append(LargeFilesCount).Append("\n");
      sb.Append("  ProjectChoices: ").Append(ProjectChoices).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  AuthorsCount: ").Append(AuthorsCount).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  AuthorsUrl: ").Append(AuthorsUrl).Append("\n");
      sb.Append("  RepositoryUrl: ").Append(RepositoryUrl).Append("\n");
      sb.Append("  SvnRoot: ").Append(SvnRoot).Append("\n");
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
