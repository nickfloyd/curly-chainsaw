using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Marketplace Listing Plan
  /// </summary>
  [DataContract]
  public class MarketplaceListingPlan {
    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets AccountsUrl
    /// </summary>
    [DataMember(Name="accounts_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accounts_url")]
    public string AccountsUrl { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Number
    /// </summary>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public int? Number { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets MonthlyPriceInCents
    /// </summary>
    [DataMember(Name="monthly_price_in_cents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "monthly_price_in_cents")]
    public int? MonthlyPriceInCents { get; set; }

    /// <summary>
    /// Gets or Sets YearlyPriceInCents
    /// </summary>
    [DataMember(Name="yearly_price_in_cents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "yearly_price_in_cents")]
    public int? YearlyPriceInCents { get; set; }

    /// <summary>
    /// Gets or Sets PriceModel
    /// </summary>
    [DataMember(Name="price_model", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price_model")]
    public string PriceModel { get; set; }

    /// <summary>
    /// Gets or Sets HasFreeTrial
    /// </summary>
    [DataMember(Name="has_free_trial", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_free_trial")]
    public bool? HasFreeTrial { get; set; }

    /// <summary>
    /// Gets or Sets UnitName
    /// </summary>
    [DataMember(Name="unit_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit_name")]
    public string UnitName { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets Bullets
    /// </summary>
    [DataMember(Name="bullets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bullets")]
    public List<string> Bullets { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MarketplaceListingPlan {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  AccountsUrl: ").Append(AccountsUrl).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  MonthlyPriceInCents: ").Append(MonthlyPriceInCents).Append("\n");
      sb.Append("  YearlyPriceInCents: ").Append(YearlyPriceInCents).Append("\n");
      sb.Append("  PriceModel: ").Append(PriceModel).Append("\n");
      sb.Append("  HasFreeTrial: ").Append(HasFreeTrial).Append("\n");
      sb.Append("  UnitName: ").Append(UnitName).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Bullets: ").Append(Bullets).Append("\n");
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
