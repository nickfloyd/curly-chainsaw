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
  public class ReposTransferRequest {
    /// <summary>
    /// The username or organization name the repository will be transferred to.
    /// </summary>
    /// <value>The username or organization name the repository will be transferred to.</value>
    [DataMember(Name="new_owner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "new_owner")]
    public string NewOwner { get; set; }

    /// <summary>
    /// ID of the team or teams to add to the repository. Teams can only be added to organization-owned repositories.
    /// </summary>
    /// <value>ID of the team or teams to add to the repository. Teams can only be added to organization-owned repositories.</value>
    [DataMember(Name="team_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "team_ids")]
    public List<int?> TeamIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposTransferRequest {\n");
      sb.Append("  NewOwner: ").Append(NewOwner).Append("\n");
      sb.Append("  TeamIds: ").Append(TeamIds).Append("\n");
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
