using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Code Search Result Item
  /// </summary>
  [DataContract]
  public class CodeSearchResultItem {
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
    /// Gets or Sets Repository
    /// </summary>
    [DataMember(Name="repository", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository")]
    public MinimalRepository Repository { get; set; }

    /// <summary>
    /// Gets or Sets Score
    /// </summary>
    [DataMember(Name="score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "score")]
    public decimal? Score { get; set; }

    /// <summary>
    /// Gets or Sets FileSize
    /// </summary>
    [DataMember(Name="file_size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "file_size")]
    public int? FileSize { get; set; }

    /// <summary>
    /// Gets or Sets Language
    /// </summary>
    [DataMember(Name="language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// Gets or Sets LastModifiedAt
    /// </summary>
    [DataMember(Name="last_modified_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_modified_at")]
    public DateTime? LastModifiedAt { get; set; }

    /// <summary>
    /// Gets or Sets LineNumbers
    /// </summary>
    [DataMember(Name="line_numbers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "line_numbers")]
    public List<string> LineNumbers { get; set; }

    /// <summary>
    /// Gets or Sets TextMatches
    /// </summary>
    [DataMember(Name="text_matches", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text_matches")]
    public List<SearchResultTextMatchesInner> TextMatches { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CodeSearchResultItem {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  Sha: ").Append(Sha).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  GitUrl: ").Append(GitUrl).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  Repository: ").Append(Repository).Append("\n");
      sb.Append("  Score: ").Append(Score).Append("\n");
      sb.Append("  FileSize: ").Append(FileSize).Append("\n");
      sb.Append("  Language: ").Append(Language).Append("\n");
      sb.Append("  LastModifiedAt: ").Append(LastModifiedAt).Append("\n");
      sb.Append("  LineNumbers: ").Append(LineNumbers).Append("\n");
      sb.Append("  TextMatches: ").Append(TextMatches).Append("\n");
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
