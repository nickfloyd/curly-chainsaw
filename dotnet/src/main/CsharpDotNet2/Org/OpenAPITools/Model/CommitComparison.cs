using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Commit Comparison
  /// </summary>
  [DataContract]
  public class CommitComparison {
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
    /// Gets or Sets PermalinkUrl
    /// </summary>
    [DataMember(Name="permalink_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permalink_url")]
    public string PermalinkUrl { get; set; }

    /// <summary>
    /// Gets or Sets DiffUrl
    /// </summary>
    [DataMember(Name="diff_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "diff_url")]
    public string DiffUrl { get; set; }

    /// <summary>
    /// Gets or Sets PatchUrl
    /// </summary>
    [DataMember(Name="patch_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "patch_url")]
    public string PatchUrl { get; set; }

    /// <summary>
    /// Gets or Sets BaseCommit
    /// </summary>
    [DataMember(Name="base_commit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "base_commit")]
    public Commit BaseCommit { get; set; }

    /// <summary>
    /// Gets or Sets MergeBaseCommit
    /// </summary>
    [DataMember(Name="merge_base_commit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merge_base_commit")]
    public Commit MergeBaseCommit { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets AheadBy
    /// </summary>
    [DataMember(Name="ahead_by", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ahead_by")]
    public int? AheadBy { get; set; }

    /// <summary>
    /// Gets or Sets BehindBy
    /// </summary>
    [DataMember(Name="behind_by", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "behind_by")]
    public int? BehindBy { get; set; }

    /// <summary>
    /// Gets or Sets TotalCommits
    /// </summary>
    [DataMember(Name="total_commits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_commits")]
    public int? TotalCommits { get; set; }

    /// <summary>
    /// Gets or Sets Commits
    /// </summary>
    [DataMember(Name="commits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commits")]
    public List<Commit> Commits { get; set; }

    /// <summary>
    /// Gets or Sets Files
    /// </summary>
    [DataMember(Name="files", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "files")]
    public List<DiffEntry> Files { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CommitComparison {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  PermalinkUrl: ").Append(PermalinkUrl).Append("\n");
      sb.Append("  DiffUrl: ").Append(DiffUrl).Append("\n");
      sb.Append("  PatchUrl: ").Append(PatchUrl).Append("\n");
      sb.Append("  BaseCommit: ").Append(BaseCommit).Append("\n");
      sb.Append("  MergeBaseCommit: ").Append(MergeBaseCommit).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  AheadBy: ").Append(AheadBy).Append("\n");
      sb.Append("  BehindBy: ").Append(BehindBy).Append("\n");
      sb.Append("  TotalCommits: ").Append(TotalCommits).Append("\n");
      sb.Append("  Commits: ").Append(Commits).Append("\n");
      sb.Append("  Files: ").Append(Files).Append("\n");
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
