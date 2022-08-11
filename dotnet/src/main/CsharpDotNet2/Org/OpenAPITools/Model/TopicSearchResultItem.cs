using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Topic Search Result Item
  /// </summary>
  [DataContract]
  public class TopicSearchResultItem {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="display_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets ShortDescription
    /// </summary>
    [DataMember(Name="short_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "short_description")]
    public string ShortDescription { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    [DataMember(Name="created_by", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_by")]
    public string CreatedBy { get; set; }

    /// <summary>
    /// Gets or Sets Released
    /// </summary>
    [DataMember(Name="released", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "released")]
    public string Released { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedAt
    /// </summary>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets or Sets Featured
    /// </summary>
    [DataMember(Name="featured", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featured")]
    public bool? Featured { get; set; }

    /// <summary>
    /// Gets or Sets Curated
    /// </summary>
    [DataMember(Name="curated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "curated")]
    public bool? Curated { get; set; }

    /// <summary>
    /// Gets or Sets Score
    /// </summary>
    [DataMember(Name="score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "score")]
    public decimal? Score { get; set; }

    /// <summary>
    /// Gets or Sets RepositoryCount
    /// </summary>
    [DataMember(Name="repository_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository_count")]
    public int? RepositoryCount { get; set; }

    /// <summary>
    /// Gets or Sets LogoUrl
    /// </summary>
    [DataMember(Name="logo_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logo_url")]
    public string LogoUrl { get; set; }

    /// <summary>
    /// Gets or Sets TextMatches
    /// </summary>
    [DataMember(Name="text_matches", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text_matches")]
    public List<SearchResultTextMatchesInner> TextMatches { get; set; }

    /// <summary>
    /// Gets or Sets Related
    /// </summary>
    [DataMember(Name="related", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "related")]
    public List<TopicSearchResultItemRelatedInner> Related { get; set; }

    /// <summary>
    /// Gets or Sets Aliases
    /// </summary>
    [DataMember(Name="aliases", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aliases")]
    public List<TopicSearchResultItemRelatedInner> Aliases { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TopicSearchResultItem {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
      sb.Append("  Released: ").Append(Released).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Featured: ").Append(Featured).Append("\n");
      sb.Append("  Curated: ").Append(Curated).Append("\n");
      sb.Append("  Score: ").Append(Score).Append("\n");
      sb.Append("  RepositoryCount: ").Append(RepositoryCount).Append("\n");
      sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
      sb.Append("  TextMatches: ").Append(TextMatches).Append("\n");
      sb.Append("  Related: ").Append(Related).Append("\n");
      sb.Append("  Aliases: ").Append(Aliases).Append("\n");
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
