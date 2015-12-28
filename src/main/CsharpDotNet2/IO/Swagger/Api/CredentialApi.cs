using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    public interface ICredentialApi
    {
        
        /// <summary>
        /// Get all Credentials Get all Credentials
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="userId">ID of user that owns this credential</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password</param>
        /// <param name="attrValue">Encrypted value for the attribute specified</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 CredentialsGet (string accessToken, int? userId, int? connectorId, string attrKey, string attrValue, string createdAt, string updatedAt, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store Credential Store Credential
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Credential that should be stored</param>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 CredentialsPost (string accessToken, Credential body);
        
        /// <summary>
        /// Get Credential Get Credential
        /// </summary>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 CredentialsIdGet (int? id, string attrKey, string accessToken);
        
        /// <summary>
        /// Update Credential Update Credential
        /// </summary>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Credential that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 CredentialsIdPut (int? id, string attrKey, string accessToken, Credential body);
        
        /// <summary>
        /// Delete Credential Delete Credential
        /// </summary>
        /// <param name="id">connector id</param>
        /// <param name="attrKey">attrKey</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 CredentialsIdDelete (int? id, string attrKey, string accessToken);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CredentialApi : ICredentialApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CredentialApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CredentialApi(String basePath)
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
        /// Get all Credentials Get all Credentials
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="userId">ID of user that owns this credential</param> 
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained</param> 
        /// <param name="attrKey">Attribute name such as token, userid, username, or password</param> 
        /// <param name="attrValue">Encrypted value for the attribute specified</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse20011</returns>            
        public InlineResponse20011 CredentialsGet (string accessToken, int? userId, int? connectorId, string attrKey, string attrValue, string createdAt, string updatedAt, int? limit, int? offset, string sort)
        {
            
    
            var path = "/credentials";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
             if (userId != null) queryParams.Add("user_id", ApiClient.ParameterToString(userId)); // query parameter
             if (connectorId != null) queryParams.Add("connector_id", ApiClient.ParameterToString(connectorId)); // query parameter
             if (attrKey != null) queryParams.Add("attr_key", ApiClient.ParameterToString(attrKey)); // query parameter
             if (attrValue != null) queryParams.Add("attr_value", ApiClient.ParameterToString(attrValue)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20011) ApiClient.Deserialize(response.Content, typeof(InlineResponse20011), response.Headers);
        }
    
        
        /// <summary>
        /// Store Credential Store Credential
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Credential that should be stored</param> 
        /// <returns>InlineResponse20012</returns>            
        public InlineResponse20012 CredentialsPost (string accessToken, Credential body)
        {
            
    
            var path = "/credentials";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20012) ApiClient.Deserialize(response.Content, typeof(InlineResponse20012), response.Headers);
        }
    
        
        /// <summary>
        /// Get Credential Get Credential
        /// </summary>
        /// <param name="id">connector id</param> 
        /// <param name="attrKey">attrKey</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20012</returns>            
        public InlineResponse20012 CredentialsIdGet (int? id, string attrKey, string accessToken)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CredentialsIdGet");
            
            // verify the required parameter 'attrKey' is set
            if (attrKey == null) throw new ApiException(400, "Missing required parameter 'attrKey' when calling CredentialsIdGet");
            
    
            var path = "/credentials/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
             if (attrKey != null) queryParams.Add("attrKey", ApiClient.ParameterToString(attrKey)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20012) ApiClient.Deserialize(response.Content, typeof(InlineResponse20012), response.Headers);
        }
    
        
        /// <summary>
        /// Update Credential Update Credential
        /// </summary>
        /// <param name="id">connector id</param> 
        /// <param name="attrKey">attrKey</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Credential that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 CredentialsIdPut (int? id, string attrKey, string accessToken, Credential body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CredentialsIdPut");
            
            // verify the required parameter 'attrKey' is set
            if (attrKey == null) throw new ApiException(400, "Missing required parameter 'attrKey' when calling CredentialsIdPut");
            
    
            var path = "/credentials/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
             if (attrKey != null) queryParams.Add("attrKey", ApiClient.ParameterToString(attrKey)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
        /// <summary>
        /// Delete Credential Delete Credential
        /// </summary>
        /// <param name="id">connector id</param> 
        /// <param name="attrKey">attrKey</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 CredentialsIdDelete (int? id, string attrKey, string accessToken)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CredentialsIdDelete");
            
            // verify the required parameter 'attrKey' is set
            if (attrKey == null) throw new ApiException(400, "Missing required parameter 'attrKey' when calling CredentialsIdDelete");
            
    
            var path = "/credentials/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
             if (attrKey != null) queryParams.Add("attrKey", ApiClient.ParameterToString(attrKey)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CredentialsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
    }
    
}
