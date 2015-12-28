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
        /// Get all available units Get all available units
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this unit</param>
        /// <param name="name">Unit name</param>
        /// <param name="abbreviatedName">Unit abbreviation</param>
        /// <param name="categoryId">Unit category ID</param>
        /// <param name="minimumValue">Minimum value permitted for this unit</param>
        /// <param name="maximumValue">Maximum value permitted for this unit</param>
        /// <param name="updated">updated</param>
        /// <param name="defaultUnitId">ID of default unit for this units category</param>
        /// <param name="multiply">Value multiplied to convert to default unit in this unit category</param>
        /// <param name="add">Value which should be added to convert to default unit</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse20026</returns>
        InlineResponse20026 UnitsGet (string accessToken, string clientId, string name, string abbreviatedName, int? categoryId, double? minimumValue, double? maximumValue, int? updated, int? defaultUnitId, double? multiply, double? add, string createdAt, string updatedAt, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store Unit Store Unit
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Unit that should be stored</param>
        /// <returns>InlineResponse20027</returns>
        InlineResponse20027 UnitsPost (string accessToken, Unit body);
        
        /// <summary>
        /// Get Unit Get Unit
        /// </summary>
        /// <param name="id">id of Unit</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20027</returns>
        InlineResponse20027 UnitsIdGet (int? id, string accessToken);
        
        /// <summary>
        /// Update Unit Update Unit
        /// </summary>
        /// <param name="id">id of Unit</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Unit that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UnitsIdPut (int? id, string accessToken, Unit body);
        
        /// <summary>
        /// Delete Unit Delete Unit
        /// </summary>
        /// <param name="id">id of Unit</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UnitsIdDelete (int? id, string accessToken);
        
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
        /// Get all available units Get all available units
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="clientId">The ID of the client application which last created or updated this unit</param> 
        /// <param name="name">Unit name</param> 
        /// <param name="abbreviatedName">Unit abbreviation</param> 
        /// <param name="categoryId">Unit category ID</param> 
        /// <param name="minimumValue">Minimum value permitted for this unit</param> 
        /// <param name="maximumValue">Maximum value permitted for this unit</param> 
        /// <param name="updated">updated</param> 
        /// <param name="defaultUnitId">ID of default unit for this units category</param> 
        /// <param name="multiply">Value multiplied to convert to default unit in this unit category</param> 
        /// <param name="add">Value which should be added to convert to default unit</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse20026</returns>            
        public InlineResponse20026 UnitsGet (string accessToken, string clientId, string name, string abbreviatedName, int? categoryId, double? minimumValue, double? maximumValue, int? updated, int? defaultUnitId, double? multiply, double? add, string createdAt, string updatedAt, int? limit, int? offset, string sort)
        {
            
    
            var path = "/units";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
             if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
             if (abbreviatedName != null) queryParams.Add("abbreviated_name", ApiClient.ParameterToString(abbreviatedName)); // query parameter
             if (categoryId != null) queryParams.Add("category_id", ApiClient.ParameterToString(categoryId)); // query parameter
             if (minimumValue != null) queryParams.Add("minimum_value", ApiClient.ParameterToString(minimumValue)); // query parameter
             if (maximumValue != null) queryParams.Add("maximum_value", ApiClient.ParameterToString(maximumValue)); // query parameter
             if (updated != null) queryParams.Add("updated", ApiClient.ParameterToString(updated)); // query parameter
             if (defaultUnitId != null) queryParams.Add("default_unit_id", ApiClient.ParameterToString(defaultUnitId)); // query parameter
             if (multiply != null) queryParams.Add("multiply", ApiClient.ParameterToString(multiply)); // query parameter
             if (add != null) queryParams.Add("add", ApiClient.ParameterToString(add)); // query parameter
             if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
             if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
             if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UnitsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UnitsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20026) ApiClient.Deserialize(response.Content, typeof(InlineResponse20026), response.Headers);
        }
    
        
        /// <summary>
        /// Store Unit Store Unit
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Unit that should be stored</param> 
        /// <returns>InlineResponse20027</returns>            
        public InlineResponse20027 UnitsPost (string accessToken, Unit body)
        {
            
    
            var path = "/units";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UnitsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UnitsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20027) ApiClient.Deserialize(response.Content, typeof(InlineResponse20027), response.Headers);
        }
    
        
        /// <summary>
        /// Get Unit Get Unit
        /// </summary>
        /// <param name="id">id of Unit</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20027</returns>            
        public InlineResponse20027 UnitsIdGet (int? id, string accessToken)
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
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UnitsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UnitsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20027) ApiClient.Deserialize(response.Content, typeof(InlineResponse20027), response.Headers);
        }
    
        
        /// <summary>
        /// Update Unit Update Unit
        /// </summary>
        /// <param name="id">id of Unit</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Unit that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 UnitsIdPut (int? id, string accessToken, Unit body)
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
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
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
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 UnitsIdDelete (int? id, string accessToken)
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
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
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
