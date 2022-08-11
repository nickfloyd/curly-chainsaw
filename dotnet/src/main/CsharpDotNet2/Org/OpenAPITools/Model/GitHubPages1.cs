using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The GitHub Pages deployment status.
  /// </summary>
  [DataContract]
  public class GitHubPages1 {
    /// <summary>
    /// The URI to monitor GitHub Pages deployment status.
    /// </summary>
    /// <value>The URI to monitor GitHub Pages deployment status.</value>
    [DataMember(Name="status_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status_url")]
    public string StatusUrl { get; set; }

    /// <summary>
    /// The URI to the deployed GitHub Pages.
    /// </summary>
    /// <value>The URI to the deployed GitHub Pages.</value>
    [DataMember(Name="page_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "page_url")]
    public string PageUrl { get; set; }

    /// <summary>
    /// The URI to the deployed GitHub Pages preview.
    /// </summary>
    /// <value>The URI to the deployed GitHub Pages preview.</value>
    [DataMember(Name="preview_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "preview_url")]
    public string PreviewUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GitHubPages1 {\n");
      sb.Append("  StatusUrl: ").Append(StatusUrl).Append("\n");
      sb.Append("  PageUrl: ").Append(PageUrl).Append("\n");
      sb.Append("  PreviewUrl: ").Append(PreviewUrl).Append("\n");
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
