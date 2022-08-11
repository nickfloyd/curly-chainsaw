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
  public class CommunityProfileFiles {
    /// <summary>
    /// Gets or Sets CodeOfConduct
    /// </summary>
    [DataMember(Name="code_of_conduct", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code_of_conduct")]
    public CodeOfConductSimple1 CodeOfConduct { get; set; }

    /// <summary>
    /// Gets or Sets CodeOfConductFile
    /// </summary>
    [DataMember(Name="code_of_conduct_file", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code_of_conduct_file")]
    public CommunityHealthFile CodeOfConductFile { get; set; }

    /// <summary>
    /// Gets or Sets License
    /// </summary>
    [DataMember(Name="license", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "license")]
    public LicenseSimple License { get; set; }

    /// <summary>
    /// Gets or Sets Contributing
    /// </summary>
    [DataMember(Name="contributing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contributing")]
    public CommunityHealthFile Contributing { get; set; }

    /// <summary>
    /// Gets or Sets Readme
    /// </summary>
    [DataMember(Name="readme", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readme")]
    public CommunityHealthFile Readme { get; set; }

    /// <summary>
    /// Gets or Sets IssueTemplate
    /// </summary>
    [DataMember(Name="issue_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issue_template")]
    public CommunityHealthFile IssueTemplate { get; set; }

    /// <summary>
    /// Gets or Sets PullRequestTemplate
    /// </summary>
    [DataMember(Name="pull_request_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pull_request_template")]
    public CommunityHealthFile PullRequestTemplate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CommunityProfileFiles {\n");
      sb.Append("  CodeOfConduct: ").Append(CodeOfConduct).Append("\n");
      sb.Append("  CodeOfConductFile: ").Append(CodeOfConductFile).Append("\n");
      sb.Append("  License: ").Append(License).Append("\n");
      sb.Append("  Contributing: ").Append(Contributing).Append("\n");
      sb.Append("  Readme: ").Append(Readme).Append("\n");
      sb.Append("  IssueTemplate: ").Append(IssueTemplate).Append("\n");
      sb.Append("  PullRequestTemplate: ").Append(PullRequestTemplate).Append("\n");
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
