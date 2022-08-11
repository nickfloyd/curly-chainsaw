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
  public class PullsCreateRequest {
    /// <summary>
    /// The title of the new pull request. Required unless `issue` is specified.
    /// </summary>
    /// <value>The title of the new pull request. Required unless `issue` is specified.</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// The name of the branch where your changes are implemented. For cross-repository pull requests in the same network, namespace `head` with a user like this: `username:branch`.
    /// </summary>
    /// <value>The name of the branch where your changes are implemented. For cross-repository pull requests in the same network, namespace `head` with a user like this: `username:branch`.</value>
    [DataMember(Name="head", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "head")]
    public string Head { get; set; }

    /// <summary>
    /// The name of the branch you want the changes pulled into. This should be an existing branch on the current repository. You cannot submit a pull request to one repository that requests a merge to a base of another repository.
    /// </summary>
    /// <value>The name of the branch you want the changes pulled into. This should be an existing branch on the current repository. You cannot submit a pull request to one repository that requests a merge to a base of another repository.</value>
    [DataMember(Name="base", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "base")]
    public string Base { get; set; }

    /// <summary>
    /// The contents of the pull request.
    /// </summary>
    /// <value>The contents of the pull request.</value>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public string Body { get; set; }

    /// <summary>
    /// Indicates whether [maintainers can modify](https://docs.github.com/articles/allowing-changes-to-a-pull-request-branch-created-from-a-fork/) the pull request.
    /// </summary>
    /// <value>Indicates whether [maintainers can modify](https://docs.github.com/articles/allowing-changes-to-a-pull-request-branch-created-from-a-fork/) the pull request.</value>
    [DataMember(Name="maintainer_can_modify", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maintainer_can_modify")]
    public bool? MaintainerCanModify { get; set; }

    /// <summary>
    /// Indicates whether the pull request is a draft. See \"[Draft Pull Requests](https://docs.github.com/en/articles/about-pull-requests#draft-pull-requests)\" in the GitHub Help documentation to learn more.
    /// </summary>
    /// <value>Indicates whether the pull request is a draft. See \"[Draft Pull Requests](https://docs.github.com/en/articles/about-pull-requests#draft-pull-requests)\" in the GitHub Help documentation to learn more.</value>
    [DataMember(Name="draft", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "draft")]
    public bool? Draft { get; set; }

    /// <summary>
    /// An issue in the repository to convert to a pull request. The issue title, body, and comments will become the title, body, and comments on the new pull request. Required unless `title` is specified.
    /// </summary>
    /// <value>An issue in the repository to convert to a pull request. The issue title, body, and comments will become the title, body, and comments on the new pull request. Required unless `title` is specified.</value>
    [DataMember(Name="issue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issue")]
    public int? Issue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PullsCreateRequest {\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Head: ").Append(Head).Append("\n");
      sb.Append("  Base: ").Append(Base).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  MaintainerCanModify: ").Append(MaintainerCanModify).Append("\n");
      sb.Append("  Draft: ").Append(Draft).Append("\n");
      sb.Append("  Issue: ").Append(Issue).Append("\n");
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
