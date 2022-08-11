using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Projects are a way to organize columns and cards of work.
  /// </summary>
  [DataContract]
  public class Project {
    /// <summary>
    /// Gets or Sets OwnerUrl
    /// </summary>
    [DataMember(Name="owner_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner_url")]
    public string OwnerUrl { get; set; }

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
    /// Gets or Sets ColumnsUrl
    /// </summary>
    [DataMember(Name="columns_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "columns_url")]
    public string ColumnsUrl { get; set; }

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
    /// Name of the project
    /// </summary>
    /// <value>Name of the project</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Body of the project
    /// </summary>
    /// <value>Body of the project</value>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public string Body { get; set; }

    /// <summary>
    /// Gets or Sets Number
    /// </summary>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public int? Number { get; set; }

    /// <summary>
    /// State of the project; either 'open' or 'closed'
    /// </summary>
    /// <value>State of the project; either 'open' or 'closed'</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

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
    /// The baseline permission that all organization members have on this project. Only present if owner is an organization.
    /// </summary>
    /// <value>The baseline permission that all organization members have on this project. Only present if owner is an organization.</value>
    [DataMember(Name="organization_permission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organization_permission")]
    public string OrganizationPermission { get; set; }

    /// <summary>
    /// Whether or not this project can be seen by everyone. Only present if owner is an organization.
    /// </summary>
    /// <value>Whether or not this project can be seen by everyone. Only present if owner is an organization.</value>
    [DataMember(Name="private", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "private")]
    public bool? Private { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Project {\n");
      sb.Append("  OwnerUrl: ").Append(OwnerUrl).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  ColumnsUrl: ").Append(ColumnsUrl).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Creator: ").Append(Creator).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  OrganizationPermission: ").Append(OrganizationPermission).Append("\n");
      sb.Append("  Private: ").Append(Private).Append("\n");
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
