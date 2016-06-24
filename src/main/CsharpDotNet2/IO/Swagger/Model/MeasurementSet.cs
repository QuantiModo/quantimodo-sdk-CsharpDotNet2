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
  public class MeasurementSet {
    /// <summary>
    /// Array of timestamps, values, and optional notes
    /// </summary>
    /// <value>Array of timestamps, values, and optional notes</value>
    [DataMember(Name="measurements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "measurements")]
    public List<ValueObject> Measurements { get; set; }

    /// <summary>
    /// ORIGINAL name of the variable for which we are creating the measurement records
    /// </summary>
    /// <value>ORIGINAL name of the variable for which we are creating the measurement records</value>
    [DataMember(Name="variableName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variableName")]
    public string VariableName { get; set; }

    /// <summary>
    /// Name of the application or device used to record the measurement values
    /// </summary>
    /// <value>Name of the application or device used to record the measurement values</value>
    [DataMember(Name="sourceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceName")]
    public string SourceName { get; set; }

    /// <summary>
    /// Variable category name
    /// </summary>
    /// <value>Variable category name</value>
    [DataMember(Name="variableCategoryName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variableCategoryName")]
    public string VariableCategoryName { get; set; }

    /// <summary>
    /// Way to aggregate measurements over time. Options are \"MEAN\" or \"SUM\".  SUM should be used for things like minutes of exercise.  If you use MEAN for exercise, then a person might exercise more minutes in one day but add separate measurements that were smaller.  So when we are doing correlational analysis, we would think that the person exercised less that day even though they exercised more.  Conversely, we must use MEAN for things such as ratings which cannot be SUMMED.
    /// </summary>
    /// <value>Way to aggregate measurements over time. Options are \"MEAN\" or \"SUM\".  SUM should be used for things like minutes of exercise.  If you use MEAN for exercise, then a person might exercise more minutes in one day but add separate measurements that were smaller.  So when we are doing correlational analysis, we would think that the person exercised less that day even though they exercised more.  Conversely, we must use MEAN for things such as ratings which cannot be SUMMED.</value>
    [DataMember(Name="combinationOperation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "combinationOperation")]
    public string CombinationOperation { get; set; }

    /// <summary>
    /// Unit of measurement
    /// </summary>
    /// <value>Unit of measurement</value>
    [DataMember(Name="abbreviatedUnitName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "abbreviatedUnitName")]
    public string AbbreviatedUnitName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MeasurementSet {\n");
      sb.Append("  Measurements: ").Append(Measurements).Append("\n");
      sb.Append("  VariableName: ").Append(VariableName).Append("\n");
      sb.Append("  SourceName: ").Append(SourceName).Append("\n");
      sb.Append("  VariableCategoryName: ").Append(VariableCategoryName).Append("\n");
      sb.Append("  CombinationOperation: ").Append(CombinationOperation).Append("\n");
      sb.Append("  AbbreviatedUnitName: ").Append(AbbreviatedUnitName).Append("\n");
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
