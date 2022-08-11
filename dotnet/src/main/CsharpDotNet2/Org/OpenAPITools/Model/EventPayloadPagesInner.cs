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
  public class EventPayloadPagesInner {
    /// <summary>
    /// Gets or Sets PageName
    /// </summary>
    [DataMember(Name="page_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "page_name")]
    public string PageName { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets Summary
    /// </summary>
    [DataMember(Name="summary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "summary")]
    public string Summary { get; set; }

    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    [DataMember(Name="action", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "action")]
    public string Action { get; set; }

    /// <summary>
    /// Gets or Sets Sha
    /// </summary>
    [DataMember(Name="sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sha")]
    public string Sha { get; set; }

    /// <summary>
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EventPayloadPagesInner {\n");
      sb.Append("  PageName: ").Append(PageName).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Summary: ").Append(Summary).Append("\n");
      sb.Append("  Action: ").Append(Action).Append("\n");
      sb.Append("  Sha: ").Append(Sha).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
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
