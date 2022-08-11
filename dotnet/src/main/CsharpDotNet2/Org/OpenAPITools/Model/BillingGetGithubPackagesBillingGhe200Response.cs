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
  public class BillingGetGithubPackagesBillingGhe200Response {
    /// <summary>
    /// Sum of the free and paid storage space (GB) for GitHuub Packages.
    /// </summary>
    /// <value>Sum of the free and paid storage space (GB) for GitHuub Packages.</value>
    [DataMember(Name="total_gigabytes_bandwidth_used", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_gigabytes_bandwidth_used")]
    public int? TotalGigabytesBandwidthUsed { get; set; }

    /// <summary>
    /// Total paid storage space (GB) for GitHuub Packages.
    /// </summary>
    /// <value>Total paid storage space (GB) for GitHuub Packages.</value>
    [DataMember(Name="total_paid_gigabytes_bandwidth_used", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_paid_gigabytes_bandwidth_used")]
    public int? TotalPaidGigabytesBandwidthUsed { get; set; }

    /// <summary>
    /// Free storage space (GB) for GitHub Packages.
    /// </summary>
    /// <value>Free storage space (GB) for GitHub Packages.</value>
    [DataMember(Name="included_gigabytes_bandwidth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "included_gigabytes_bandwidth")]
    public int? IncludedGigabytesBandwidth { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BillingGetGithubPackagesBillingGhe200Response {\n");
      sb.Append("  TotalGigabytesBandwidthUsed: ").Append(TotalGigabytesBandwidthUsed).Append("\n");
      sb.Append("  TotalPaidGigabytesBandwidthUsed: ").Append(TotalPaidGigabytesBandwidthUsed).Append("\n");
      sb.Append("  IncludedGigabytesBandwidth: ").Append(IncludedGigabytesBandwidth).Append("\n");
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
