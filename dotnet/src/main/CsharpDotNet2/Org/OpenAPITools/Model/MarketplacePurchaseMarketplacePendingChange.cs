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
  public class MarketplacePurchaseMarketplacePendingChange {
    /// <summary>
    /// Gets or Sets IsInstalled
    /// </summary>
    [DataMember(Name="is_installed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_installed")]
    public bool? IsInstalled { get; set; }

    /// <summary>
    /// Gets or Sets EffectiveDate
    /// </summary>
    [DataMember(Name="effective_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effective_date")]
    public string EffectiveDate { get; set; }

    /// <summary>
    /// Gets or Sets UnitCount
    /// </summary>
    [DataMember(Name="unit_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit_count")]
    public int? UnitCount { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

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
      sb.Append("class MarketplacePurchaseMarketplacePendingChange {\n");
      sb.Append("  IsInstalled: ").Append(IsInstalled).Append("\n");
      sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
      sb.Append("  UnitCount: ").Append(UnitCount).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
