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
  public class BillingGetGithubActionsBillingGhe200Response {
    /// <summary>
    /// The sum of the free and paid GitHub Actions minutes used.
    /// </summary>
    /// <value>The sum of the free and paid GitHub Actions minutes used.</value>
    [DataMember(Name="total_minutes_used", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_minutes_used")]
    public int? TotalMinutesUsed { get; set; }

    /// <summary>
    /// The total paid GitHub Actions minutes used.
    /// </summary>
    /// <value>The total paid GitHub Actions minutes used.</value>
    [DataMember(Name="total_paid_minutes_used", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_paid_minutes_used")]
    public int? TotalPaidMinutesUsed { get; set; }

    /// <summary>
    /// The amount of free GitHub Actions minutes available.
    /// </summary>
    /// <value>The amount of free GitHub Actions minutes available.</value>
    [DataMember(Name="included_minutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "included_minutes")]
    public int? IncludedMinutes { get; set; }

    /// <summary>
    /// Gets or Sets MinutesUsedBreakdown
    /// </summary>
    [DataMember(Name="minutes_used_breakdown", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minutes_used_breakdown")]
    public BillingGetGithubActionsBillingGhe200ResponseMinutesUsedBreakdown MinutesUsedBreakdown { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BillingGetGithubActionsBillingGhe200Response {\n");
      sb.Append("  TotalMinutesUsed: ").Append(TotalMinutesUsed).Append("\n");
      sb.Append("  TotalPaidMinutesUsed: ").Append(TotalPaidMinutesUsed).Append("\n");
      sb.Append("  IncludedMinutes: ").Append(IncludedMinutes).Append("\n");
      sb.Append("  MinutesUsedBreakdown: ").Append(MinutesUsedBreakdown).Append("\n");
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
