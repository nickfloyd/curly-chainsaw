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
  public class FeedLinks {
    /// <summary>
    /// Gets or Sets Timeline
    /// </summary>
    [DataMember(Name="timeline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeline")]
    public LinkWithType Timeline { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public LinkWithType User { get; set; }

    /// <summary>
    /// Gets or Sets SecurityAdvisories
    /// </summary>
    [DataMember(Name="security_advisories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "security_advisories")]
    public LinkWithType SecurityAdvisories { get; set; }

    /// <summary>
    /// Gets or Sets CurrentUser
    /// </summary>
    [DataMember(Name="current_user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "current_user")]
    public LinkWithType CurrentUser { get; set; }

    /// <summary>
    /// Gets or Sets CurrentUserPublic
    /// </summary>
    [DataMember(Name="current_user_public", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "current_user_public")]
    public LinkWithType CurrentUserPublic { get; set; }

    /// <summary>
    /// Gets or Sets CurrentUserActor
    /// </summary>
    [DataMember(Name="current_user_actor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "current_user_actor")]
    public LinkWithType CurrentUserActor { get; set; }

    /// <summary>
    /// Gets or Sets CurrentUserOrganization
    /// </summary>
    [DataMember(Name="current_user_organization", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "current_user_organization")]
    public LinkWithType CurrentUserOrganization { get; set; }

    /// <summary>
    /// Gets or Sets CurrentUserOrganizations
    /// </summary>
    [DataMember(Name="current_user_organizations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "current_user_organizations")]
    public List<LinkWithType> CurrentUserOrganizations { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeedLinks {\n");
      sb.Append("  Timeline: ").Append(Timeline).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  SecurityAdvisories: ").Append(SecurityAdvisories).Append("\n");
      sb.Append("  CurrentUser: ").Append(CurrentUser).Append("\n");
      sb.Append("  CurrentUserPublic: ").Append(CurrentUserPublic).Append("\n");
      sb.Append("  CurrentUserActor: ").Append(CurrentUserActor).Append("\n");
      sb.Append("  CurrentUserOrganization: ").Append(CurrentUserOrganization).Append("\n");
      sb.Append("  CurrentUserOrganizations: ").Append(CurrentUserOrganizations).Append("\n");
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
