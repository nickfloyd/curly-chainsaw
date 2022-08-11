using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// A release.
  /// </summary>
  [DataContract]
  public class Release {
    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Gets or Sets AssetsUrl
    /// </summary>
    [DataMember(Name="assets_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assets_url")]
    public string AssetsUrl { get; set; }

    /// <summary>
    /// Gets or Sets UploadUrl
    /// </summary>
    [DataMember(Name="upload_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "upload_url")]
    public string UploadUrl { get; set; }

    /// <summary>
    /// Gets or Sets TarballUrl
    /// </summary>
    [DataMember(Name="tarball_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tarball_url")]
    public string TarballUrl { get; set; }

    /// <summary>
    /// Gets or Sets ZipballUrl
    /// </summary>
    [DataMember(Name="zipball_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zipball_url")]
    public string ZipballUrl { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }

    /// <summary>
    /// The name of the tag.
    /// </summary>
    /// <value>The name of the tag.</value>
    [DataMember(Name="tag_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tag_name")]
    public string TagName { get; set; }

    /// <summary>
    /// Specifies the commitish value that determines where the Git tag is created from.
    /// </summary>
    /// <value>Specifies the commitish value that determines where the Git tag is created from.</value>
    [DataMember(Name="target_commitish", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target_commitish")]
    public string TargetCommitish { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Body
    /// </summary>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public string Body { get; set; }

    /// <summary>
    /// true to create a draft (unpublished) release, false to create a published one.
    /// </summary>
    /// <value>true to create a draft (unpublished) release, false to create a published one.</value>
    [DataMember(Name="draft", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "draft")]
    public bool? Draft { get; set; }

    /// <summary>
    /// Whether to identify the release as a prerelease or a full release.
    /// </summary>
    /// <value>Whether to identify the release as a prerelease or a full release.</value>
    [DataMember(Name="prerelease", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prerelease")]
    public bool? Prerelease { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets PublishedAt
    /// </summary>
    [DataMember(Name="published_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "published_at")]
    public DateTime? PublishedAt { get; set; }

    /// <summary>
    /// Gets or Sets Author
    /// </summary>
    [DataMember(Name="author", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "author")]
    public SimpleUser1 Author { get; set; }

    /// <summary>
    /// Gets or Sets Assets
    /// </summary>
    [DataMember(Name="assets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assets")]
    public List<ReleaseAsset> Assets { get; set; }

    /// <summary>
    /// Gets or Sets BodyHtml
    /// </summary>
    [DataMember(Name="body_html", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body_html")]
    public string BodyHtml { get; set; }

    /// <summary>
    /// Gets or Sets BodyText
    /// </summary>
    [DataMember(Name="body_text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body_text")]
    public string BodyText { get; set; }

    /// <summary>
    /// Gets or Sets MentionsCount
    /// </summary>
    [DataMember(Name="mentions_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mentions_count")]
    public int? MentionsCount { get; set; }

    /// <summary>
    /// The URL of the release discussion.
    /// </summary>
    /// <value>The URL of the release discussion.</value>
    [DataMember(Name="discussion_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discussion_url")]
    public string DiscussionUrl { get; set; }

    /// <summary>
    /// Gets or Sets Reactions
    /// </summary>
    [DataMember(Name="reactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reactions")]
    public ReactionRollup Reactions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Release {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  AssetsUrl: ").Append(AssetsUrl).Append("\n");
      sb.Append("  UploadUrl: ").Append(UploadUrl).Append("\n");
      sb.Append("  TarballUrl: ").Append(TarballUrl).Append("\n");
      sb.Append("  ZipballUrl: ").Append(ZipballUrl).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  TagName: ").Append(TagName).Append("\n");
      sb.Append("  TargetCommitish: ").Append(TargetCommitish).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  Draft: ").Append(Draft).Append("\n");
      sb.Append("  Prerelease: ").Append(Prerelease).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  PublishedAt: ").Append(PublishedAt).Append("\n");
      sb.Append("  Author: ").Append(Author).Append("\n");
      sb.Append("  Assets: ").Append(Assets).Append("\n");
      sb.Append("  BodyHtml: ").Append(BodyHtml).Append("\n");
      sb.Append("  BodyText: ").Append(BodyText).Append("\n");
      sb.Append("  MentionsCount: ").Append(MentionsCount).Append("\n");
      sb.Append("  DiscussionUrl: ").Append(DiscussionUrl).Append("\n");
      sb.Append("  Reactions: ").Append(Reactions).Append("\n");
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
