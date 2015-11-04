using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    public interface IUnitCategoryApi
    {
        
        /// <summary>
        /// Get all UnitCategories Get all UnitCategories
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse20015</returns>
        InlineResponse20015 UnitCategoriesGet (string name, string createdAt, string updatedAt, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store UnitCategory Store UnitCategory
        /// </summary>
        /// <param name="body">UnitCategory that should be stored</param>
        /// <returns>InlineResponse20016</returns>
        InlineResponse20016 UnitCategoriesPost (UnitCategory body);
        
        /// <summary>
        /// Get UnitCategory Get UnitCategory
        /// </summary>
        /// <param name="id">id of UnitCategory</param>
        /// <returns>InlineResponse20016</returns>
        InlineResponse20016 UnitCategoriesIdGet (int? id);
        
        /// <summary>
        /// Update UnitCategory Update UnitCategory
        /// </summary>
        /// <param name="id">id of UnitCategory</param>
        /// <param name="body">UnitCategory that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UnitCategoriesIdPut (int? id, UnitCategory body);
        
        /// <summary>
        /// Delete UnitCategory Delete UnitCategory
        /// </summary>
        /// <param name="id">id of UnitCategory</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UnitCategoriesIdDelete (int? id);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UnitCategoryApi : IUnitCategoryApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitCategoryApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UnitCategoryApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitCategoryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UnitCategoryApi(String basePath)
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
        /// Get all UnitCategories Get all UnitCategories
        /// </summary>
        /// <param name="name">name</param> 
        /// <param name="createdAt">created_at</param> 
        /// <param name="updatedAt">updated_at</param> 
        /// <param name="limit">limit</param> 
        /// <param name="offset">offset</param> 
        /// <param name="sort">sort</param> 
        /// <returns>InlineResponse20015</returns>            
        public InlineResponse20015 UnitCategoriesGet (string name, string createdAt, string updatedAt, int? limit, int? offset, string sort)
        {
            
    
            var path = "/unitCategories";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UnitCategoriesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UnitCategoriesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20015) ApiClient.Deserialize(response.Content, typeof(InlineResponse20015), response.Headers);
        }
    
        
        /// <summary>
        /// Store UnitCategory Store UnitCategory
        /// </summary>
        /// <param name="body">UnitCategory that should be stored</param> 
        /// <returns>InlineResponse20016</returns>            
        public InlineResponse20016 UnitCategoriesPost (UnitCategory body)
        {
            
    
            var path = "/unitCategories";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UnitCategoriesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UnitCategoriesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20016) ApiClient.Deserialize(response.Content, typeof(InlineResponse20016), response.Headers);
        }
    
        
        /// <summary>
        /// Get UnitCategory Get UnitCategory
        /// </summary>
        /// <param name="id">id of UnitCategory</param> 
        /// <returns>InlineResponse20016</returns>            
        public InlineResponse20016 UnitCategoriesIdGet (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UnitCategoriesIdGet");
            
    
            var path = "/unitCategories/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UnitCategoriesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UnitCategoriesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20016) ApiClient.Deserialize(response.Content, typeof(InlineResponse20016), response.Headers);
        }
    
        
        /// <summary>
        /// Update UnitCategory Update UnitCategory
        /// </summary>
        /// <param name="id">id of UnitCategory</param> 
        /// <param name="body">UnitCategory that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 UnitCategoriesIdPut (int? id, UnitCategory body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UnitCategoriesIdPut");
            
    
            var path = "/unitCategories/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UnitCategoriesIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UnitCategoriesIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
        /// <summary>
        /// Delete UnitCategory Delete UnitCategory
        /// </summary>
        /// <param name="id">id of UnitCategory</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 UnitCategoriesIdDelete (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UnitCategoriesIdDelete");
            
    
            var path = "/unitCategories/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UnitCategoriesIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UnitCategoriesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
    }
    
}
