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
  public class CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance {
    /// <summary>
    /// The full Git reference, formatted as `refs/heads/<branch name>`, `refs/pull/<number>/merge`, or `refs/pull/<number>/head`.
    /// </summary>
    /// <value>The full Git reference, formatted as `refs/heads/<branch name>`, `refs/pull/<number>/merge`, or `refs/pull/<number>/head`.</value>
    [DataMember(Name="ref", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ref")]
    public string Ref { get; set; }

    /// <summary>
    /// Identifies the configuration under which the analysis was executed. For example, in GitHub Actions this includes the workflow filename and job name.
    /// </summary>
    /// <value>Identifies the configuration under which the analysis was executed. For example, in GitHub Actions this includes the workflow filename and job name.</value>
    [DataMember(Name="analysis_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "analysis_key")]
    public string AnalysisKey { get; set; }

    /// <summary>
    /// Identifies the variable values associated with the environment in which the analysis that generated this alert instance was performed, such as the language that was analyzed.
    /// </summary>
    /// <value>Identifies the variable values associated with the environment in which the analysis that generated this alert instance was performed, such as the language that was analyzed.</value>
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
    /// State of a code scanning alert.
    /// </summary>
    /// <value>State of a code scanning alert.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets CommitSha
    /// </summary>
    [DataMember(Name="commit_sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit_sha")]
    public string CommitSha { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceMessage Message { get; set; }

    /// <summary>
    /// Gets or Sets Location
    /// </summary>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceLocation Location { get; set; }

    /// <summary>
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Classifications that have been applied to the file that triggered the alert. For example identifying it as documentation, or a generated file.
    /// </summary>
    /// <value>Classifications that have been applied to the file that triggered the alert. For example identifying it as documentation, or a generated file.</value>
    [DataMember(Name="classifications", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "classifications")]
    public List<string> Classifications { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance {\n");
      sb.Append("  Ref: ").Append(Ref).Append("\n");
      sb.Append("  AnalysisKey: ").Append(AnalysisKey).Append("\n");
      sb.Append("  Environment: ").Append(Environment).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  CommitSha: ").Append(CommitSha).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  Classifications: ").Append(Classifications).Append("\n");
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
