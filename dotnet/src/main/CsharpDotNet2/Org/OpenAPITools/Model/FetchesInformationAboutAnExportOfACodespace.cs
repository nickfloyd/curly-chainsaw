using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// An export of a codespace. Also, latest export details for a codespace can be fetched with id &#x3D; latest
  /// </summary>
  [DataContract]
  public class FetchesInformationAboutAnExportOfACodespace {
    /// <summary>
    /// State of the latest export
    /// </summary>
    /// <value>State of the latest export</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Completion time of the last export operation
    /// </summary>
    /// <value>Completion time of the last export operation</value>
    [DataMember(Name="completed_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completed_at")]
    public DateTime? CompletedAt { get; set; }

    /// <summary>
    /// Name of the exported branch
    /// </summary>
    /// <value>Name of the exported branch</value>
    [DataMember(Name="branch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "branch")]
    public string Branch { get; set; }

    /// <summary>
    /// Git commit SHA of the exported branch
    /// </summary>
    /// <value>Git commit SHA of the exported branch</value>
    [DataMember(Name="sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sha")]
    public string Sha { get; set; }

    /// <summary>
    /// Id for the export details
    /// </summary>
    /// <value>Id for the export details</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Url for fetching export details
    /// </summary>
    /// <value>Url for fetching export details</value>
    [DataMember(Name="export_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "export_url")]
    public string ExportUrl { get; set; }

    /// <summary>
    /// Web url for the exported branch
    /// </summary>
    /// <value>Web url for the exported branch</value>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FetchesInformationAboutAnExportOfACodespace {\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
      sb.Append("  Branch: ").Append(Branch).Append("\n");
      sb.Append("  Sha: ").Append(Sha).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ExportUrl: ").Append(ExportUrl).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
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
