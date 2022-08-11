using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Check Annotation
  /// </summary>
  [DataContract]
  public class CheckAnnotation {
    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// Gets or Sets StartLine
    /// </summary>
    [DataMember(Name="start_line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_line")]
    public int? StartLine { get; set; }

    /// <summary>
    /// Gets or Sets EndLine
    /// </summary>
    [DataMember(Name="end_line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_line")]
    public int? EndLine { get; set; }

    /// <summary>
    /// Gets or Sets StartColumn
    /// </summary>
    [DataMember(Name="start_column", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_column")]
    public int? StartColumn { get; set; }

    /// <summary>
    /// Gets or Sets EndColumn
    /// </summary>
    [DataMember(Name="end_column", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_column")]
    public int? EndColumn { get; set; }

    /// <summary>
    /// Gets or Sets AnnotationLevel
    /// </summary>
    [DataMember(Name="annotation_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "annotation_level")]
    public string AnnotationLevel { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets RawDetails
    /// </summary>
    [DataMember(Name="raw_details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "raw_details")]
    public string RawDetails { get; set; }

    /// <summary>
    /// Gets or Sets BlobHref
    /// </summary>
    [DataMember(Name="blob_href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blob_href")]
    public string BlobHref { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckAnnotation {\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  StartLine: ").Append(StartLine).Append("\n");
      sb.Append("  EndLine: ").Append(EndLine).Append("\n");
      sb.Append("  StartColumn: ").Append(StartColumn).Append("\n");
      sb.Append("  EndColumn: ").Append(EndColumn).Append("\n");
      sb.Append("  AnnotationLevel: ").Append(AnnotationLevel).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  RawDetails: ").Append(RawDetails).Append("\n");
      sb.Append("  BlobHref: ").Append(BlobHref).Append("\n");
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
