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
  public class OrganizationFullPlan {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Space
    /// </summary>
    [DataMember(Name="space", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "space")]
    public int? Space { get; set; }

    /// <summary>
    /// Gets or Sets PrivateRepos
    /// </summary>
    [DataMember(Name="private_repos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "private_repos")]
    public int? PrivateRepos { get; set; }

    /// <summary>
    /// Gets or Sets FilledSeats
    /// </summary>
    [DataMember(Name="filled_seats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filled_seats")]
    public int? FilledSeats { get; set; }

    /// <summary>
    /// Gets or Sets Seats
    /// </summary>
    [DataMember(Name="seats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seats")]
    public int? Seats { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrganizationFullPlan {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Space: ").Append(Space).Append("\n");
      sb.Append("  PrivateRepos: ").Append(PrivateRepos).Append("\n");
      sb.Append("  FilledSeats: ").Append(FilledSeats).Append("\n");
      sb.Append("  Seats: ").Append(Seats).Append("\n");
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
