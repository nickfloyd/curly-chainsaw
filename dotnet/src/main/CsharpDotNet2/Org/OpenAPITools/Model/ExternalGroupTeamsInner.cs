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
  public class ExternalGroupTeamsInner {
    /// <summary>
    /// The id for a team
    /// </summary>
    /// <value>The id for a team</value>
    [DataMember(Name="team_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "team_id")]
    public int? TeamId { get; set; }

    /// <summary>
    /// The name of the team
    /// </summary>
    /// <value>The name of the team</value>
    [DataMember(Name="team_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "team_name")]
    public string TeamName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExternalGroupTeamsInner {\n");
      sb.Append("  TeamId: ").Append(TeamId).Append("\n");
      sb.Append("  TeamName: ").Append(TeamName).Append("\n");
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
