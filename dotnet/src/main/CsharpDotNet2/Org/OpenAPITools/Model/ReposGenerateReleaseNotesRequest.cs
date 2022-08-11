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
  public class ReposGenerateReleaseNotesRequest {
    /// <summary>
    /// The tag name for the release. This can be an existing tag or a new one.
    /// </summary>
    /// <value>The tag name for the release. This can be an existing tag or a new one.</value>
    [DataMember(Name="tag_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tag_name")]
    public string TagName { get; set; }

    /// <summary>
    /// Specifies the commitish value that will be the target for the release's tag. Required if the supplied tag_name does not reference an existing tag. Ignored if the tag_name already exists.
    /// </summary>
    /// <value>Specifies the commitish value that will be the target for the release's tag. Required if the supplied tag_name does not reference an existing tag. Ignored if the tag_name already exists.</value>
    [DataMember(Name="target_commitish", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target_commitish")]
    public string TargetCommitish { get; set; }

    /// <summary>
    /// The name of the previous tag to use as the starting point for the release notes. Use to manually specify the range for the set of changes considered as part this release.
    /// </summary>
    /// <value>The name of the previous tag to use as the starting point for the release notes. Use to manually specify the range for the set of changes considered as part this release.</value>
    [DataMember(Name="previous_tag_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previous_tag_name")]
    public string PreviousTagName { get; set; }

    /// <summary>
    /// Specifies a path to a file in the repository containing configuration settings used for generating the release notes. If unspecified, the configuration file located in the repository at '.github/release.yml' or '.github/release.yaml' will be used. If that is not present, the default configuration will be used.
    /// </summary>
    /// <value>Specifies a path to a file in the repository containing configuration settings used for generating the release notes. If unspecified, the configuration file located in the repository at '.github/release.yml' or '.github/release.yaml' will be used. If that is not present, the default configuration will be used.</value>
    [DataMember(Name="configuration_file_path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configuration_file_path")]
    public string ConfigurationFilePath { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposGenerateReleaseNotesRequest {\n");
      sb.Append("  TagName: ").Append(TagName).Append("\n");
      sb.Append("  TargetCommitish: ").Append(TargetCommitish).Append("\n");
      sb.Append("  PreviousTagName: ").Append(PreviousTagName).Append("\n");
      sb.Append("  ConfigurationFilePath: ").Append(ConfigurationFilePath).Append("\n");
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
