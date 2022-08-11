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
  public class IssuePullRequest {
    /// <summary>
    /// Gets or Sets MergedAt
    /// </summary>
    [DataMember(Name="merged_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merged_at")]
    public DateTime? MergedAt { get; set; }

    /// <summary>
    /// Gets or Sets DiffUrl
    /// </summary>
    [DataMember(Name="diff_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "diff_url")]
    public string DiffUrl { get; set; }

    /// <summary>
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Gets or Sets PatchUrl
    /// </summary>
    [DataMember(Name="patch_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "patch_url")]
    public string PatchUrl { get; set; }

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
      sb.Append("class IssuePullRequest {\n");
      sb.Append("  MergedAt: ").Append(MergedAt).Append("\n");
      sb.Append("  DiffUrl: ").Append(DiffUrl).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  PatchUrl: ").Append(PatchUrl).Append("\n");
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
