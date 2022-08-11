using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Diff Entry
  /// </summary>
  [DataContract]
  public class DiffEntry {
    /// <summary>
    /// Gets or Sets Sha
    /// </summary>
    [DataMember(Name="sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sha")]
    public string Sha { get; set; }

    /// <summary>
    /// Gets or Sets Filename
    /// </summary>
    [DataMember(Name="filename", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filename")]
    public string Filename { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets Additions
    /// </summary>
    [DataMember(Name="additions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additions")]
    public int? Additions { get; set; }

    /// <summary>
    /// Gets or Sets Deletions
    /// </summary>
    [DataMember(Name="deletions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deletions")]
    public int? Deletions { get; set; }

    /// <summary>
    /// Gets or Sets Changes
    /// </summary>
    [DataMember(Name="changes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "changes")]
    public int? Changes { get; set; }

    /// <summary>
    /// Gets or Sets BlobUrl
    /// </summary>
    [DataMember(Name="blob_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blob_url")]
    public string BlobUrl { get; set; }

    /// <summary>
    /// Gets or Sets RawUrl
    /// </summary>
    [DataMember(Name="raw_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "raw_url")]
    public string RawUrl { get; set; }

    /// <summary>
    /// Gets or Sets ContentsUrl
    /// </summary>
    [DataMember(Name="contents_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contents_url")]
    public string ContentsUrl { get; set; }

    /// <summary>
    /// Gets or Sets Patch
    /// </summary>
    [DataMember(Name="patch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "patch")]
    public string Patch { get; set; }

    /// <summary>
    /// Gets or Sets PreviousFilename
    /// </summary>
    [DataMember(Name="previous_filename", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previous_filename")]
    public string PreviousFilename { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DiffEntry {\n");
      sb.Append("  Sha: ").Append(Sha).Append("\n");
      sb.Append("  Filename: ").Append(Filename).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Additions: ").Append(Additions).Append("\n");
      sb.Append("  Deletions: ").Append(Deletions).Append("\n");
      sb.Append("  Changes: ").Append(Changes).Append("\n");
      sb.Append("  BlobUrl: ").Append(BlobUrl).Append("\n");
      sb.Append("  RawUrl: ").Append(RawUrl).Append("\n");
      sb.Append("  ContentsUrl: ").Append(ContentsUrl).Append("\n");
      sb.Append("  Patch: ").Append(Patch).Append("\n");
      sb.Append("  PreviousFilename: ").Append(PreviousFilename).Append("\n");
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
