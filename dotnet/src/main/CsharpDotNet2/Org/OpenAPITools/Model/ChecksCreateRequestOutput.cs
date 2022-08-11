using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Check runs can accept a variety of data in the &#x60;output&#x60; object, including a &#x60;title&#x60; and &#x60;summary&#x60; and can optionally provide descriptive details about the run. See the [&#x60;output&#x60; object](https://docs.github.com/rest/reference/checks#output-object) description.
  /// </summary>
  [DataContract]
  public class ChecksCreateRequestOutput {
    /// <summary>
    /// The title of the check run.
    /// </summary>
    /// <value>The title of the check run.</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// The summary of the check run. This parameter supports Markdown.
    /// </summary>
    /// <value>The summary of the check run. This parameter supports Markdown.</value>
    [DataMember(Name="summary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "summary")]
    public string Summary { get; set; }

    /// <summary>
    /// The details of the check run. This parameter supports Markdown.
    /// </summary>
    /// <value>The details of the check run. This parameter supports Markdown.</value>
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }

    /// <summary>
    /// Adds information from your analysis to specific lines of code. Annotations are visible on GitHub in the **Checks** and **Files changed** tab of the pull request. The Checks API limits the number of annotations to a maximum of 50 per API request. To create more than 50 annotations, you have to make multiple requests to the [Update a check run](https://docs.github.com/rest/reference/checks#update-a-check-run) endpoint. Each time you update the check run, annotations are appended to the list of annotations that already exist for the check run. For details about how you can view annotations on GitHub, see \"[About status checks](https://docs.github.com/articles/about-status-checks#checks)\". See the [`annotations` object](https://docs.github.com/rest/reference/checks#annotations-object) description for details about how to use this parameter.
    /// </summary>
    /// <value>Adds information from your analysis to specific lines of code. Annotations are visible on GitHub in the **Checks** and **Files changed** tab of the pull request. The Checks API limits the number of annotations to a maximum of 50 per API request. To create more than 50 annotations, you have to make multiple requests to the [Update a check run](https://docs.github.com/rest/reference/checks#update-a-check-run) endpoint. Each time you update the check run, annotations are appended to the list of annotations that already exist for the check run. For details about how you can view annotations on GitHub, see \"[About status checks](https://docs.github.com/articles/about-status-checks#checks)\". See the [`annotations` object](https://docs.github.com/rest/reference/checks#annotations-object) description for details about how to use this parameter.</value>
    [DataMember(Name="annotations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "annotations")]
    public List<ChecksCreateRequestOutputAnnotationsInner> Annotations { get; set; }

    /// <summary>
    /// Adds images to the output displayed in the GitHub pull request UI. See the [`images` object](https://docs.github.com/rest/reference/checks#images-object) description for details.
    /// </summary>
    /// <value>Adds images to the output displayed in the GitHub pull request UI. See the [`images` object](https://docs.github.com/rest/reference/checks#images-object) description for details.</value>
    [DataMember(Name="images", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "images")]
    public List<ChecksCreateRequestOutputImagesInner> Images { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChecksCreateRequestOutput {\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Summary: ").Append(Summary).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  Annotations: ").Append(Annotations).Append("\n");
      sb.Append("  Images: ").Append(Images).Append("\n");
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
