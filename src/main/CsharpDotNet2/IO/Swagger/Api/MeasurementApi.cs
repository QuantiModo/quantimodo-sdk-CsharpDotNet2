using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMeasurementApi
    {
        
        /// <summary>
        /// Get measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="userId">ID of user that owns this measurement</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records</param>
        /// <param name="sourceId">Application or device used to record the measurement values</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format</param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable</param>
        /// <param name="unitId">The default unit id for the variable</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted</param>
        /// <param name="duration">Duration of the event being measurement in seconds</param>
        /// <param name="note">An optional note the user may include with their measurement</param>
        /// <param name="latitude">Latitude at which the measurement was taken</param>
        /// <param name="longitude">Longitude at which the measurement was taken</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="error">An error message if there is a problem with the measurement</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse20013</returns>
        InlineResponse20013 MeasurementsGet (string accessToken, int? userId, string clientId, int? connectorId, int? variableId, int? sourceId, string startTime, double? value, int? unitId, double? originalValue, int? originalUnitId, int? duration, string note, double? latitude, double? longitude, string location, string createdAt, string updatedAt, string error, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Post a new set or update existing measurements to the database You can submit or update multiple measurements in a measurements sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Measurement that should be stored</param>
        /// <returns>InlineResponse20013</returns>
        InlineResponse20013 MeasurementsPost (string accessToken, MeasurementPost body);
        
        /// <summary>
        /// Get Measurements CSV Download a CSV containing all user measurements
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>Stream</returns>
        Stream MeasurementsCsvGet (string accessToken);
        
        /// <summary>
        /// Post Request for Measurements CSV Use this endpoint to schedule a CSV export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>int?</returns>
        int? MeasurementsRequestCsvPost (string accessToken);
        
        /// <summary>
        /// Get Measurement Get Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20014</returns>
        InlineResponse20014 MeasurementsIdGet (int? id, string accessToken);
        
        /// <summary>
        /// Update Measurement Update Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Measurement that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 MeasurementsIdPut (int? id, string accessToken, Measurement body);
        
        /// <summary>
        /// Delete Measurement Delete Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 MeasurementsIdDelete (int? id, string accessToken);
        
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
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Get measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="userId">ID of user that owns this measurement</param> 
        /// <param name="clientId">The ID of the client application which originally stored the measurement</param> 
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained</param> 
        /// <param name="variableId">ID of the variable for which we are creating the measurement records</param> 
        /// <param name="sourceId">Application or device used to record the measurement values</param> 
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format</param> 
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable</param> 
        /// <param name="unitId">The default unit id for the variable</param> 
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit)</param> 
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted</param> 
        /// <param name="duration">Duration of the event being measurement in seconds</param> 
        /// <param name="note">An optional note the user may include with their measurement</param> 
        /// <param name="latitude">Latitude at which the measurement was taken</param> 
        /// <param name="longitude">Longitude at which the measurement was taken</param> 
        /// <param name="location">Optional human readable name for the location where the measurement was recorded</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="error">An error message if there is a problem with the measurement</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse20013</returns>            
        public InlineResponse20013 MeasurementsGet (string accessToken, int? userId, string clientId, int? connectorId, int? variableId, int? sourceId, string startTime, double? value, int? unitId, double? originalValue, int? originalUnitId, int? duration, string note, double? latitude, double? longitude, string location, string createdAt, string updatedAt, string error, int? limit, int? offset, string sort)
        {
            
    
            var path = "/measurements";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
             if (userId != null) queryParams.Add("user_id", ApiClient.ParameterToString(userId)); // query parameter
             if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
             if (connectorId != null) queryParams.Add("connector_id", ApiClient.ParameterToString(connectorId)); // query parameter
             if (variableId != null) queryParams.Add("variable_id", ApiClient.ParameterToString(variableId)); // query parameter
             if (sourceId != null) queryParams.Add("source_id", ApiClient.ParameterToString(sourceId)); // query parameter
             if (startTime != null) queryParams.Add("start_time", ApiClient.ParameterToString(startTime)); // query parameter
             if (value != null) queryParams.Add("value", ApiClient.ParameterToString(value)); // query parameter
             if (unitId != null) queryParams.Add("unit_id", ApiClient.ParameterToString(unitId)); // query parameter
             if (originalValue != null) queryParams.Add("original_value", ApiClient.ParameterToString(originalValue)); // query parameter
             if (originalUnitId != null) queryParams.Add("original_unit_id", ApiClient.ParameterToString(originalUnitId)); // query parameter
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
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20013) ApiClient.Deserialize(response.Content, typeof(InlineResponse20013), response.Headers);
        }
    
        
        /// <summary>
        /// Post a new set or update existing measurements to the database You can submit or update multiple measurements in a measurements sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Measurement that should be stored</param> 
        /// <returns>InlineResponse20013</returns>            
        public InlineResponse20013 MeasurementsPost (string accessToken, MeasurementPost body)
        {
            
    
            var path = "/measurements";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20013) ApiClient.Deserialize(response.Content, typeof(InlineResponse20013), response.Headers);
        }
    
        
        /// <summary>
        /// Get Measurements CSV Download a CSV containing all user measurements
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>Stream</returns>            
        public Stream MeasurementsCsvGet (string accessToken)
        {
            
    
            var path = "/measurements/csv";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsCsvGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsCsvGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Stream) ApiClient.Deserialize(response.Content, typeof(Stream), response.Headers);
        }
    
        
        /// <summary>
        /// Post Request for Measurements CSV Use this endpoint to schedule a CSV export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>int?</returns>            
        public int? MeasurementsRequestCsvPost (string accessToken)
        {
            
    
            var path = "/measurements/request_csv";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
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
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20014</returns>            
        public InlineResponse20014 MeasurementsIdGet (int? id, string accessToken)
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
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeasurementsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20014) ApiClient.Deserialize(response.Content, typeof(InlineResponse20014), response.Headers);
        }
    
        
        /// <summary>
        /// Update Measurement Update Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Measurement that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 MeasurementsIdPut (int? id, string accessToken, Measurement body)
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
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
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
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 MeasurementsIdDelete (int? id, string accessToken)
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
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
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
