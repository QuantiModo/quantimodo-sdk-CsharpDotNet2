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
  public class Update {
    
    /// <summary>
    /// id
    /// </summary>
    /// <value>id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    
    /// <summary>
    /// user_id
    /// </summary>
    /// <value>user_id</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }

    
    /// <summary>
    /// connector_id
    /// </summary>
    /// <value>connector_id</value>
    [DataMember(Name="connector_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "connector_id")]
    public int? ConnectorId { get; set; }

    
    /// <summary>
    /// number_of_measurements
    /// </summary>
    /// <value>number_of_measurements</value>
    [DataMember(Name="number_of_measurements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_of_measurements")]
    public int? NumberOfMeasurements { get; set; }

    
    /// <summary>
    /// success
    /// </summary>
    /// <value>success</value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }

    
    /// <summary>
    /// message
    /// </summary>
    /// <value>message</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    
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
      sb.Append("class Update {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      
      sb.Append("  ConnectorId: ").Append(ConnectorId).Append("\n");
      
      sb.Append("  NumberOfMeasurements: ").Append(NumberOfMeasurements).Append("\n");
      
      sb.Append("  Success: ").Append(Success).Append("\n");
      
      sb.Append("  Message: ").Append(Message).Append("\n");
      
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
