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
  public class PullsUpdateRequest {
    /// <summary>
    /// The title of the pull request.
    /// </summary>
    /// <value>The title of the pull request.</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// The contents of the pull request.
    /// </summary>
    /// <value>The contents of the pull request.</value>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public string Body { get; set; }

    /// <summary>
    /// State of this Pull Request. Either `open` or `closed`.
    /// </summary>
    /// <value>State of this Pull Request. Either `open` or `closed`.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// The name of the branch you want your changes pulled into. This should be an existing branch on the current repository. You cannot update the base branch on a pull request to point to another repository.
    /// </summary>
    /// <value>The name of the branch you want your changes pulled into. This should be an existing branch on the current repository. You cannot update the base branch on a pull request to point to another repository.</value>
    [DataMember(Name="base", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "base")]
    public string Base { get; set; }

    /// <summary>
    /// Indicates whether [maintainers can modify](https://docs.github.com/articles/allowing-changes-to-a-pull-request-branch-created-from-a-fork/) the pull request.
    /// </summary>
    /// <value>Indicates whether [maintainers can modify](https://docs.github.com/articles/allowing-changes-to-a-pull-request-branch-created-from-a-fork/) the pull request.</value>
    [DataMember(Name="maintainer_can_modify", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maintainer_can_modify")]
    public bool? MaintainerCanModify { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PullsUpdateRequest {\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Base: ").Append(Base).Append("\n");
      sb.Append("  MaintainerCanModify: ").Append(MaintainerCanModify).Append("\n");
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
