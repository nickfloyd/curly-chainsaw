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
  public class MarkdownRenderRequest {
    /// <summary>
    /// The Markdown text to render in HTML.
    /// </summary>
    /// <value>The Markdown text to render in HTML.</value>
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }

    /// <summary>
    /// The rendering mode. Can be either `markdown` or `gfm`.
    /// </summary>
    /// <value>The rendering mode. Can be either `markdown` or `gfm`.</value>
    [DataMember(Name="mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mode")]
    public string Mode { get; set; }

    /// <summary>
    /// The repository context to use when creating references in `gfm` mode.  For example, setting `context` to `octo-org/octo-repo` will change the text `#42` into an HTML link to issue 42 in the `octo-org/octo-repo` repository.
    /// </summary>
    /// <value>The repository context to use when creating references in `gfm` mode.  For example, setting `context` to `octo-org/octo-repo` will change the text `#42` into an HTML link to issue 42 in the `octo-org/octo-repo` repository.</value>
    [DataMember(Name="context", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "context")]
    public string Context { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MarkdownRenderRequest {\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  Mode: ").Append(Mode).Append("\n");
      sb.Append("  Context: ").Append(Context).Append("\n");
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
