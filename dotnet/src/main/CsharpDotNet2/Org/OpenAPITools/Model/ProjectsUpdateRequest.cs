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
  public class ProjectsUpdateRequest {
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
    /// State of the project; either 'open' or 'closed'
    /// </summary>
    /// <value>State of the project; either 'open' or 'closed'</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// The baseline permission that all organization members have on this project
    /// </summary>
    /// <value>The baseline permission that all organization members have on this project</value>
    [DataMember(Name="organization_permission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organization_permission")]
    public string OrganizationPermission { get; set; }

    /// <summary>
    /// Whether or not this project can be seen by everyone.
    /// </summary>
    /// <value>Whether or not this project can be seen by everyone.</value>
    [DataMember(Name="private", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "private")]
    public bool? Private { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProjectsUpdateRequest {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
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
