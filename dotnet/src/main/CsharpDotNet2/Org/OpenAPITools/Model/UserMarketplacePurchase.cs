using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// User Marketplace Purchase
  /// </summary>
  [DataContract]
  public class UserMarketplacePurchase {
    /// <summary>
    /// Gets or Sets BillingCycle
    /// </summary>
    [DataMember(Name="billing_cycle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_cycle")]
    public string BillingCycle { get; set; }

    /// <summary>
    /// Gets or Sets NextBillingDate
    /// </summary>
    [DataMember(Name="next_billing_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "next_billing_date")]
    public DateTime? NextBillingDate { get; set; }

    /// <summary>
    /// Gets or Sets UnitCount
    /// </summary>
    [DataMember(Name="unit_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit_count")]
    public int? UnitCount { get; set; }

    /// <summary>
    /// Gets or Sets OnFreeTrial
    /// </summary>
    [DataMember(Name="on_free_trial", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "on_free_trial")]
    public bool? OnFreeTrial { get; set; }

    /// <summary>
    /// Gets or Sets FreeTrialEndsOn
    /// </summary>
    [DataMember(Name="free_trial_ends_on", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "free_trial_ends_on")]
    public DateTime? FreeTrialEndsOn { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedAt
    /// </summary>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets or Sets Account
    /// </summary>
    [DataMember(Name="account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account")]
    public MarketplaceAccount Account { get; set; }

    /// <summary>
    /// Gets or Sets Plan
    /// </summary>
    [DataMember(Name="plan", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plan")]
    public MarketplaceListingPlan Plan { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserMarketplacePurchase {\n");
      sb.Append("  BillingCycle: ").Append(BillingCycle).Append("\n");
      sb.Append("  NextBillingDate: ").Append(NextBillingDate).Append("\n");
      sb.Append("  UnitCount: ").Append(UnitCount).Append("\n");
      sb.Append("  OnFreeTrial: ").Append(OnFreeTrial).Append("\n");
      sb.Append("  FreeTrialEndsOn: ").Append(FreeTrialEndsOn).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Account: ").Append(Account).Append("\n");
      sb.Append("  Plan: ").Append(Plan).Append("\n");
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
