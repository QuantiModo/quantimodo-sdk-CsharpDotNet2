using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    public interface IMeasurementApi
    {
        
        /// <summary>
        /// Get all Measurements Get all Measurements
        /// </summary>
        /// <param name="userId">user_id</param>
        /// <param name="clientId">client_id</param>
        /// <param name="connectorId">connector_id</param>
        /// <param name="variableId">variable_id</param>
        /// <param name="startTime">start_time</param>
        /// <param name="value">value</param>
        /// <param name="originalValue">original_value</param>
        /// <param name="duration">duration</param>
        /// <param name="note">note</param>
        /// <param name="latitude">latitude</param>
        /// <param name="longitude">longitude</param>
        /// <param name="location">location</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="error">error</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 MeasurementsGet (int? userId, string clientId, int? connectorId, int? variableId, int? startTime, double? value, double? originalValue, int? duration, string note, double? latitude, double? longitude, string location, string createdAt, string updatedAt, string error, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store Measurement Store Measurement
        /// </summary>
        /// <param name="body">Measurement that should be stored</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 MeasurementsPost (MeasurementPost body);
        
        /// <summary>
        /// Get Measurements CSV Get Measurements CSV
        /// </summary>
        /// <returns>Stream</returns>
        Stream MeasurementsCsvGet ();
        
        /// <summary>
        /// Post Request for Measurements CSV Post Request for Measurements CSV
        /// </summary>
        /// <returns>int?</returns>
        int? MeasurementsRequestCsvPost ();
        
        /// <summary>
        /// Get Measurement Get Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 MeasurementsIdGet (int? id);
        
        /// <summary>
        /// Update Measurement Update Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param>
        /// <param name="body">Measurement that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 MeasurementsIdPut (int? id, Measurement body);
        
        /// <summary>
        /// Delete Measurement Delete Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 MeasurementsIdDelete (int? id);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MeasurementApi : IMeasurementApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MeasurementApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MeasurementApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</param>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Get all Measurements Get all Measurements
        /// </summary>
        /// <param name="userId">user_id</param> 
        /// <param name="clientId">client_id</param> 
        /// <param name="connectorId">connector_id</param> 
        /// <param name="variableId">variable_id</param> 
        /// <param name="startTime">start_time</param> 
        /// <param name="value">value</param> 
        /// <param name="originalValue">original_value</param> 
        /// <param name="duration">duration</param> 
        /// <param name="note">note</param> 
        /// <param name="latitude">latitude</param> 
        /// <param name="longitude">longitude</param> 
        /// <param name="location">location</param> 
        /// <param name="createdAt">created_at</param> 
        /// <param name="updatedAt">updated_at</param> 
        /// <param name="error">error</param> 
        /// <param name="limit">limit</param> 
        /// <param name="offset">offset</param> 
        /// <param name="sort">sort</param> 
        /// <returns>InlineResponse20011</returns>            
        public InlineResponse20011 MeasurementsGet (int? userId, string clientId, int? connectorId, int? variableId, int? startTime, double? value, double? originalValue, int? duration, string note, double? latitude, double? longitude, string location, string createdAt, string updatedAt, string error, int? limit, int? offset, string sort)
        {
            
    
            var path = "/measurements";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userId != null) queryParams.Add("user_id", ApiClient.ParameterToString(userId)); // query parameter
             if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
             if (connectorId != null) queryParams.Add("connector_id", ApiClient.ParameterToString(connectorId)); // query parameter
             if (variableId != null) queryParams.Add("variable_id", ApiClient.ParameterToString(variableId)); // query parameter
             if (startTime != null) queryParams.Add("start_time", ApiClient.ParameterToString(startTime)); // query parameter
             if (value != null) queryParams.Add("value", ApiClient.ParameterToString(value)); // query parameter
             if (originalValue != null) queryParams.Add("original_value", ApiClient.ParameterToString(originalValue)); // query parameter
             if (duration != null) queryParams.Add("duration", ApiClient.ParameterToString(duration)); // query parameter
             if (note != null) queryParams.Add("note", ApiClient.ParameterToString(note)); // query parameter
             if (latitude != null) queryParams.Add("latitude", ApiClient.ParameterToString(latitude)); // query parameter
             if (longitude != null) queryParams.Add("longitude", ApiClient.ParameterToString(longitude)); // query parameter
             if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
             if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
             if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
             if (error != null) queryParams.Add("error", ApiClient.ParameterToString(error)); // query parameter
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
             if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20011) ApiClient.Deserialize(response.Content, typeof(InlineResponse20011), response.Headers);
        }
    
        
        /// <summary>
        /// Store Measurement Store Measurement
        /// </summary>
        /// <param name="body">Measurement that should be stored</param> 
        /// <returns>InlineResponse20011</returns>            
        public InlineResponse20011 MeasurementsPost (MeasurementPost body)
        {
            
    
            var path = "/measurements";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20011) ApiClient.Deserialize(response.Content, typeof(InlineResponse20011), response.Headers);
        }
    
        
        /// <summary>
        /// Get Measurements CSV Get Measurements CSV
        /// </summary>
        /// <returns>Stream</returns>            
        public Stream MeasurementsCsvGet ()
        {
            
    
            var path = "/measurements/csv";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsCsvGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsCsvGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Stream) ApiClient.Deserialize(response.Content, typeof(Stream), response.Headers);
        }
    
        
        /// <summary>
        /// Post Request for Measurements CSV Post Request for Measurements CSV
        /// </summary>
        /// <returns>int?</returns>            
        public int? MeasurementsRequestCsvPost ()
        {
            
    
            var path = "/measurements/request_csv";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsRequestCsvPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsRequestCsvPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (int?) ApiClient.Deserialize(response.Content, typeof(int?), response.Headers);
        }
    
        
        /// <summary>
        /// Get Measurement Get Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param> 
        /// <returns>InlineResponse20012</returns>            
        public InlineResponse20012 MeasurementsIdGet (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeasurementsIdGet");
            
    
            var path = "/measurements/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20012) ApiClient.Deserialize(response.Content, typeof(InlineResponse20012), response.Headers);
        }
    
        
        /// <summary>
        /// Update Measurement Update Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param> 
        /// <param name="body">Measurement that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 MeasurementsIdPut (int? id, Measurement body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeasurementsIdPut");
            
    
            var path = "/measurements/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
        /// <summary>
        /// Delete Measurement Delete Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 MeasurementsIdDelete (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeasurementsIdDelete");
            
    
            var path = "/measurements/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
    }
    
}
