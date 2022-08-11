using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Groups of organization members that gives permissions on specified repositories.
  /// </summary>
  [DataContract]
  public class TeamSimple1 {
    /// <summary>
    /// Unique identifier of the team
    /// </summary>
    /// <value>Unique identifier of the team</value>
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
    /// URL for the team
    /// </summary>
    /// <value>URL for the team</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets MembersUrl
    /// </summary>
    [DataMember(Name="members_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members_url")]
    public string MembersUrl { get; set; }

    /// <summary>
    /// Name of the team
    /// </summary>
    /// <value>Name of the team</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Description of the team
    /// </summary>
    /// <value>Description of the team</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Permission that the team will have for its repositories
    /// </summary>
    /// <value>Permission that the team will have for its repositories</value>
    [DataMember(Name="permission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permission")]
    public string Permission { get; set; }

    /// <summary>
    /// The level of privacy this team should have
    /// </summary>
    /// <value>The level of privacy this team should have</value>
    [DataMember(Name="privacy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "privacy")]
    public string Privacy { get; set; }

    /// <summary>
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Gets or Sets RepositoriesUrl
    /// </summary>
    [DataMember(Name="repositories_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repositories_url")]
    public string RepositoriesUrl { get; set; }

    /// <summary>
    /// Gets or Sets Slug
    /// </summary>
    [DataMember(Name="slug", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "slug")]
    public string Slug { get; set; }

    /// <summary>
    /// Distinguished Name (DN) that team maps to within LDAP environment
    /// </summary>
    /// <value>Distinguished Name (DN) that team maps to within LDAP environment</value>
    [DataMember(Name="ldap_dn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ldap_dn")]
    public string LdapDn { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TeamSimple1 {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  MembersUrl: ").Append(MembersUrl).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Permission: ").Append(Permission).Append("\n");
      sb.Append("  Privacy: ").Append(Privacy).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  RepositoriesUrl: ").Append(RepositoriesUrl).Append("\n");
      sb.Append("  Slug: ").Append(Slug).Append("\n");
      sb.Append("  LdapDn: ").Append(LdapDn).Append("\n");
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
