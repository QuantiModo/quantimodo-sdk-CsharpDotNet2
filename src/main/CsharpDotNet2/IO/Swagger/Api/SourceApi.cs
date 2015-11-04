using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    public interface ISourceApi
    {
        
        /// <summary>
        /// Get all Sources Get all Sources
        /// </summary>
        /// <param name="clientId">client_id</param>
        /// <param name="name">name</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse20013</returns>
        InlineResponse20013 SourcesGet (string clientId, string name, string createdAt, string updatedAt, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store Source Store Source
        /// </summary>
        /// <param name="body">Source that should be stored</param>
        /// <returns>InlineResponse20014</returns>
        InlineResponse20014 SourcesPost (Source body);
        
        /// <summary>
        /// Get Source Get Source
        /// </summary>
        /// <param name="id">id of Source</param>
        /// <returns>InlineResponse20014</returns>
        InlineResponse20014 SourcesIdGet (int? id);
        
        /// <summary>
        /// Update Source Update Source
        /// </summary>
        /// <param name="id">id of Source</param>
        /// <param name="body">Source that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 SourcesIdPut (int? id, Source body);
        
        /// <summary>
        /// Delete Source Delete Source
        /// </summary>
        /// <param name="id">id of Source</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 SourcesIdDelete (int? id);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SourceApi : ISourceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SourceApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SourceApi(String basePath)
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
        /// Get all Sources Get all Sources
        /// </summary>
        /// <param name="clientId">client_id</param> 
        /// <param name="name">name</param> 
        /// <param name="createdAt">created_at</param> 
        /// <param name="updatedAt">updated_at</param> 
        /// <param name="limit">limit</param> 
        /// <param name="offset">offset</param> 
        /// <param name="sort">sort</param> 
        /// <returns>InlineResponse20013</returns>            
        public InlineResponse20013 SourcesGet (string clientId, string name, string createdAt, string updatedAt, int? limit, int? offset, string sort)
        {
            
    
            var path = "/sources";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling SourcesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SourcesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20013) ApiClient.Deserialize(response.Content, typeof(InlineResponse20013), response.Headers);
        }
    
        
        /// <summary>
        /// Store Source Store Source
        /// </summary>
        /// <param name="body">Source that should be stored</param> 
        /// <returns>InlineResponse20014</returns>            
        public InlineResponse20014 SourcesPost (Source body)
        {
            
    
            var path = "/sources";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SourcesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SourcesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20014) ApiClient.Deserialize(response.Content, typeof(InlineResponse20014), response.Headers);
        }
    
        
        /// <summary>
        /// Get Source Get Source
        /// </summary>
        /// <param name="id">id of Source</param> 
        /// <returns>InlineResponse20014</returns>            
        public InlineResponse20014 SourcesIdGet (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SourcesIdGet");
            
    
            var path = "/sources/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SourcesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SourcesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20014) ApiClient.Deserialize(response.Content, typeof(InlineResponse20014), response.Headers);
        }
    
        
        /// <summary>
        /// Update Source Update Source
        /// </summary>
        /// <param name="id">id of Source</param> 
        /// <param name="body">Source that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 SourcesIdPut (int? id, Source body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SourcesIdPut");
            
    
            var path = "/sources/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SourcesIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SourcesIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
        /// <summary>
        /// Delete Source Delete Source
        /// </summary>
        /// <param name="id">id of Source</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 SourcesIdDelete (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SourcesIdDelete");
            
    
            var path = "/sources/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SourcesIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SourcesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
    }
    
}
