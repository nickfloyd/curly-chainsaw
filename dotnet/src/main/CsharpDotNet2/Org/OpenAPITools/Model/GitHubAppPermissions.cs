using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The set of permissions for the GitHub app
  /// </summary>
  [DataContract]
  public class GitHubAppPermissions : Dictionary<String, string> {
    /// <summary>
    /// Gets or Sets Issues
    /// </summary>
    [DataMember(Name="issues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issues")]
    public string Issues { get; set; }

    /// <summary>
    /// Gets or Sets Checks
    /// </summary>
    [DataMember(Name="checks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checks")]
    public string Checks { get; set; }

    /// <summary>
    /// Gets or Sets Metadata
    /// </summary>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public string Metadata { get; set; }

    /// <summary>
    /// Gets or Sets Contents
    /// </summary>
    [DataMember(Name="contents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contents")]
    public string Contents { get; set; }

    /// <summary>
    /// Gets or Sets Deployments
    /// </summary>
    [DataMember(Name="deployments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deployments")]
    public string Deployments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GitHubAppPermissions {\n");
      sb.Append("  Issues: ").Append(Issues).Append("\n");
      sb.Append("  Checks: ").Append(Checks).Append("\n");
      sb.Append("  Metadata: ").Append(Metadata).Append("\n");
      sb.Append("  Contents: ").Append(Contents).Append("\n");
      sb.Append("  Deployments: ").Append(Deployments).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
    }

}
}
