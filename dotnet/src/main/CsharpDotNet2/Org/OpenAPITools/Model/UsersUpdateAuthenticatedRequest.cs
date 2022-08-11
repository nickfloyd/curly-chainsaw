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
  public class UsersUpdateAuthenticatedRequest {
    /// <summary>
    /// The new name of the user.
    /// </summary>
    /// <value>The new name of the user.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The publicly visible email address of the user.
    /// </summary>
    /// <value>The publicly visible email address of the user.</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// The new blog URL of the user.
    /// </summary>
    /// <value>The new blog URL of the user.</value>
    [DataMember(Name="blog", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blog")]
    public string Blog { get; set; }

    /// <summary>
    /// The new Twitter username of the user.
    /// </summary>
    /// <value>The new Twitter username of the user.</value>
    [DataMember(Name="twitter_username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "twitter_username")]
    public string TwitterUsername { get; set; }

    /// <summary>
    /// The new company of the user.
    /// </summary>
    /// <value>The new company of the user.</value>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public string Company { get; set; }

    /// <summary>
    /// The new location of the user.
    /// </summary>
    /// <value>The new location of the user.</value>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    /// <summary>
    /// The new hiring availability of the user.
    /// </summary>
    /// <value>The new hiring availability of the user.</value>
    [DataMember(Name="hireable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hireable")]
    public bool? Hireable { get; set; }

    /// <summary>
    /// The new short biography of the user.
    /// </summary>
    /// <value>The new short biography of the user.</value>
    [DataMember(Name="bio", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bio")]
    public string Bio { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UsersUpdateAuthenticatedRequest {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Blog: ").Append(Blog).Append("\n");
      sb.Append("  TwitterUsername: ").Append(TwitterUsername).Append("\n");
      sb.Append("  Company: ").Append(Company).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  Hireable: ").Append(Hireable).Append("\n");
      sb.Append("  Bio: ").Append(Bio).Append("\n");
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
