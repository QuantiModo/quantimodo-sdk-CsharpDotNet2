using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    public interface IConnectorApi
    {
        
        /// <summary>
        /// Get all Connectors Get all Connectors
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="displayName">display_name</param>
        /// <param name="image">image</param>
        /// <param name="getItUrl">get_it_url</param>
        /// <param name="shortDescription">short_description</param>
        /// <param name="longDescription">long_description</param>
        /// <param name="enabled">enabled</param>
        /// <param name="oauth">oauth</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 ConnectorsGet (string name, string displayName, string image, string getItUrl, string shortDescription, string longDescription, bool? enabled, bool? oauth, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store Connector Store Connector
        /// </summary>
        /// <param name="body">Connector that should be stored</param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 ConnectorsPost (Connector body);
        
        /// <summary>
        /// Get Connector Get Connector
        /// </summary>
        /// <param name="id">id of Connector</param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 ConnectorsIdGet (int? id);
        
        /// <summary>
        /// Update Connector Update Connector
        /// </summary>
        /// <param name="id">id of Connector</param>
        /// <param name="body">Connector that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 ConnectorsIdPut (int? id, Connector body);
        
        /// <summary>
        /// Delete Connector Delete Connector
        /// </summary>
        /// <param name="id">id of Connector</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 ConnectorsIdDelete (int? id);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConnectorApi : IConnectorApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ConnectorApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConnectorApi(String basePath)
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
        /// Get all Connectors Get all Connectors
        /// </summary>
        /// <param name="name">name</param> 
        /// <param name="displayName">display_name</param> 
        /// <param name="image">image</param> 
        /// <param name="getItUrl">get_it_url</param> 
        /// <param name="shortDescription">short_description</param> 
        /// <param name="longDescription">long_description</param> 
        /// <param name="enabled">enabled</param> 
        /// <param name="oauth">oauth</param> 
        /// <param name="limit">limit</param> 
        /// <param name="offset">offset</param> 
        /// <param name="sort">sort</param> 
        /// <returns>InlineResponse2005</returns>            
        public InlineResponse2005 ConnectorsGet (string name, string displayName, string image, string getItUrl, string shortDescription, string longDescription, bool? enabled, bool? oauth, int? limit, int? offset, string sort)
        {
            
    
            var path = "/connectors";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
             if (displayName != null) queryParams.Add("display_name", ApiClient.ParameterToString(displayName)); // query parameter
             if (image != null) queryParams.Add("image", ApiClient.ParameterToString(image)); // query parameter
             if (getItUrl != null) queryParams.Add("get_it_url", ApiClient.ParameterToString(getItUrl)); // query parameter
             if (shortDescription != null) queryParams.Add("short_description", ApiClient.ParameterToString(shortDescription)); // query parameter
             if (longDescription != null) queryParams.Add("long_description", ApiClient.ParameterToString(longDescription)); // query parameter
             if (enabled != null) queryParams.Add("enabled", ApiClient.ParameterToString(enabled)); // query parameter
             if (oauth != null) queryParams.Add("oauth", ApiClient.ParameterToString(oauth)); // query parameter
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
             if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2005) ApiClient.Deserialize(response.Content, typeof(InlineResponse2005), response.Headers);
        }
    
        
        /// <summary>
        /// Store Connector Store Connector
        /// </summary>
        /// <param name="body">Connector that should be stored</param> 
        /// <returns>InlineResponse2006</returns>            
        public InlineResponse2006 ConnectorsPost (Connector body)
        {
            
    
            var path = "/connectors";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2006) ApiClient.Deserialize(response.Content, typeof(InlineResponse2006), response.Headers);
        }
    
        
        /// <summary>
        /// Get Connector Get Connector
        /// </summary>
        /// <param name="id">id of Connector</param> 
        /// <returns>InlineResponse2006</returns>            
        public InlineResponse2006 ConnectorsIdGet (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConnectorsIdGet");
            
    
            var path = "/connectors/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2006) ApiClient.Deserialize(response.Content, typeof(InlineResponse2006), response.Headers);
        }
    
        
        /// <summary>
        /// Update Connector Update Connector
        /// </summary>
        /// <param name="id">id of Connector</param> 
        /// <param name="body">Connector that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 ConnectorsIdPut (int? id, Connector body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConnectorsIdPut");
            
    
            var path = "/connectors/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
        /// <summary>
        /// Delete Connector Delete Connector
        /// </summary>
        /// <param name="id">id of Connector</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 ConnectorsIdDelete (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConnectorsIdDelete");
            
    
            var path = "/connectors/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ConnectorsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
    }
    
}
