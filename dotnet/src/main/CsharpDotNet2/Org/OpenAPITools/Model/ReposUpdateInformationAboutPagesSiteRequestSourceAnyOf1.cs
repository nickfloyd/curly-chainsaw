using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Update the source for the repository. Must include the branch name, and may optionally specify the subdirectory &#x60;/docs&#x60;. Possible values are &#x60;\&quot;gh-pages\&quot;&#x60;, &#x60;\&quot;master\&quot;&#x60;, and &#x60;\&quot;master /docs\&quot;&#x60;.
  /// </summary>
  [DataContract]
  public class ReposUpdateInformationAboutPagesSiteRequestSourceAnyOf1 {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposUpdateInformationAboutPagesSiteRequestSourceAnyOf1 {\n");
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
