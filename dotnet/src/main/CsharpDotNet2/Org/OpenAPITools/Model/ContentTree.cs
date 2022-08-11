using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Content Tree
  /// </summary>
  [DataContract]
  public class ContentTree {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Size
    /// </summary>
    [DataMember(Name="size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size")]
    public int? Size { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// Gets or Sets Sha
    /// </summary>
    [DataMember(Name="sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sha")]
    public string Sha { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets GitUrl
    /// </summary>
    [DataMember(Name="git_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "git_url")]
    public string GitUrl { get; set; }

    /// <summary>
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Gets or Sets DownloadUrl
    /// </summary>
    [DataMember(Name="download_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "download_url")]
    public string DownloadUrl { get; set; }

    /// <summary>
    /// Gets or Sets Entries
    /// </summary>
    [DataMember(Name="entries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entries")]
    public List<ContentTreeEntriesInner> Entries { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="_links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_links")]
    public ContentTreeEntriesInnerLinks Links { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ContentTree {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  Sha: ").Append(Sha).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  GitUrl: ").Append(GitUrl).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
      sb.Append("  Entries: ").Append(Entries).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
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
