using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    public interface IVoteApi
    {
        
        /// <summary>
        /// Get all Votes Get all Votes
        /// </summary>
        /// <param name="clientId">client_id</param>
        /// <param name="userId">user_id</param>
        /// <param name="causeId">cause_id</param>
        /// <param name="effectId">effect_id</param>
        /// <param name="value">value</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse20029</returns>
        InlineResponse20029 VotesGet (string clientId, int? userId, int? causeId, int? effectId, int? value, string createdAt, string updatedAt, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store Vote Store Vote
        /// </summary>
        /// <param name="body">Vote that should be stored</param>
        /// <returns>InlineResponse20030</returns>
        InlineResponse20030 VotesPost (Vote body);
        
        /// <summary>
        /// Get Vote Get Vote
        /// </summary>
        /// <param name="id">id of Vote</param>
        /// <returns>InlineResponse20030</returns>
        InlineResponse20030 VotesIdGet (int? id);
        
        /// <summary>
        /// Update Vote Update Vote
        /// </summary>
        /// <param name="id">id of Vote</param>
        /// <param name="body">Vote that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 VotesIdPut (int? id, Vote body);
        
        /// <summary>
        /// Delete Vote Delete Vote
        /// </summary>
        /// <param name="id">id of Vote</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 VotesIdDelete (int? id);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VoteApi : IVoteApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoteApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VoteApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VoteApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VoteApi(String basePath)
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
        /// Get all Votes Get all Votes
        /// </summary>
        /// <param name="clientId">client_id</param> 
        /// <param name="userId">user_id</param> 
        /// <param name="causeId">cause_id</param> 
        /// <param name="effectId">effect_id</param> 
        /// <param name="value">value</param> 
        /// <param name="createdAt">created_at</param> 
        /// <param name="updatedAt">updated_at</param> 
        /// <param name="limit">limit</param> 
        /// <param name="offset">offset</param> 
        /// <param name="sort">sort</param> 
        /// <returns>InlineResponse20029</returns>            
        public InlineResponse20029 VotesGet (string clientId, int? userId, int? causeId, int? effectId, int? value, string createdAt, string updatedAt, int? limit, int? offset, string sort)
        {
            
    
            var path = "/votes";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
             if (userId != null) queryParams.Add("user_id", ApiClient.ParameterToString(userId)); // query parameter
             if (causeId != null) queryParams.Add("cause_id", ApiClient.ParameterToString(causeId)); // query parameter
             if (effectId != null) queryParams.Add("effect_id", ApiClient.ParameterToString(effectId)); // query parameter
             if (value != null) queryParams.Add("value", ApiClient.ParameterToString(value)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling VotesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VotesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20029) ApiClient.Deserialize(response.Content, typeof(InlineResponse20029), response.Headers);
        }
    
        
        /// <summary>
        /// Store Vote Store Vote
        /// </summary>
        /// <param name="body">Vote that should be stored</param> 
        /// <returns>InlineResponse20030</returns>            
        public InlineResponse20030 VotesPost (Vote body)
        {
            
    
            var path = "/votes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VotesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VotesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20030) ApiClient.Deserialize(response.Content, typeof(InlineResponse20030), response.Headers);
        }
    
        
        /// <summary>
        /// Get Vote Get Vote
        /// </summary>
        /// <param name="id">id of Vote</param> 
        /// <returns>InlineResponse20030</returns>            
        public InlineResponse20030 VotesIdGet (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VotesIdGet");
            
    
            var path = "/votes/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VotesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VotesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20030) ApiClient.Deserialize(response.Content, typeof(InlineResponse20030), response.Headers);
        }
    
        
        /// <summary>
        /// Update Vote Update Vote
        /// </summary>
        /// <param name="id">id of Vote</param> 
        /// <param name="body">Vote that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 VotesIdPut (int? id, Vote body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VotesIdPut");
            
    
            var path = "/votes/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VotesIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VotesIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
        /// <summary>
        /// Delete Vote Delete Vote
        /// </summary>
        /// <param name="id">id of Vote</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 VotesIdDelete (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VotesIdDelete");
            
    
            var path = "/votes/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VotesIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VotesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
    }
    
}
