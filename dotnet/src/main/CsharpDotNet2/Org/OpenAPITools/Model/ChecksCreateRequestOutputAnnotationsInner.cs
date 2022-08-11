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
  public class ChecksCreateRequestOutputAnnotationsInner {
    /// <summary>
    /// The path of the file to add an annotation to. For example, `assets/css/main.css`.
    /// </summary>
    /// <value>The path of the file to add an annotation to. For example, `assets/css/main.css`.</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// The start line of the annotation.
    /// </summary>
    /// <value>The start line of the annotation.</value>
    [DataMember(Name="start_line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_line")]
    public int? StartLine { get; set; }

    /// <summary>
    /// The end line of the annotation.
    /// </summary>
    /// <value>The end line of the annotation.</value>
    [DataMember(Name="end_line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_line")]
    public int? EndLine { get; set; }

    /// <summary>
    /// The start column of the annotation. Annotations only support `start_column` and `end_column` on the same line. Omit this parameter if `start_line` and `end_line` have different values.
    /// </summary>
    /// <value>The start column of the annotation. Annotations only support `start_column` and `end_column` on the same line. Omit this parameter if `start_line` and `end_line` have different values.</value>
    [DataMember(Name="start_column", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_column")]
    public int? StartColumn { get; set; }

    /// <summary>
    /// The end column of the annotation. Annotations only support `start_column` and `end_column` on the same line. Omit this parameter if `start_line` and `end_line` have different values.
    /// </summary>
    /// <value>The end column of the annotation. Annotations only support `start_column` and `end_column` on the same line. Omit this parameter if `start_line` and `end_line` have different values.</value>
    [DataMember(Name="end_column", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_column")]
    public int? EndColumn { get; set; }

    /// <summary>
    /// The level of the annotation.
    /// </summary>
    /// <value>The level of the annotation.</value>
    [DataMember(Name="annotation_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "annotation_level")]
    public string AnnotationLevel { get; set; }

    /// <summary>
    /// A short description of the feedback for these lines of code. The maximum size is 64 KB.
    /// </summary>
    /// <value>A short description of the feedback for these lines of code. The maximum size is 64 KB.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// The title that represents the annotation. The maximum size is 255 characters.
    /// </summary>
    /// <value>The title that represents the annotation. The maximum size is 255 characters.</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Details about this annotation. The maximum size is 64 KB.
    /// </summary>
    /// <value>Details about this annotation. The maximum size is 64 KB.</value>
    [DataMember(Name="raw_details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "raw_details")]
    public string RawDetails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChecksCreateRequestOutputAnnotationsInner {\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  StartLine: ").Append(StartLine).Append("\n");
      sb.Append("  EndLine: ").Append(EndLine).Append("\n");
      sb.Append("  StartColumn: ").Append(StartColumn).Append("\n");
      sb.Append("  EndColumn: ").Append(EndColumn).Append("\n");
      sb.Append("  AnnotationLevel: ").Append(AnnotationLevel).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  RawDetails: ").Append(RawDetails).Append("\n");
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
