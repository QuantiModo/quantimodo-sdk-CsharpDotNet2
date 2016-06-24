using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITagsApi
    {
        /// <summary>
        /// Delete user tag or ingredient Delete previously created user tags or ingredients.
        /// </summary>
        /// <param name="taggedVariableId">This is the id of the variable being tagged with an ingredient or something.</param>
        /// <param name="tagVariableId">This is the id of the ingredient variable whose value is determined based on the value of the tagged variable.</param>
        /// <returns>CommonResponse</returns>
        CommonResponse V1UserTagsDeletePost (int? taggedVariableId, int? tagVariableId);
        /// <summary>
        /// Post or update user tags or ingredients This endpoint allows users to tag foods with their ingredients.  This information will then be used to infer the user intake of the different ingredients by just entering the foods. The inferred intake levels will then be used to determine the effects of different nutrients on the user during analysis.
        /// </summary>
        /// <param name="body">Contains the new user tag data</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>CommonResponse</returns>
        CommonResponse V1UserTagsPost (UserTag body, string accessToken);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TagsApi : ITagsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TagsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TagsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TagsApi(String basePath)
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
        /// Delete user tag or ingredient Delete previously created user tags or ingredients.
        /// </summary>
        /// <param name="taggedVariableId">This is the id of the variable being tagged with an ingredient or something.</param> 
        /// <param name="tagVariableId">This is the id of the ingredient variable whose value is determined based on the value of the tagged variable.</param> 
        /// <returns>CommonResponse</returns>            
        public CommonResponse V1UserTagsDeletePost (int? taggedVariableId, int? tagVariableId)
        {
            
            // verify the required parameter 'taggedVariableId' is set
            if (taggedVariableId == null) throw new ApiException(400, "Missing required parameter 'taggedVariableId' when calling V1UserTagsDeletePost");
            
            // verify the required parameter 'tagVariableId' is set
            if (tagVariableId == null) throw new ApiException(400, "Missing required parameter 'tagVariableId' when calling V1UserTagsDeletePost");
            
    
            var path = "/v1/userTags/delete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (taggedVariableId != null) queryParams.Add("taggedVariableId", ApiClient.ParameterToString(taggedVariableId)); // query parameter
 if (tagVariableId != null) queryParams.Add("tagVariableId", ApiClient.ParameterToString(tagVariableId)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1UserTagsDeletePost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1UserTagsDeletePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponse) ApiClient.Deserialize(response.Content, typeof(CommonResponse), response.Headers);
        }
    
        /// <summary>
        /// Post or update user tags or ingredients This endpoint allows users to tag foods with their ingredients.  This information will then be used to infer the user intake of the different ingredients by just entering the foods. The inferred intake levels will then be used to determine the effects of different nutrients on the user during analysis.
        /// </summary>
        /// <param name="body">Contains the new user tag data</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>CommonResponse</returns>            
        public CommonResponse V1UserTagsPost (UserTag body, string accessToken)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling V1UserTagsPost");
            
    
            var path = "/v1/userTags";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1UserTagsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1UserTagsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponse) ApiClient.Deserialize(response.Content, typeof(CommonResponse), response.Headers);
        }
    
    }
}
