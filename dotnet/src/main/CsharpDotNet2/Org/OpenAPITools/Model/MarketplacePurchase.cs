using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Marketplace Purchase
  /// </summary>
  [DataContract]
  public class MarketplacePurchase {
    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Login
    /// </summary>
    [DataMember(Name="login", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "login")]
    public string Login { get; set; }

    /// <summary>
    /// Gets or Sets OrganizationBillingEmail
    /// </summary>
    [DataMember(Name="organization_billing_email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organization_billing_email")]
    public string OrganizationBillingEmail { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets MarketplacePendingChange
    /// </summary>
    [DataMember(Name="marketplace_pending_change", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marketplace_pending_change")]
    public MarketplacePurchaseMarketplacePendingChange MarketplacePendingChange { get; set; }

    /// <summary>
    /// Gets or Sets _MarketplacePurchase
    /// </summary>
    [DataMember(Name="marketplace_purchase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marketplace_purchase")]
    public MarketplacePurchaseMarketplacePurchase _MarketplacePurchase { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MarketplacePurchase {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Login: ").Append(Login).Append("\n");
      sb.Append("  OrganizationBillingEmail: ").Append(OrganizationBillingEmail).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  MarketplacePendingChange: ").Append(MarketplacePendingChange).Append("\n");
      sb.Append("  _MarketplacePurchase: ").Append(_MarketplacePurchase).Append("\n");
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
