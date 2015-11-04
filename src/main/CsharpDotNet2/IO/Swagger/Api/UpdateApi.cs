using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    public interface IUpdateApi
    {
        
        /// <summary>
        /// Get all Updates Get all Updates
        /// </summary>
        /// <param name="userId">user_id</param>
        /// <param name="connectorId">connector_id</param>
        /// <param name="numberOfMeasurements">number_of_measurements</param>
        /// <param name="success">success</param>
        /// <param name="message">message</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse20019</returns>
        InlineResponse20019 UpdatesGet (int? userId, int? connectorId, int? numberOfMeasurements, bool? success, string message, string createdAt, string updatedAt, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store Update Store Update
        /// </summary>
        /// <param name="body">Update that should be stored</param>
        /// <returns>InlineResponse20020</returns>
        InlineResponse20020 UpdatesPost (Update body);
        
        /// <summary>
        /// Get Update Get Update
        /// </summary>
        /// <param name="id">id of Update</param>
        /// <returns>InlineResponse20020</returns>
        InlineResponse20020 UpdatesIdGet (int? id);
        
        /// <summary>
        /// Update Update Update Update
        /// </summary>
        /// <param name="id">id of Update</param>
        /// <param name="body">Update that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UpdatesIdPut (int? id, Update body);
        
        /// <summary>
        /// Delete Update Delete Update
        /// </summary>
        /// <param name="id">id of Update</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UpdatesIdDelete (int? id);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UpdateApi : IUpdateApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UpdateApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UpdateApi(String basePath)
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
        /// Get all Updates Get all Updates
        /// </summary>
        /// <param name="userId">user_id</param> 
        /// <param name="connectorId">connector_id</param> 
        /// <param name="numberOfMeasurements">number_of_measurements</param> 
        /// <param name="success">success</param> 
        /// <param name="message">message</param> 
        /// <param name="createdAt">created_at</param> 
        /// <param name="updatedAt">updated_at</param> 
        /// <param name="limit">limit</param> 
        /// <param name="offset">offset</param> 
        /// <param name="sort">sort</param> 
        /// <returns>InlineResponse20019</returns>            
        public InlineResponse20019 UpdatesGet (int? userId, int? connectorId, int? numberOfMeasurements, bool? success, string message, string createdAt, string updatedAt, int? limit, int? offset, string sort)
        {
            
    
            var path = "/updates";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userId != null) queryParams.Add("user_id", ApiClient.ParameterToString(userId)); // query parameter
             if (connectorId != null) queryParams.Add("connector_id", ApiClient.ParameterToString(connectorId)); // query parameter
             if (numberOfMeasurements != null) queryParams.Add("number_of_measurements", ApiClient.ParameterToString(numberOfMeasurements)); // query parameter
             if (success != null) queryParams.Add("success", ApiClient.ParameterToString(success)); // query parameter
             if (message != null) queryParams.Add("message", ApiClient.ParameterToString(message)); // query parameter
             if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
             if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
             if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20019) ApiClient.Deserialize(response.Content, typeof(InlineResponse20019), response.Headers);
        }
    
        
        /// <summary>
        /// Store Update Store Update
        /// </summary>
        /// <param name="body">Update that should be stored</param> 
        /// <returns>InlineResponse20020</returns>            
        public InlineResponse20020 UpdatesPost (Update body)
        {
            
    
            var path = "/updates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20020) ApiClient.Deserialize(response.Content, typeof(InlineResponse20020), response.Headers);
        }
    
        
        /// <summary>
        /// Get Update Get Update
        /// </summary>
        /// <param name="id">id of Update</param> 
        /// <returns>InlineResponse20020</returns>            
        public InlineResponse20020 UpdatesIdGet (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdatesIdGet");
            
    
            var path = "/updates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20020) ApiClient.Deserialize(response.Content, typeof(InlineResponse20020), response.Headers);
        }
    
        
        /// <summary>
        /// Update Update Update Update
        /// </summary>
        /// <param name="id">id of Update</param> 
        /// <param name="body">Update that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 UpdatesIdPut (int? id, Update body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdatesIdPut");
            
    
            var path = "/updates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatesIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatesIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
        /// <summary>
        /// Delete Update Delete Update
        /// </summary>
        /// <param name="id">id of Update</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 UpdatesIdDelete (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdatesIdDelete");
            
    
            var path = "/updates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatesIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
    }
    
}
