using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Check suite configuration preferences for a repository.
  /// </summary>
  [DataContract]
  public class CheckSuitePreference {
    /// <summary>
    /// Gets or Sets Preferences
    /// </summary>
    [DataMember(Name="preferences", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "preferences")]
    public CheckSuitePreferencePreferences Preferences { get; set; }

    /// <summary>
    /// Gets or Sets Repository
    /// </summary>
    [DataMember(Name="repository", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository")]
    public MinimalRepository Repository { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckSuitePreference {\n");
      sb.Append("  Preferences: ").Append(Preferences).Append("\n");
      sb.Append("  Repository: ").Append(Repository).Append("\n");
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
