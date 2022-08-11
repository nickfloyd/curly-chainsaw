using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Project cards represent a scope of work.
  /// </summary>
  [DataContract]
  public class ProjectCard {
    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// The project card's ID
    /// </summary>
    /// <value>The project card's ID</value>
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
    /// Gets or Sets Note
    /// </summary>
    [DataMember(Name="note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "note")]
    public string Note { get; set; }

    /// <summary>
    /// Gets or Sets Creator
    /// </summary>
    [DataMember(Name="creator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creator")]
    public SimpleUser Creator { get; set; }

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
    /// Whether or not the card is archived
    /// </summary>
    /// <value>Whether or not the card is archived</value>
    [DataMember(Name="archived", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "archived")]
    public bool? Archived { get; set; }

    /// <summary>
    /// Gets or Sets ColumnName
    /// </summary>
    [DataMember(Name="column_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "column_name")]
    public string ColumnName { get; set; }

    /// <summary>
    /// Gets or Sets ProjectId
    /// </summary>
    [DataMember(Name="project_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "project_id")]
    public string ProjectId { get; set; }

    /// <summary>
    /// Gets or Sets ColumnUrl
    /// </summary>
    [DataMember(Name="column_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "column_url")]
    public string ColumnUrl { get; set; }

    /// <summary>
    /// Gets or Sets ContentUrl
    /// </summary>
    [DataMember(Name="content_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content_url")]
    public string ContentUrl { get; set; }

    /// <summary>
    /// Gets or Sets ProjectUrl
    /// </summary>
    [DataMember(Name="project_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "project_url")]
    public string ProjectUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProjectCard {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  Note: ").Append(Note).Append("\n");
      sb.Append("  Creator: ").Append(Creator).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Archived: ").Append(Archived).Append("\n");
      sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
      sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
      sb.Append("  ColumnUrl: ").Append(ColumnUrl).Append("\n");
      sb.Append("  ContentUrl: ").Append(ContentUrl).Append("\n");
      sb.Append("  ProjectUrl: ").Append(ProjectUrl).Append("\n");
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
