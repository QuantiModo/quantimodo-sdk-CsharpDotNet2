using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    public interface IUnitApi
    {
        
        /// <summary>
        /// Get all Units Get all Units
        /// </summary>
        /// <param name="clientId">client_id</param>
        /// <param name="name">name</param>
        /// <param name="abbreviatedName">abbreviated_name</param>
        /// <param name="categoryId">category_id</param>
        /// <param name="minimumValue">minimum_value</param>
        /// <param name="maximumValue">maximum_value</param>
        /// <param name="updated">updated</param>
        /// <param name="multiply">multiply</param>
        /// <param name="add">add</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse20017</returns>
        InlineResponse20017 UnitsGet (string clientId, string name, string abbreviatedName, bool? categoryId, double? minimumValue, double? maximumValue, int? updated, double? multiply, double? add, string createdAt, string updatedAt, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store Unit Store Unit
        /// </summary>
        /// <param name="body">Unit that should be stored</param>
        /// <returns>InlineResponse20018</returns>
        InlineResponse20018 UnitsPost (Unit body);
        
        /// <summary>
        /// Get Unit Get Unit
        /// </summary>
        /// <param name="id">id of Unit</param>
        /// <returns>InlineResponse20018</returns>
        InlineResponse20018 UnitsIdGet (int? id);
        
        /// <summary>
        /// Update Unit Update Unit
        /// </summary>
        /// <param name="id">id of Unit</param>
        /// <param name="body">Unit that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UnitsIdPut (int? id, Unit body);
        
        /// <summary>
        /// Delete Unit Delete Unit
        /// </summary>
        /// <param name="id">id of Unit</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UnitsIdDelete (int? id);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UnitApi : IUnitApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UnitApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UnitApi(String basePath)
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
        /// Get all Units Get all Units
        /// </summary>
        /// <param name="clientId">client_id</param> 
        /// <param name="name">name</param> 
        /// <param name="abbreviatedName">abbreviated_name</param> 
        /// <param name="categoryId">category_id</param> 
        /// <param name="minimumValue">minimum_value</param> 
        /// <param name="maximumValue">maximum_value</param> 
        /// <param name="updated">updated</param> 
        /// <param name="multiply">multiply</param> 
        /// <param name="add">add</param> 
        /// <param name="createdAt">created_at</param> 
        /// <param name="updatedAt">updated_at</param> 
        /// <param name="limit">limit</param> 
        /// <param name="offset">offset</param> 
        /// <param name="sort">sort</param> 
        /// <returns>InlineResponse20017</returns>            
        public InlineResponse20017 UnitsGet (string clientId, string name, string abbreviatedName, bool? categoryId, double? minimumValue, double? maximumValue, int? updated, double? multiply, double? add, string createdAt, string updatedAt, int? limit, int? offset, string sort)
        {
            
    
            var path = "/units";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
             if (abbreviatedName != null) queryParams.Add("abbreviated_name", ApiClient.ParameterToString(abbreviatedName)); // query parameter
             if (categoryId != null) queryParams.Add("category_id", ApiClient.ParameterToString(categoryId)); // query parameter
             if (minimumValue != null) queryParams.Add("minimum_value", ApiClient.ParameterToString(minimumValue)); // query parameter
             if (maximumValue != null) queryParams.Add("maximum_value", ApiClient.ParameterToString(maximumValue)); // query parameter
             if (updated != null) queryParams.Add("updated", ApiClient.ParameterToString(updated)); // query parameter
             if (multiply != null) queryParams.Add("multiply", ApiClient.ParameterToString(multiply)); // query parameter
             if (add != null) queryParams.Add("add", ApiClient.ParameterToString(add)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling UnitsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UnitsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20017) ApiClient.Deserialize(response.Content, typeof(InlineResponse20017), response.Headers);
        }
    
        
        /// <summary>
        /// Store Unit Store Unit
        /// </summary>
        /// <param name="body">Unit that should be stored</param> 
        /// <returns>InlineResponse20018</returns>            
        public InlineResponse20018 UnitsPost (Unit body)
        {
            
    
            var path = "/units";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UnitsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UnitsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20018) ApiClient.Deserialize(response.Content, typeof(InlineResponse20018), response.Headers);
        }
    
        
        /// <summary>
        /// Get Unit Get Unit
        /// </summary>
        /// <param name="id">id of Unit</param> 
        /// <returns>InlineResponse20018</returns>            
        public InlineResponse20018 UnitsIdGet (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UnitsIdGet");
            
    
            var path = "/units/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UnitsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UnitsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20018) ApiClient.Deserialize(response.Content, typeof(InlineResponse20018), response.Headers);
        }
    
        
        /// <summary>
        /// Update Unit Update Unit
        /// </summary>
        /// <param name="id">id of Unit</param> 
        /// <param name="body">Unit that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 UnitsIdPut (int? id, Unit body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UnitsIdPut");
            
    
            var path = "/units/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UnitsIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UnitsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
        /// <summary>
        /// Delete Unit Delete Unit
        /// </summary>
        /// <param name="id">id of Unit</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 UnitsIdDelete (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UnitsIdDelete");
            
    
            var path = "/units/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UnitsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UnitsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
    }
    
}
