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
  public class UnitConversion {
    
    /// <summary>
    /// unit_id
    /// </summary>
    /// <value>unit_id</value>
    [DataMember(Name="unit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit_id")]
    public int? UnitId { get; set; }

    
    /// <summary>
    /// step in the conversion process
    /// </summary>
    /// <value>step in the conversion process</value>
    [DataMember(Name="step_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "step_number")]
    public bool? StepNumber { get; set; }

    
    /// <summary>
    /// 0 is add and 1 is multiply
    /// </summary>
    /// <value>0 is add and 1 is multiply</value>
    [DataMember(Name="operation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operation")]
    public bool? Operation { get; set; }

    
    /// <summary>
    /// number used in the operation
    /// </summary>
    /// <value>number used in the operation</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public float? Value { get; set; }

    
    /// <summary>
    /// When the record was first created. Use ISO 8601 datetime format
    /// </summary>
    /// <value>When the record was first created. Use ISO 8601 datetime format</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    
    /// <summary>
    /// When the record in the database was last updated. Use ISO 8601 datetime format
    /// </summary>
    /// <value>When the record in the database was last updated. Use ISO 8601 datetime format</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UnitConversion {\n");
      
      sb.Append("  UnitId: ").Append(UnitId).Append("\n");
      
      sb.Append("  StepNumber: ").Append(StepNumber).Append("\n");
      
      sb.Append("  Operation: ").Append(Operation).Append("\n");
      
      sb.Append("  Value: ").Append(Value).Append("\n");
      
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      
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
