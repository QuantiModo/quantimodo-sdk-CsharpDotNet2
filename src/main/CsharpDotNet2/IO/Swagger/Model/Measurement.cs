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
    /// id
    /// </summary>
    /// <value>id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    
    /// <summary>
    /// ID of user that owns this measurement
    /// </summary>
    /// <value>ID of user that owns this measurement</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }

    
    /// <summary>
    /// client_id
    /// </summary>
    /// <value>client_id</value>
    [DataMember(Name="client_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client_id")]
    public string ClientId { get; set; }

    
    /// <summary>
    /// The id for the connector data source from which the measurement was obtained
    /// </summary>
    /// <value>The id for the connector data source from which the measurement was obtained</value>
    [DataMember(Name="connector_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "connector_id")]
    public int? ConnectorId { get; set; }

    
    /// <summary>
    /// ID of the variable for which we are creating the measurement records
    /// </summary>
    /// <value>ID of the variable for which we are creating the measurement records</value>
    [DataMember(Name="variable_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variable_id")]
    public int? VariableId { get; set; }

    
    /// <summary>
    /// Application or device used to record the measurement values
    /// </summary>
    /// <value>Application or device used to record the measurement values</value>
    [DataMember(Name="source_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source_id")]
    public int? SourceId { get; set; }

    
    /// <summary>
    /// Start Time for the measurement event. Use ISO 8601
    /// </summary>
    /// <value>Start Time for the measurement event. Use ISO 8601</value>
    [DataMember(Name="start_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_time")]
    public string StartTime { get; set; }

    
    /// <summary>
    /// The value of the measurement after conversion to the default unit for that variable
    /// </summary>
    /// <value>The value of the measurement after conversion to the default unit for that variable</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public float? Value { get; set; }

    
    /// <summary>
    /// The default unit for the variable
    /// </summary>
    /// <value>The default unit for the variable</value>
    [DataMember(Name="unit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit_id")]
    public int? UnitId { get; set; }

    
    /// <summary>
    /// Value of measurement as originally posted (before conversion to default unit)
    /// </summary>
    /// <value>Value of measurement as originally posted (before conversion to default unit)</value>
    [DataMember(Name="original_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_value")]
    public float? OriginalValue { get; set; }

    
    /// <summary>
    /// Unit ID of measurement as originally submitted
    /// </summary>
    /// <value>Unit ID of measurement as originally submitted</value>
    [DataMember(Name="original_unit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_unit_id")]
    public int? OriginalUnitId { get; set; }

    
    /// <summary>
    /// Duration of the event being measurement in seconds
    /// </summary>
    /// <value>Duration of the event being measurement in seconds</value>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration")]
    public int? Duration { get; set; }

    
    /// <summary>
    /// An optional note the user may include with their measurement
    /// </summary>
    /// <value>An optional note the user may include with their measurement</value>
    [DataMember(Name="note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "note")]
    public string Note { get; set; }

    
    /// <summary>
    /// Latitude at which the measurement was taken
    /// </summary>
    /// <value>Latitude at which the measurement was taken</value>
    [DataMember(Name="latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latitude")]
    public float? Latitude { get; set; }

    
    /// <summary>
    /// Longitude at which the measurement was taken
    /// </summary>
    /// <value>Longitude at which the measurement was taken</value>
    [DataMember(Name="longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longitude")]
    public float? Longitude { get; set; }

    
    /// <summary>
    /// location
    /// </summary>
    /// <value>location</value>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    
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
    /// error
    /// </summary>
    /// <value>error</value>
    [DataMember(Name="error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error")]
    public string Error { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Measurement {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      
      sb.Append("  ConnectorId: ").Append(ConnectorId).Append("\n");
      
      sb.Append("  VariableId: ").Append(VariableId).Append("\n");
      
      sb.Append("  SourceId: ").Append(SourceId).Append("\n");
      
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      
      sb.Append("  Value: ").Append(Value).Append("\n");
      
      sb.Append("  UnitId: ").Append(UnitId).Append("\n");
      
      sb.Append("  OriginalValue: ").Append(OriginalValue).Append("\n");
      
      sb.Append("  OriginalUnitId: ").Append(OriginalUnitId).Append("\n");
      
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      
      sb.Append("  Note: ").Append(Note).Append("\n");
      
      sb.Append("  Latitude: ").Append(Latitude).Append("\n");
      
      sb.Append("  Longitude: ").Append(Longitude).Append("\n");
      
      sb.Append("  Location: ").Append(Location).Append("\n");
      
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      
      sb.Append("  Error: ").Append(Error).Append("\n");
      
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
