using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Combined Commit Status
  /// </summary>
  [DataContract]
  public class CombinedCommitStatus {
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets Statuses
    /// </summary>
    [DataMember(Name="statuses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statuses")]
    public List<SimpleCommitStatus> Statuses { get; set; }

    /// <summary>
    /// Gets or Sets Sha
    /// </summary>
    [DataMember(Name="sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sha")]
    public string Sha { get; set; }

    /// <summary>
    /// Gets or Sets TotalCount
    /// </summary>
    [DataMember(Name="total_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_count")]
    public int? TotalCount { get; set; }

    /// <summary>
    /// Gets or Sets Repository
    /// </summary>
    [DataMember(Name="repository", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository")]
    public MinimalRepository Repository { get; set; }

    /// <summary>
    /// Gets or Sets CommitUrl
    /// </summary>
    [DataMember(Name="commit_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit_url")]
    public string CommitUrl { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CombinedCommitStatus {\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Statuses: ").Append(Statuses).Append("\n");
      sb.Append("  Sha: ").Append(Sha).Append("\n");
      sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
      sb.Append("  Repository: ").Append(Repository).Append("\n");
      sb.Append("  CommitUrl: ").Append(CommitUrl).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
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
