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
  public class MeasurementPost {
    
    /// <summary>
    /// ID of the variable for the measurement as obtained from the GET variables endpoint
    /// </summary>
    /// <value>ID of the variable for the measurement as obtained from the GET variables endpoint</value>
    [DataMember(Name="variable_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variable_id")]
    public int? VariableId { get; set; }

    
    /// <summary>
    /// Source ID of the app or device as obtained from the GET sources endpoint
    /// </summary>
    /// <value>Source ID of the app or device as obtained from the GET sources endpoint</value>
    [DataMember(Name="source_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source_id")]
    public int? SourceId { get; set; }

    
    /// <summary>
    /// Unit id for the measurement value as obtained from the GET units endpoint
    /// </summary>
    /// <value>Unit id for the measurement value as obtained from the GET units endpoint</value>
    [DataMember(Name="unit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit_id")]
    public int? UnitId { get; set; }

    
    /// <summary>
    /// measurements
    /// </summary>
    /// <value>measurements</value>
    [DataMember(Name="measurements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "measurements")]
    public List<MeasurementValue> Measurements { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MeasurementPost {\n");
      
      sb.Append("  VariableId: ").Append(VariableId).Append("\n");
      
      sb.Append("  SourceId: ").Append(SourceId).Append("\n");
      
      sb.Append("  UnitId: ").Append(UnitId).Append("\n");
      
      sb.Append("  Measurements: ").Append(Measurements).Append("\n");
      
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
