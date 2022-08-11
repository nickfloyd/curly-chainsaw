using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Actor
  /// </summary>
  [DataContract]
  public class Actor {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Login
    /// </summary>
    [DataMember(Name="login", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "login")]
    public string Login { get; set; }

    /// <summary>
    /// Gets or Sets DisplayLogin
    /// </summary>
    [DataMember(Name="display_login", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display_login")]
    public string DisplayLogin { get; set; }

    /// <summary>
    /// Gets or Sets GravatarId
    /// </summary>
    [DataMember(Name="gravatar_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gravatar_id")]
    public string GravatarId { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets AvatarUrl
    /// </summary>
    [DataMember(Name="avatar_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avatar_url")]
    public string AvatarUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Actor {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Login: ").Append(Login).Append("\n");
      sb.Append("  DisplayLogin: ").Append(DisplayLogin).Append("\n");
      sb.Append("  GravatarId: ").Append(GravatarId).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
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
