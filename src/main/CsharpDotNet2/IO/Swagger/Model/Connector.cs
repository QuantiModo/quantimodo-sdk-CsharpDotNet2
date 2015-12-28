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
  public class Connector {
    
    /// <summary>
    /// Connector ID number
    /// </summary>
    /// <value>Connector ID number</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    
    /// <summary>
    /// Lowercase system name for the data source
    /// </summary>
    /// <value>Lowercase system name for the data source</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    
    /// <summary>
    /// Pretty display name for the data source
    /// </summary>
    /// <value>Pretty display name for the data source</value>
    [DataMember(Name="display_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    
    /// <summary>
    /// URL to the image of the connector logo
    /// </summary>
    /// <value>URL to the image of the connector logo</value>
    [DataMember(Name="image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image")]
    public string Image { get; set; }

    
    /// <summary>
    /// URL to a site where one can get this device or application
    /// </summary>
    /// <value>URL to a site where one can get this device or application</value>
    [DataMember(Name="get_it_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "get_it_url")]
    public string GetItUrl { get; set; }

    
    /// <summary>
    /// Short description of the service (such as the categories it tracks)
    /// </summary>
    /// <value>Short description of the service (such as the categories it tracks)</value>
    [DataMember(Name="short_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "short_description")]
    public string ShortDescription { get; set; }

    
    /// <summary>
    /// Longer paragraph description of the data provider
    /// </summary>
    /// <value>Longer paragraph description of the data provider</value>
    [DataMember(Name="long_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "long_description")]
    public string LongDescription { get; set; }

    
    /// <summary>
    /// Set to 1 if the connector should be returned when listing connectors
    /// </summary>
    /// <value>Set to 1 if the connector should be returned when listing connectors</value>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }

    
    /// <summary>
    /// Set to 1 if the connector uses OAuth authentication as opposed to username/password
    /// </summary>
    /// <value>Set to 1 if the connector uses OAuth authentication as opposed to username/password</value>
    [DataMember(Name="oauth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "oauth")]
    public bool? Oauth { get; set; }

    
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
      sb.Append("class Connector {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      
      sb.Append("  Image: ").Append(Image).Append("\n");
      
      sb.Append("  GetItUrl: ").Append(GetItUrl).Append("\n");
      
      sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
      
      sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
      
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      
      sb.Append("  Oauth: ").Append(Oauth).Append("\n");
      
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
