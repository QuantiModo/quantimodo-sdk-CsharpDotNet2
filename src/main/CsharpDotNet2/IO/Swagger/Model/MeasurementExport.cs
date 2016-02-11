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
  public class MeasurementExport {
    
    /// <summary>
    /// id
    /// </summary>
    /// <value>id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    
    /// <summary>
    /// ID of User
    /// </summary>
    /// <value>ID of User</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }

    
    /// <summary>
    /// Status of Measurement Export
    /// </summary>
    /// <value>Status of Measurement Export</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    
    /// <summary>
    /// Error message
    /// </summary>
    /// <value>Error message</value>
    [DataMember(Name="error_message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error_message")]
    public string ErrorMessage { get; set; }

    
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
      sb.Append("class MeasurementExport {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
      
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
