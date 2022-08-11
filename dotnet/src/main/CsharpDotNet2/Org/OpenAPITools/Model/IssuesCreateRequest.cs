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
  public class IssuesCreateRequest {
    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public IssuesCreateRequestTitle Title { get; set; }

    /// <summary>
    /// The contents of the issue.
    /// </summary>
    /// <value>The contents of the issue.</value>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public string Body { get; set; }

    /// <summary>
    /// Login for the user that this issue should be assigned to. _NOTE: Only users with push access can set the assignee for new issues. The assignee is silently dropped otherwise. **This field is deprecated.**_
    /// </summary>
    /// <value>Login for the user that this issue should be assigned to. _NOTE: Only users with push access can set the assignee for new issues. The assignee is silently dropped otherwise. **This field is deprecated.**_</value>
    [DataMember(Name="assignee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assignee")]
    public string Assignee { get; set; }

    /// <summary>
    /// Gets or Sets Milestone
    /// </summary>
    [DataMember(Name="milestone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "milestone")]
    public IssuesCreateRequestMilestone Milestone { get; set; }

    /// <summary>
    /// Labels to associate with this issue. _NOTE: Only users with push access can set labels for new issues. Labels are silently dropped otherwise._
    /// </summary>
    /// <value>Labels to associate with this issue. _NOTE: Only users with push access can set labels for new issues. Labels are silently dropped otherwise._</value>
    [DataMember(Name="labels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labels")]
    public List<IssuesCreateRequestLabelsInner> Labels { get; set; }

    /// <summary>
    /// Logins for Users to assign to this issue. _NOTE: Only users with push access can set assignees for new issues. Assignees are silently dropped otherwise._
    /// </summary>
    /// <value>Logins for Users to assign to this issue. _NOTE: Only users with push access can set assignees for new issues. Assignees are silently dropped otherwise._</value>
    [DataMember(Name="assignees", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assignees")]
    public List<string> Assignees { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssuesCreateRequest {\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  Assignee: ").Append(Assignee).Append("\n");
      sb.Append("  Milestone: ").Append(Milestone).Append("\n");
      sb.Append("  Labels: ").Append(Labels).Append("\n");
      sb.Append("  Assignees: ").Append(Assignees).Append("\n");
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
