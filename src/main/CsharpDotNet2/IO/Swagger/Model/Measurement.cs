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
  public class Measurement {
    /// <summary>
    /// ORIGINAL Name of the variable for which we are creating the measurement records
    /// </summary>
    /// <value>ORIGINAL Name of the variable for which we are creating the measurement records</value>
    [DataMember(Name="variable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variable")]
    public string Variable { get; set; }

    /// <summary>
    /// Application or device used to record the measurement values
    /// </summary>
    /// <value>Application or device used to record the measurement values</value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public string Source { get; set; }

    /// <summary>
    /// Start Time for the measurement event in ISO 8601
    /// </summary>
    /// <value>Start Time for the measurement event in ISO 8601</value>
    [DataMember(Name="startTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startTime")]
    public string StartTime { get; set; }

    /// <summary>
    /// Start Time for the measurement event in ISO 8601
    /// </summary>
    /// <value>Start Time for the measurement event in ISO 8601</value>
    [DataMember(Name="humanTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "humanTime")]
    public HumanTime HumanTime { get; set; }

    /// <summary>
    /// Converted measurement value in requested unit
    /// </summary>
    /// <value>Converted measurement value in requested unit</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public double? Value { get; set; }

    /// <summary>
    /// Unit of measurement as requested in GET request
    /// </summary>
    /// <value>Unit of measurement as requested in GET request</value>
    [DataMember(Name="unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit")]
    public string Unit { get; set; }

    /// <summary>
    /// Original value
    /// </summary>
    /// <value>Original value</value>
    [DataMember(Name="originalValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originalValue")]
    public int? OriginalValue { get; set; }

    /// <summary>
    /// Measurement value in the unit as orignally submitted
    /// </summary>
    /// <value>Measurement value in the unit as orignally submitted</value>
    [DataMember(Name="storedValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storedValue")]
    public double? StoredValue { get; set; }

    /// <summary>
    /// Unit of measurement as originally submitted
    /// </summary>
    /// <value>Unit of measurement as originally submitted</value>
    [DataMember(Name="storedAbbreviatedUnitName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storedAbbreviatedUnitName")]
    public string StoredAbbreviatedUnitName { get; set; }

    /// <summary>
    /// Original Unit of measurement as originally submitted
    /// </summary>
    /// <value>Original Unit of measurement as originally submitted</value>
    [DataMember(Name="originalAbbreviatedUnitName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originalAbbreviatedUnitName")]
    public string OriginalAbbreviatedUnitName { get; set; }

    /// <summary>
    /// Unit of measurement as originally submitted
    /// </summary>
    /// <value>Unit of measurement as originally submitted</value>
    [DataMember(Name="abbreviatedUnitName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "abbreviatedUnitName")]
    public string AbbreviatedUnitName { get; set; }

    /// <summary>
    /// Note of measurement
    /// </summary>
    /// <value>Note of measurement</value>
    [DataMember(Name="note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "note")]
    public string Note { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Measurement {\n");
      sb.Append("  Variable: ").Append(Variable).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      sb.Append("  HumanTime: ").Append(HumanTime).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Unit: ").Append(Unit).Append("\n");
      sb.Append("  OriginalValue: ").Append(OriginalValue).Append("\n");
      sb.Append("  StoredValue: ").Append(StoredValue).Append("\n");
      sb.Append("  StoredAbbreviatedUnitName: ").Append(StoredAbbreviatedUnitName).Append("\n");
      sb.Append("  OriginalAbbreviatedUnitName: ").Append(OriginalAbbreviatedUnitName).Append("\n");
      sb.Append("  AbbreviatedUnitName: ").Append(AbbreviatedUnitName).Append("\n");
      sb.Append("  Note: ").Append(Note).Append("\n");
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
