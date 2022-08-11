using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Branch With Protection
  /// </summary>
  [DataContract]
  public class BranchWithProtection {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Commit
    /// </summary>
    [DataMember(Name="commit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit")]
    public Commit Commit { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="_links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_links")]
    public BranchWithProtectionLinks Links { get; set; }

    /// <summary>
    /// Gets or Sets Protected
    /// </summary>
    [DataMember(Name="protected", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protected")]
    public bool? Protected { get; set; }

    /// <summary>
    /// Gets or Sets Protection
    /// </summary>
    [DataMember(Name="protection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protection")]
    public BranchProtection Protection { get; set; }

    /// <summary>
    /// Gets or Sets ProtectionUrl
    /// </summary>
    [DataMember(Name="protection_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protection_url")]
    public string ProtectionUrl { get; set; }

    /// <summary>
    /// Gets or Sets Pattern
    /// </summary>
    [DataMember(Name="pattern", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pattern")]
    public string Pattern { get; set; }

    /// <summary>
    /// Gets or Sets RequiredApprovingReviewCount
    /// </summary>
    [DataMember(Name="required_approving_review_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required_approving_review_count")]
    public int? RequiredApprovingReviewCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BranchWithProtection {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Commit: ").Append(Commit).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  Protected: ").Append(Protected).Append("\n");
      sb.Append("  Protection: ").Append(Protection).Append("\n");
      sb.Append("  ProtectionUrl: ").Append(ProtectionUrl).Append("\n");
      sb.Append("  Pattern: ").Append(Pattern).Append("\n");
      sb.Append("  RequiredApprovingReviewCount: ").Append(RequiredApprovingReviewCount).Append("\n");
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
