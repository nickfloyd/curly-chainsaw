using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Feed
  /// </summary>
  [DataContract]
  public class Feed {
    /// <summary>
    /// Gets or Sets TimelineUrl
    /// </summary>
    [DataMember(Name="timeline_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeline_url")]
    public string TimelineUrl { get; set; }

    /// <summary>
    /// Gets or Sets UserUrl
    /// </summary>
    [DataMember(Name="user_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_url")]
    public string UserUrl { get; set; }

    /// <summary>
    /// Gets or Sets CurrentUserPublicUrl
    /// </summary>
    [DataMember(Name="current_user_public_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "current_user_public_url")]
    public string CurrentUserPublicUrl { get; set; }

    /// <summary>
    /// Gets or Sets CurrentUserUrl
    /// </summary>
    [DataMember(Name="current_user_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "current_user_url")]
    public string CurrentUserUrl { get; set; }

    /// <summary>
    /// Gets or Sets CurrentUserActorUrl
    /// </summary>
    [DataMember(Name="current_user_actor_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "current_user_actor_url")]
    public string CurrentUserActorUrl { get; set; }

    /// <summary>
    /// Gets or Sets CurrentUserOrganizationUrl
    /// </summary>
    [DataMember(Name="current_user_organization_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "current_user_organization_url")]
    public string CurrentUserOrganizationUrl { get; set; }

    /// <summary>
    /// Gets or Sets CurrentUserOrganizationUrls
    /// </summary>
    [DataMember(Name="current_user_organization_urls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "current_user_organization_urls")]
    public List<string> CurrentUserOrganizationUrls { get; set; }

    /// <summary>
    /// Gets or Sets SecurityAdvisoriesUrl
    /// </summary>
    [DataMember(Name="security_advisories_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "security_advisories_url")]
    public string SecurityAdvisoriesUrl { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="_links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_links")]
    public FeedLinks Links { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Feed {\n");
      sb.Append("  TimelineUrl: ").Append(TimelineUrl).Append("\n");
      sb.Append("  UserUrl: ").Append(UserUrl).Append("\n");
      sb.Append("  CurrentUserPublicUrl: ").Append(CurrentUserPublicUrl).Append("\n");
      sb.Append("  CurrentUserUrl: ").Append(CurrentUserUrl).Append("\n");
      sb.Append("  CurrentUserActorUrl: ").Append(CurrentUserActorUrl).Append("\n");
      sb.Append("  CurrentUserOrganizationUrl: ").Append(CurrentUserOrganizationUrl).Append("\n");
      sb.Append("  CurrentUserOrganizationUrls: ").Append(CurrentUserOrganizationUrls).Append("\n");
      sb.Append("  SecurityAdvisoriesUrl: ").Append(SecurityAdvisoriesUrl).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
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
