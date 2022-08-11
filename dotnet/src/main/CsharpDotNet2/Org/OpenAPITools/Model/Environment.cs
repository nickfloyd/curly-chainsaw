using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Details of a deployment environment
  /// </summary>
  [DataContract]
  public class Environment {
    /// <summary>
    /// The id of the environment.
    /// </summary>
    /// <value>The id of the environment.</value>
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
    /// The name of the environment.
    /// </summary>
    /// <value>The name of the environment.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

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
    /// The time that the environment was created, in ISO 8601 format.
    /// </summary>
    /// <value>The time that the environment was created, in ISO 8601 format.</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The time that the environment was last updated, in ISO 8601 format.
    /// </summary>
    /// <value>The time that the environment was last updated, in ISO 8601 format.</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets or Sets ProtectionRules
    /// </summary>
    [DataMember(Name="protection_rules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protection_rules")]
    public List<EnvironmentProtectionRulesInner> ProtectionRules { get; set; }

    /// <summary>
    /// Gets or Sets DeploymentBranchPolicy
    /// </summary>
    [DataMember(Name="deployment_branch_policy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deployment_branch_policy")]
    public EnvironmentDeploymentBranchPolicy DeploymentBranchPolicy { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Environment {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  ProtectionRules: ").Append(ProtectionRules).Append("\n");
      sb.Append("  DeploymentBranchPolicy: ").Append(DeploymentBranchPolicy).Append("\n");
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
