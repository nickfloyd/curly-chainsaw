using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Secrets for GitHub Dependabot for an organization.
  /// </summary>
  [DataContract]
  public class DependabotSecretForAnOrganization {
    /// <summary>
    /// The name of the secret.
    /// </summary>
    /// <value>The name of the secret.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

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
    /// Visibility of a secret
    /// </summary>
    /// <value>Visibility of a secret</value>
    [DataMember(Name="visibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibility")]
    public string Visibility { get; set; }

    /// <summary>
    /// Gets or Sets SelectedRepositoriesUrl
    /// </summary>
    [DataMember(Name="selected_repositories_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selected_repositories_url")]
    public string SelectedRepositoriesUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DependabotSecretForAnOrganization {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Visibility: ").Append(Visibility).Append("\n");
      sb.Append("  SelectedRepositoriesUrl: ").Append(SelectedRepositoriesUrl).Append("\n");
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
