using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Represents a &#39;commit&#39; secret scanning location type. This location type shows that a secret was detected inside a commit to a repository.
  /// </summary>
  [DataContract]
  public class SecretScanningListLocationsForAlert200ResponseInnerDetailsOneOf {
    /// <summary>
    /// The file path in the repository
    /// </summary>
    /// <value>The file path in the repository</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// Line number at which the secret starts in the file
    /// </summary>
    /// <value>Line number at which the secret starts in the file</value>
    [DataMember(Name="start_line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_line")]
    public decimal? StartLine { get; set; }

    /// <summary>
    /// Line number at which the secret ends in the file
    /// </summary>
    /// <value>Line number at which the secret ends in the file</value>
    [DataMember(Name="end_line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_line")]
    public decimal? EndLine { get; set; }

    /// <summary>
    /// The column at which the secret starts within the start line when the file is interpreted as 8BIT ASCII
    /// </summary>
    /// <value>The column at which the secret starts within the start line when the file is interpreted as 8BIT ASCII</value>
    [DataMember(Name="start_column", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_column")]
    public decimal? StartColumn { get; set; }

    /// <summary>
    /// The column at which the secret ends within the end line when the file is interpreted as 8BIT ASCII
    /// </summary>
    /// <value>The column at which the secret ends within the end line when the file is interpreted as 8BIT ASCII</value>
    [DataMember(Name="end_column", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_column")]
    public decimal? EndColumn { get; set; }

    /// <summary>
    /// SHA-1 hash ID of the associated blob
    /// </summary>
    /// <value>SHA-1 hash ID of the associated blob</value>
    [DataMember(Name="blob_sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blob_sha")]
    public string BlobSha { get; set; }

    /// <summary>
    /// The API URL to get the associated blob resource
    /// </summary>
    /// <value>The API URL to get the associated blob resource</value>
    [DataMember(Name="blob_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blob_url")]
    public string BlobUrl { get; set; }

    /// <summary>
    /// SHA-1 hash ID of the associated commit
    /// </summary>
    /// <value>SHA-1 hash ID of the associated commit</value>
    [DataMember(Name="commit_sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit_sha")]
    public string CommitSha { get; set; }

    /// <summary>
    /// The API URL to get the associated commit resource
    /// </summary>
    /// <value>The API URL to get the associated commit resource</value>
    [DataMember(Name="commit_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit_url")]
    public string CommitUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SecretScanningListLocationsForAlert200ResponseInnerDetailsOneOf {\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  StartLine: ").Append(StartLine).Append("\n");
      sb.Append("  EndLine: ").Append(EndLine).Append("\n");
      sb.Append("  StartColumn: ").Append(StartColumn).Append("\n");
      sb.Append("  EndColumn: ").Append(EndColumn).Append("\n");
      sb.Append("  BlobSha: ").Append(BlobSha).Append("\n");
      sb.Append("  BlobUrl: ").Append(BlobUrl).Append("\n");
      sb.Append("  CommitSha: ").Append(CommitSha).Append("\n");
      sb.Append("  CommitUrl: ").Append(CommitUrl).Append("\n");
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
