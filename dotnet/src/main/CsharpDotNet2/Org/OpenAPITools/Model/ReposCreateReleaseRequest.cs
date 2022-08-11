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
  public class ReposCreateReleaseRequest {
    /// <summary>
    /// The name of the tag.
    /// </summary>
    /// <value>The name of the tag.</value>
    [DataMember(Name="tag_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tag_name")]
    public string TagName { get; set; }

    /// <summary>
    /// Specifies the commitish value that determines where the Git tag is created from. Can be any branch or commit SHA. Unused if the Git tag already exists. Default: the repository's default branch (usually `master`).
    /// </summary>
    /// <value>Specifies the commitish value that determines where the Git tag is created from. Can be any branch or commit SHA. Unused if the Git tag already exists. Default: the repository's default branch (usually `master`).</value>
    [DataMember(Name="target_commitish", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target_commitish")]
    public string TargetCommitish { get; set; }

    /// <summary>
    /// The name of the release.
    /// </summary>
    /// <value>The name of the release.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Text describing the contents of the tag.
    /// </summary>
    /// <value>Text describing the contents of the tag.</value>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public string Body { get; set; }

    /// <summary>
    /// `true` to create a draft (unpublished) release, `false` to create a published one.
    /// </summary>
    /// <value>`true` to create a draft (unpublished) release, `false` to create a published one.</value>
    [DataMember(Name="draft", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "draft")]
    public bool? Draft { get; set; }

    /// <summary>
    /// `true` to identify the release as a prerelease. `false` to identify the release as a full release.
    /// </summary>
    /// <value>`true` to identify the release as a prerelease. `false` to identify the release as a full release.</value>
    [DataMember(Name="prerelease", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prerelease")]
    public bool? Prerelease { get; set; }

    /// <summary>
    /// If specified, a discussion of the specified category is created and linked to the release. The value must be a category that already exists in the repository. For more information, see \"[Managing categories for discussions in your repository](https://docs.github.com/discussions/managing-discussions-for-your-community/managing-categories-for-discussions-in-your-repository).\"
    /// </summary>
    /// <value>If specified, a discussion of the specified category is created and linked to the release. The value must be a category that already exists in the repository. For more information, see \"[Managing categories for discussions in your repository](https://docs.github.com/discussions/managing-discussions-for-your-community/managing-categories-for-discussions-in-your-repository).\"</value>
    [DataMember(Name="discussion_category_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discussion_category_name")]
    public string DiscussionCategoryName { get; set; }

    /// <summary>
    /// Whether to automatically generate the name and body for this release. If `name` is specified, the specified name will be used; otherwise, a name will be automatically generated. If `body` is specified, the body will be pre-pended to the automatically generated notes.
    /// </summary>
    /// <value>Whether to automatically generate the name and body for this release. If `name` is specified, the specified name will be used; otherwise, a name will be automatically generated. If `body` is specified, the body will be pre-pended to the automatically generated notes.</value>
    [DataMember(Name="generate_release_notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "generate_release_notes")]
    public bool? GenerateReleaseNotes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposCreateReleaseRequest {\n");
      sb.Append("  TagName: ").Append(TagName).Append("\n");
      sb.Append("  TargetCommitish: ").Append(TargetCommitish).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  Draft: ").Append(Draft).Append("\n");
      sb.Append("  Prerelease: ").Append(Prerelease).Append("\n");
      sb.Append("  DiscussionCategoryName: ").Append(DiscussionCategoryName).Append("\n");
      sb.Append("  GenerateReleaseNotes: ").Append(GenerateReleaseNotes).Append("\n");
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
