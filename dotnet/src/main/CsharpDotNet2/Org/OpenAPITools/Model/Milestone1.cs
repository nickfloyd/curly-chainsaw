using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// A collection of related issues and pull requests.
  /// </summary>
  [DataContract]
  public class Milestone1 {
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
    /// Gets or Sets LabelsUrl
    /// </summary>
    [DataMember(Name="labels_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labels_url")]
    public string LabelsUrl { get; set; }

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
    /// The number of the milestone.
    /// </summary>
    /// <value>The number of the milestone.</value>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public int? Number { get; set; }

    /// <summary>
    /// The state of the milestone.
    /// </summary>
    /// <value>The state of the milestone.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// The title of the milestone.
    /// </summary>
    /// <value>The title of the milestone.</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Creator
    /// </summary>
    [DataMember(Name="creator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creator")]
    public SimpleUser Creator { get; set; }

    /// <summary>
    /// Gets or Sets OpenIssues
    /// </summary>
    [DataMember(Name="open_issues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "open_issues")]
    public int? OpenIssues { get; set; }

    /// <summary>
    /// Gets or Sets ClosedIssues
    /// </summary>
    [DataMember(Name="closed_issues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closed_issues")]
    public int? ClosedIssues { get; set; }

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
    /// Gets or Sets ClosedAt
    /// </summary>
    [DataMember(Name="closed_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closed_at")]
    public DateTime? ClosedAt { get; set; }

    /// <summary>
    /// Gets or Sets DueOn
    /// </summary>
    [DataMember(Name="due_on", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "due_on")]
    public DateTime? DueOn { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Milestone1 {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  LabelsUrl: ").Append(LabelsUrl).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Creator: ").Append(Creator).Append("\n");
      sb.Append("  OpenIssues: ").Append(OpenIssues).Append("\n");
      sb.Append("  ClosedIssues: ").Append(ClosedIssues).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  ClosedAt: ").Append(ClosedAt).Append("\n");
      sb.Append("  DueOn: ").Append(DueOn).Append("\n");
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
