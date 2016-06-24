using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserTag {
    /// <summary>
    /// This is the id of the variable being tagged with an ingredient or something.
    /// </summary>
    /// <value>This is the id of the variable being tagged with an ingredient or something.</value>
    [DataMember(Name="taggedVariableId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taggedVariableId")]
    public int? TaggedVariableId { get; set; }

    /// <summary>
    /// This is the id of the ingredient variable whose value is determined based on the value of the tagged variable.
    /// </summary>
    /// <value>This is the id of the ingredient variable whose value is determined based on the value of the tagged variable.</value>
    [DataMember(Name="tagVariableId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tagVariableId")]
    public int? TagVariableId { get; set; }

    /// <summary>
    /// Number by which we multiply the tagged variable value to obtain the tag variable (ingredient) value
    /// </summary>
    /// <value>Number by which we multiply the tagged variable value to obtain the tag variable (ingredient) value</value>
    [DataMember(Name="conversionFactor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conversionFactor")]
    public double? ConversionFactor { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserTag {\n");
      sb.Append("  TaggedVariableId: ").Append(TaggedVariableId).Append("\n");
      sb.Append("  TagVariableId: ").Append(TagVariableId).Append("\n");
      sb.Append("  ConversionFactor: ").Append(ConversionFactor).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
