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
  public class BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInnerAdvancedSecurityCommittersBreakdownInner {
    /// <summary>
    /// Gets or Sets UserLogin
    /// </summary>
    [DataMember(Name="user_login", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_login")]
    public string UserLogin { get; set; }

    /// <summary>
    /// Gets or Sets LastPushedDate
    /// </summary>
    [DataMember(Name="last_pushed_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_pushed_date")]
    public string LastPushedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInnerAdvancedSecurityCommittersBreakdownInner {\n");
      sb.Append("  UserLogin: ").Append(UserLogin).Append("\n");
      sb.Append("  LastPushedDate: ").Append(LastPushedDate).Append("\n");
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
