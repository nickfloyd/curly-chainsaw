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
  public class CodeScanningListRecentAnalyses200ResponseInner {
    /// <summary>
    /// The full Git reference, formatted as `refs/heads/<branch name>`, `refs/pull/<number>/merge`, or `refs/pull/<number>/head`.
    /// </summary>
    /// <value>The full Git reference, formatted as `refs/heads/<branch name>`, `refs/pull/<number>/merge`, or `refs/pull/<number>/head`.</value>
    [DataMember(Name="ref", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ref")]
    public string Ref { get; set; }

    /// <summary>
    /// The SHA of the commit to which the analysis you are uploading relates.
    /// </summary>
    /// <value>The SHA of the commit to which the analysis you are uploading relates.</value>
    [DataMember(Name="commit_sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit_sha")]
    public string CommitSha { get; set; }

    /// <summary>
    /// Identifies the configuration under which the analysis was executed. For example, in GitHub Actions this includes the workflow filename and job name.
    /// </summary>
    /// <value>Identifies the configuration under which the analysis was executed. For example, in GitHub Actions this includes the workflow filename and job name.</value>
    [DataMember(Name="analysis_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "analysis_key")]
    public string AnalysisKey { get; set; }

    /// <summary>
    /// Identifies the variable values associated with the environment in which this analysis was performed.
    /// </summary>
    /// <value>Identifies the variable values associated with the environment in which this analysis was performed.</value>
    [DataMember(Name="environment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "environment")]
    public string Environment { get; set; }

    /// <summary>
    /// Identifies the configuration under which the analysis was executed. Used to distinguish between multiple analyses for the same tool and commit, but performed on different languages or different parts of the code.
    /// </summary>
    /// <value>Identifies the configuration under which the analysis was executed. Used to distinguish between multiple analyses for the same tool and commit, but performed on different languages or different parts of the code.</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; }

    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    [DataMember(Name="error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error")]
    public string Error { get; set; }

    /// <summary>
    /// The time that the analysis was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
    /// </summary>
    /// <value>The time that the analysis was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The total number of results in the analysis.
    /// </summary>
    /// <value>The total number of results in the analysis.</value>
    [DataMember(Name="results_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "results_count")]
    public int? ResultsCount { get; set; }

    /// <summary>
    /// The total number of rules used in the analysis.
    /// </summary>
    /// <value>The total number of rules used in the analysis.</value>
    [DataMember(Name="rules_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rules_count")]
    public int? RulesCount { get; set; }

    /// <summary>
    /// Unique identifier for this analysis.
    /// </summary>
    /// <value>Unique identifier for this analysis.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The REST API URL of the analysis resource.
    /// </summary>
    /// <value>The REST API URL of the analysis resource.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// An identifier for the upload.
    /// </summary>
    /// <value>An identifier for the upload.</value>
    [DataMember(Name="sarif_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sarif_id")]
    public string SarifId { get; set; }

    /// <summary>
    /// Gets or Sets Tool
    /// </summary>
    [DataMember(Name="tool", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tool")]
    public CodeScanningListAlertsForEnterprise200ResponseInnerTool Tool { get; set; }

    /// <summary>
    /// Gets or Sets Deletable
    /// </summary>
    [DataMember(Name="deletable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deletable")]
    public bool? Deletable { get; set; }

    /// <summary>
    /// Warning generated when processing the analysis
    /// </summary>
    /// <value>Warning generated when processing the analysis</value>
    [DataMember(Name="warning", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "warning")]
    public string Warning { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CodeScanningListRecentAnalyses200ResponseInner {\n");
      sb.Append("  Ref: ").Append(Ref).Append("\n");
      sb.Append("  CommitSha: ").Append(CommitSha).Append("\n");
      sb.Append("  AnalysisKey: ").Append(AnalysisKey).Append("\n");
      sb.Append("  Environment: ").Append(Environment).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Error: ").Append(Error).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  ResultsCount: ").Append(ResultsCount).Append("\n");
      sb.Append("  RulesCount: ").Append(RulesCount).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  SarifId: ").Append(SarifId).Append("\n");
      sb.Append("  Tool: ").Append(Tool).Append("\n");
      sb.Append("  Deletable: ").Append(Deletable).Append("\n");
      sb.Append("  Warning: ").Append(Warning).Append("\n");
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
