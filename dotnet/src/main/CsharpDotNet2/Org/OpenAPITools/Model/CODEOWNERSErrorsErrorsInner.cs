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
  public class CODEOWNERSErrorsErrorsInner {
    /// <summary>
    /// The line number where this errors occurs.
    /// </summary>
    /// <value>The line number where this errors occurs.</value>
    [DataMember(Name="line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "line")]
    public int? Line { get; set; }

    /// <summary>
    /// The column number where this errors occurs.
    /// </summary>
    /// <value>The column number where this errors occurs.</value>
    [DataMember(Name="column", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "column")]
    public int? Column { get; set; }

    /// <summary>
    /// The contents of the line where the error occurs.
    /// </summary>
    /// <value>The contents of the line where the error occurs.</value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public string Source { get; set; }

    /// <summary>
    /// The type of error.
    /// </summary>
    /// <value>The type of error.</value>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kind")]
    public string Kind { get; set; }

    /// <summary>
    /// Suggested action to fix the error. This will usually be `null`, but is provided for some common errors.
    /// </summary>
    /// <value>Suggested action to fix the error. This will usually be `null`, but is provided for some common errors.</value>
    [DataMember(Name="suggestion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suggestion")]
    public string Suggestion { get; set; }

    /// <summary>
    /// A human-readable description of the error, combining information from multiple fields, laid out for display in a monospaced typeface (for example, a command-line setting).
    /// </summary>
    /// <value>A human-readable description of the error, combining information from multiple fields, laid out for display in a monospaced typeface (for example, a command-line setting).</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// The path of the file where the error occured.
    /// </summary>
    /// <value>The path of the file where the error occured.</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CODEOWNERSErrorsErrorsInner {\n");
      sb.Append("  Line: ").Append(Line).Append("\n");
      sb.Append("  Column: ").Append(Column).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      sb.Append("  Suggestion: ").Append(Suggestion).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
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
