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
  public class ArtifactWorkflowRun {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets RepositoryId
    /// </summary>
    [DataMember(Name="repository_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository_id")]
    public int? RepositoryId { get; set; }

    /// <summary>
    /// Gets or Sets HeadRepositoryId
    /// </summary>
    [DataMember(Name="head_repository_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "head_repository_id")]
    public int? HeadRepositoryId { get; set; }

    /// <summary>
    /// Gets or Sets HeadBranch
    /// </summary>
    [DataMember(Name="head_branch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "head_branch")]
    public string HeadBranch { get; set; }

    /// <summary>
    /// Gets or Sets HeadSha
    /// </summary>
    [DataMember(Name="head_sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "head_sha")]
    public string HeadSha { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ArtifactWorkflowRun {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  RepositoryId: ").Append(RepositoryId).Append("\n");
      sb.Append("  HeadRepositoryId: ").Append(HeadRepositoryId).Append("\n");
      sb.Append("  HeadBranch: ").Append(HeadBranch).Append("\n");
      sb.Append("  HeadSha: ").Append(HeadSha).Append("\n");
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
