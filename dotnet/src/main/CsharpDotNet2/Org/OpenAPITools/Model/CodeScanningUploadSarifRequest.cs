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
  public class CodeScanningUploadSarifRequest {
    /// <summary>
    /// The SHA of the commit to which the analysis you are uploading relates.
    /// </summary>
    /// <value>The SHA of the commit to which the analysis you are uploading relates.</value>
    [DataMember(Name="commit_sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit_sha")]
    public string CommitSha { get; set; }

    /// <summary>
    /// The full Git reference, formatted as `refs/heads/<branch name>`, `refs/pull/<number>/merge`, or `refs/pull/<number>/head`.
    /// </summary>
    /// <value>The full Git reference, formatted as `refs/heads/<branch name>`, `refs/pull/<number>/merge`, or `refs/pull/<number>/head`.</value>
    [DataMember(Name="ref", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ref")]
    public string Ref { get; set; }

    /// <summary>
    /// A Base64 string representing the SARIF file to upload. You must first compress your SARIF file using [`gzip`](http://www.gnu.org/software/gzip/manual/gzip.html) and then translate the contents of the file into a Base64 encoding string. For more information, see \"[SARIF support for code scanning](https://docs.github.com/code-security/secure-coding/sarif-support-for-code-scanning).\"
    /// </summary>
    /// <value>A Base64 string representing the SARIF file to upload. You must first compress your SARIF file using [`gzip`](http://www.gnu.org/software/gzip/manual/gzip.html) and then translate the contents of the file into a Base64 encoding string. For more information, see \"[SARIF support for code scanning](https://docs.github.com/code-security/secure-coding/sarif-support-for-code-scanning).\"</value>
    [DataMember(Name="sarif", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sarif")]
    public string Sarif { get; set; }

    /// <summary>
    /// The base directory used in the analysis, as it appears in the SARIF file. This property is used to convert file paths from absolute to relative, so that alerts can be mapped to their correct location in the repository.
    /// </summary>
    /// <value>The base directory used in the analysis, as it appears in the SARIF file. This property is used to convert file paths from absolute to relative, so that alerts can be mapped to their correct location in the repository.</value>
    [DataMember(Name="checkout_uri", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkout_uri")]
    public string CheckoutUri { get; set; }

    /// <summary>
    /// The time that the analysis run began. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
    /// </summary>
    /// <value>The time that the analysis run began. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.</value>
    [DataMember(Name="started_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "started_at")]
    public DateTime? StartedAt { get; set; }

    /// <summary>
    /// The name of the tool used to generate the code scanning analysis. If this parameter is not used, the tool name defaults to \"API\". If the uploaded SARIF contains a tool GUID, this will be available for filtering using the `tool_guid` parameter of operations such as `GET /repos/{owner}/{repo}/code-scanning/alerts`.
    /// </summary>
    /// <value>The name of the tool used to generate the code scanning analysis. If this parameter is not used, the tool name defaults to \"API\". If the uploaded SARIF contains a tool GUID, this will be available for filtering using the `tool_guid` parameter of operations such as `GET /repos/{owner}/{repo}/code-scanning/alerts`.</value>
    [DataMember(Name="tool_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tool_name")]
    public string ToolName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CodeScanningUploadSarifRequest {\n");
      sb.Append("  CommitSha: ").Append(CommitSha).Append("\n");
      sb.Append("  Ref: ").Append(Ref).Append("\n");
      sb.Append("  Sarif: ").Append(Sarif).Append("\n");
      sb.Append("  CheckoutUri: ").Append(CheckoutUri).Append("\n");
      sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
      sb.Append("  ToolName: ").Append(ToolName).Append("\n");
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
