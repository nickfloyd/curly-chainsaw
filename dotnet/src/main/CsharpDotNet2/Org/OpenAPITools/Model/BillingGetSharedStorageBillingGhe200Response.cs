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
  public class BillingGetSharedStorageBillingGhe200Response {
    /// <summary>
    /// Numbers of days left in billing cycle.
    /// </summary>
    /// <value>Numbers of days left in billing cycle.</value>
    [DataMember(Name="days_left_in_billing_cycle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "days_left_in_billing_cycle")]
    public int? DaysLeftInBillingCycle { get; set; }

    /// <summary>
    /// Estimated storage space (GB) used in billing cycle.
    /// </summary>
    /// <value>Estimated storage space (GB) used in billing cycle.</value>
    [DataMember(Name="estimated_paid_storage_for_month", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "estimated_paid_storage_for_month")]
    public int? EstimatedPaidStorageForMonth { get; set; }

    /// <summary>
    /// Estimated sum of free and paid storage space (GB) used in billing cycle.
    /// </summary>
    /// <value>Estimated sum of free and paid storage space (GB) used in billing cycle.</value>
    [DataMember(Name="estimated_storage_for_month", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "estimated_storage_for_month")]
    public int? EstimatedStorageForMonth { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BillingGetSharedStorageBillingGhe200Response {\n");
      sb.Append("  DaysLeftInBillingCycle: ").Append(DaysLeftInBillingCycle).Append("\n");
      sb.Append("  EstimatedPaidStorageForMonth: ").Append(EstimatedPaidStorageForMonth).Append("\n");
      sb.Append("  EstimatedStorageForMonth: ").Append(EstimatedStorageForMonth).Append("\n");
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
