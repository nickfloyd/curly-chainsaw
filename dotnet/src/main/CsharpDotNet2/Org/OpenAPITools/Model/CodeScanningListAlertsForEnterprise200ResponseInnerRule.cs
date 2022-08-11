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
  public class CodeScanningListAlertsForEnterprise200ResponseInnerRule {
    /// <summary>
    /// A unique identifier for the rule used to detect the alert.
    /// </summary>
    /// <value>A unique identifier for the rule used to detect the alert.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The name of the rule used to detect the alert.
    /// </summary>
    /// <value>The name of the rule used to detect the alert.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The severity of the alert.
    /// </summary>
    /// <value>The severity of the alert.</value>
    [DataMember(Name="severity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "severity")]
    public string Severity { get; set; }

    /// <summary>
    /// The security severity of the alert.
    /// </summary>
    /// <value>The security severity of the alert.</value>
    [DataMember(Name="security_severity_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "security_severity_level")]
    public string SecuritySeverityLevel { get; set; }

    /// <summary>
    /// A short description of the rule used to detect the alert.
    /// </summary>
    /// <value>A short description of the rule used to detect the alert.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// description of the rule used to detect the alert.
    /// </summary>
    /// <value>description of the rule used to detect the alert.</value>
    [DataMember(Name="full_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "full_description")]
    public string FullDescription { get; set; }

    /// <summary>
    /// A set of tags applicable for the rule.
    /// </summary>
    /// <value>A set of tags applicable for the rule.</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// Detailed documentation for the rule as GitHub Flavored Markdown.
    /// </summary>
    /// <value>Detailed documentation for the rule as GitHub Flavored Markdown.</value>
    [DataMember(Name="help", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "help")]
    public string Help { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CodeScanningListAlertsForEnterprise200ResponseInnerRule {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Severity: ").Append(Severity).Append("\n");
      sb.Append("  SecuritySeverityLevel: ").Append(SecuritySeverityLevel).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  FullDescription: ").Append(FullDescription).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  Help: ").Append(Help).Append("\n");
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
