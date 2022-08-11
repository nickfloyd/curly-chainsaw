using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Limit interactions to a specific type of user for a specified duration
  /// </summary>
  [DataContract]
  public class InteractionRestrictions {
    /// <summary>
    /// The type of GitHub user that can comment, open issues, or create pull requests while the interaction limit is in effect.
    /// </summary>
    /// <value>The type of GitHub user that can comment, open issues, or create pull requests while the interaction limit is in effect.</value>
    [DataMember(Name="limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limit")]
    public string Limit { get; set; }

    /// <summary>
    /// The duration of the interaction restriction. Default: `one_day`.
    /// </summary>
    /// <value>The duration of the interaction restriction. Default: `one_day`.</value>
    [DataMember(Name="expiry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiry")]
    public string Expiry { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InteractionRestrictions {\n");
      sb.Append("  Limit: ").Append(Limit).Append("\n");
      sb.Append("  Expiry: ").Append(Expiry).Append("\n");
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
