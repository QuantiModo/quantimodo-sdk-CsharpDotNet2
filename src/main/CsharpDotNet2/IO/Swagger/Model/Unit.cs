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
  public class Unit {
    /// <summary>
    /// Unit name
    /// </summary>
    /// <value>Unit name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Unit abbreviation
    /// </summary>
    /// <value>Unit abbreviation</value>
    [DataMember(Name="abbreviatedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "abbreviatedName")]
    public string AbbreviatedName { get; set; }

    /// <summary>
    /// Unit category
    /// </summary>
    /// <value>Unit category</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; }

    /// <summary>
    /// The smallest acceptable value for measurements using this unit
    /// </summary>
    /// <value>The smallest acceptable value for measurements using this unit</value>
    [DataMember(Name="minimumValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimumValue")]
    public double? MinimumValue { get; set; }

    /// <summary>
    /// The largest acceptable value for measurements using this unit
    /// </summary>
    /// <value>The largest acceptable value for measurements using this unit</value>
    [DataMember(Name="maximumValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximumValue")]
    public double? MaximumValue { get; set; }

    /// <summary>
    /// Conversion steps list
    /// </summary>
    /// <value>Conversion steps list</value>
    [DataMember(Name="conversionSteps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conversionSteps")]
    public List<ConversionStep> ConversionSteps { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Unit {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  AbbreviatedName: ").Append(AbbreviatedName).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  MinimumValue: ").Append(MinimumValue).Append("\n");
      sb.Append("  MaximumValue: ").Append(MaximumValue).Append("\n");
      sb.Append("  ConversionSteps: ").Append(ConversionSteps).Append("\n");
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
