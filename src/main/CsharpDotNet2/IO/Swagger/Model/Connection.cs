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
  public class Connection {
    
    /// <summary>
    /// id
    /// </summary>
    /// <value>id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    
    /// <summary>
    /// ID of user that owns this correlation
    /// </summary>
    /// <value>ID of user that owns this correlation</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }

    
    /// <summary>
    /// The id for the connector data source for which the connection is connected
    /// </summary>
    /// <value>The id for the connector data source for which the connection is connected</value>
    [DataMember(Name="connector_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "connector_id")]
    public int? ConnectorId { get; set; }

    
    /// <summary>
    /// Indicates whether a connector is currently connected to a service for a user.
    /// </summary>
    /// <value>Indicates whether a connector is currently connected to a service for a user.</value>
    [DataMember(Name="connect_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "connect_status")]
    public string ConnectStatus { get; set; }

    
    /// <summary>
    /// Error message if there is a problem with authorizing this connection.
    /// </summary>
    /// <value>Error message if there is a problem with authorizing this connection.</value>
    [DataMember(Name="connect_error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "connect_error")]
    public string ConnectError { get; set; }

    
    /// <summary>
    /// Time at which an update was requested by a user.
    /// </summary>
    /// <value>Time at which an update was requested by a user.</value>
    [DataMember(Name="update_requested_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update_requested_at")]
    public DateTime? UpdateRequestedAt { get; set; }

    
    /// <summary>
    /// Indicates whether a connector is currently updated.
    /// </summary>
    /// <value>Indicates whether a connector is currently updated.</value>
    [DataMember(Name="update_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update_status")]
    public string UpdateStatus { get; set; }

    
    /// <summary>
    /// Indicates if there was an error during the update.
    /// </summary>
    /// <value>Indicates if there was an error during the update.</value>
    [DataMember(Name="update_error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update_error")]
    public string UpdateError { get; set; }

    
    /// <summary>
    /// The time at which the connector was last successfully updated.
    /// </summary>
    /// <value>The time at which the connector was last successfully updated.</value>
    [DataMember(Name="last_successful_updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_successful_updated_at")]
    public DateTime? LastSuccessfulUpdatedAt { get; set; }

    
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
      sb.Append("class Connection {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      
      sb.Append("  ConnectorId: ").Append(ConnectorId).Append("\n");
      
      sb.Append("  ConnectStatus: ").Append(ConnectStatus).Append("\n");
      
      sb.Append("  ConnectError: ").Append(ConnectError).Append("\n");
      
      sb.Append("  UpdateRequestedAt: ").Append(UpdateRequestedAt).Append("\n");
      
      sb.Append("  UpdateStatus: ").Append(UpdateStatus).Append("\n");
      
      sb.Append("  UpdateError: ").Append(UpdateError).Append("\n");
      
      sb.Append("  LastSuccessfulUpdatedAt: ").Append(LastSuccessfulUpdatedAt).Append("\n");
      
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
