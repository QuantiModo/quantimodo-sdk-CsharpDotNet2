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
  public class VariableUserSource {
    /// <summary>
    /// ID of User
    /// </summary>
    /// <value>ID of User</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }

    /// <summary>
    /// ID of variable
    /// </summary>
    /// <value>ID of variable</value>
    [DataMember(Name="variable_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variable_id")]
    public int? VariableId { get; set; }

    /// <summary>
    /// ID of source
    /// </summary>
    /// <value>ID of source</value>
    [DataMember(Name="source_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source_id")]
    public int? SourceId { get; set; }

    /// <summary>
    /// Time that this measurement occurred Uses epoch minute (epoch time divided by 60)
    /// </summary>
    /// <value>Time that this measurement occurred Uses epoch minute (epoch time divided by 60)</value>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public int? Timestamp { get; set; }

    /// <summary>
    /// Earliest measurement time
    /// </summary>
    /// <value>Earliest measurement time</value>
    [DataMember(Name="earliest_measurement_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "earliest_measurement_time")]
    public int? EarliestMeasurementTime { get; set; }

    /// <summary>
    /// Latest measurement time
    /// </summary>
    /// <value>Latest measurement time</value>
    [DataMember(Name="latest_measurement_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latest_measurement_time")]
    public int? LatestMeasurementTime { get; set; }

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
      sb.Append("class VariableUserSource {\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  VariableId: ").Append(VariableId).Append("\n");
      sb.Append("  SourceId: ").Append(SourceId).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  EarliestMeasurementTime: ").Append(EarliestMeasurementTime).Append("\n");
      sb.Append("  LatestMeasurementTime: ").Append(LatestMeasurementTime).Append("\n");
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
