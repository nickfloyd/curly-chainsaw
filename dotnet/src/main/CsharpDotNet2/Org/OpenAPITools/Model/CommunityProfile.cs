using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Community Profile
  /// </summary>
  [DataContract]
  public class CommunityProfile {
    /// <summary>
    /// Gets or Sets HealthPercentage
    /// </summary>
    [DataMember(Name="health_percentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "health_percentage")]
    public int? HealthPercentage { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Documentation
    /// </summary>
    [DataMember(Name="documentation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentation")]
    public string Documentation { get; set; }

    /// <summary>
    /// Gets or Sets Files
    /// </summary>
    [DataMember(Name="files", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "files")]
    public CommunityProfileFiles Files { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedAt
    /// </summary>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets or Sets ContentReportsEnabled
    /// </summary>
    [DataMember(Name="content_reports_enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content_reports_enabled")]
    public bool? ContentReportsEnabled { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CommunityProfile {\n");
      sb.Append("  HealthPercentage: ").Append(HealthPercentage).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Documentation: ").Append(Documentation).Append("\n");
      sb.Append("  Files: ").Append(Files).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  ContentReportsEnabled: ").Append(ContentReportsEnabled).Append("\n");
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
