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
  public class Credential {
    
    /// <summary>
    /// ID of user that owns this credential
    /// </summary>
    /// <value>ID of user that owns this credential</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }

    
    /// <summary>
    /// The id for the connector data source from which the credential was obtained
    /// </summary>
    /// <value>The id for the connector data source from which the credential was obtained</value>
    [DataMember(Name="connector_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "connector_id")]
    public int? ConnectorId { get; set; }

    
    /// <summary>
    /// Attribute name such as token, userid, username, or password
    /// </summary>
    /// <value>Attribute name such as token, userid, username, or password</value>
    [DataMember(Name="attr_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attr_key")]
    public string AttrKey { get; set; }

    
    /// <summary>
    /// Encrypted value for the attribute specified
    /// </summary>
    /// <value>Encrypted value for the attribute specified</value>
    [DataMember(Name="attr_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attr_value")]
    public string AttrValue { get; set; }

    
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
      sb.Append("class Credential {\n");
      
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      
      sb.Append("  ConnectorId: ").Append(ConnectorId).Append("\n");
      
      sb.Append("  AttrKey: ").Append(AttrKey).Append("\n");
      
      sb.Append("  AttrValue: ").Append(AttrValue).Append("\n");
      
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
