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
  public class AddedToProjectIssueEventProjectCard {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets ProjectId
    /// </summary>
    [DataMember(Name="project_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "project_id")]
    public int? ProjectId { get; set; }

    /// <summary>
    /// Gets or Sets ProjectUrl
    /// </summary>
    [DataMember(Name="project_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "project_url")]
    public string ProjectUrl { get; set; }

    /// <summary>
    /// Gets or Sets ColumnName
    /// </summary>
    [DataMember(Name="column_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "column_name")]
    public string ColumnName { get; set; }

    /// <summary>
    /// Gets or Sets PreviousColumnName
    /// </summary>
    [DataMember(Name="previous_column_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previous_column_name")]
    public string PreviousColumnName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AddedToProjectIssueEventProjectCard {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
      sb.Append("  ProjectUrl: ").Append(ProjectUrl).Append("\n");
      sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
      sb.Append("  PreviousColumnName: ").Append(PreviousColumnName).Append("\n");
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
