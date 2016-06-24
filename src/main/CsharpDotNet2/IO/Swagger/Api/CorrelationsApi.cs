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
    public interface ICorrelationsApi
    {
        /// <summary>
        /// Get aggregated correlations Get correlations based on the anonymized aggregate data from all QuantiModo users.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations</param>
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations</param>
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action</param>
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed.</param>
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.</param>
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order.</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        List<Correlation> V1AggregatedCorrelationsGet (string accessToken, string effect, string cause, string correlationCoefficient, string onsetDelay, string durationOfAction, string lastUpdated, int? limit, int? offset, int? sort);
        /// <summary>
        /// Store or Update a Correlation Add correlation
        /// </summary>
        /// <param name="body">Provides correlation data</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns></returns>
        void V1AggregatedCorrelationsPost (PostCorrelation body, string accessToken);
        /// <summary>
        /// Get correlations Get correlations.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;correlationCoefficient&lt;/b&gt; - Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action&lt;/li&gt;&lt;li&gt;&lt;b&gt;onsetDelay&lt;/b&gt; - The number of seconds which pass following a cause measurement before an effect would likely be observed.&lt;/li&gt;&lt;li&gt;&lt;b&gt;durationOfAction&lt;/b&gt; - The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations</param>
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations</param>
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action</param>
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed.</param>
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.</param>
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order.</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        List<Correlation> V1CorrelationsGet (string accessToken, string effect, string cause, string correlationCoefficient, string onsetDelay, string durationOfAction, string lastUpdated, int? limit, int? offset, int? sort);
        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given cause. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </summary>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Effect variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="includePublic">Include public correlations, Can be \&quot;1\&quot; or empty.</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        List<Correlation> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken, string includePublic);
        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </summary>
        /// <param name="organizationId">Organization ID</param>
        /// <param name="userId">User id</param>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="organizationToken">Organization access token</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="includePublic">Include public correlations, Can be \&quot;1\&quot; or empty.</param>
        /// <returns>List&lt;CommonResponse&gt;</returns>
        List<CommonResponse> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken, string includePublic);
        /// <summary>
        /// Get average correlations for variables containing search term Returns the average correlations from all users for all public variables that contain the characters in the search query. Returns average of all users public variable correlations with a specified cause or effect.
        /// </summary>
        /// <param name="search">Name of the variable that you want to know the causes or effects of.</param>
        /// <param name="effectOrCause">Setting this to effect indicates that the searched variable is the effect and that the causes of this variable should be returned.  cause indicates that the searched variable is the cause and the effects should be returned.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        List<Correlation> V1PublicCorrelationsSearchSearchGet (string search, string effectOrCause, string accessToken);
        /// <summary>
        /// Search user correlations for a given effect Returns average of all correlations and votes for all user cause variables for a given effect
        /// </summary>
        /// <param name="variableName">Effect variable name</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        List<Correlation> V1VariablesVariableNameCausesGet (string variableName);
        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user effect variables for a given cause
        /// </summary>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        List<Correlation> V1VariablesVariableNameEffectsGet (string variableName, string accessToken);
        /// <summary>
        /// Search public correlations for a given effect Returns average of all correlations and votes for all public cause variables for a given effect
        /// </summary>
        /// <param name="variableName">Effect variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        List<Correlation> V1VariablesVariableNamePublicCausesGet (string variableName, string accessToken);
        /// <summary>
        /// Search public correlations for a given cause Returns average of all correlations and votes for all public cause variables for a given cause
        /// </summary>
        /// <param name="variableName">Cause variable name</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>List&lt;Correlation&gt;</returns>
        List<Correlation> V1VariablesVariableNamePublicEffectsGet (string variableName, string accessToken);
        /// <summary>
        /// Delete vote Delete previously posted vote
        /// </summary>
        /// <param name="body">The cause and effect variable names for the predictor vote to be deleted.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>CommonResponse</returns>
        CommonResponse V1VotesDeletePost (VoteDelete body, string accessToken);
        /// <summary>
        /// Post or update vote This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <param name="body">Contains the cause variable, effect variable, and vote value.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>CommonResponse</returns>
        CommonResponse V1VotesPost (PostVote body, string accessToken);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CorrelationsApi : ICorrelationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorrelationsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CorrelationsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CorrelationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CorrelationsApi(String basePath)
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
        /// Get aggregated correlations Get correlations based on the anonymized aggregate data from all QuantiModo users.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations</param> 
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations</param> 
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action</param> 
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed.</param> 
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.</param> 
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param> 
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order.</param> 
        /// <returns>List&lt;Correlation&gt;</returns>            
        public List<Correlation> V1AggregatedCorrelationsGet (string accessToken, string effect, string cause, string correlationCoefficient, string onsetDelay, string durationOfAction, string lastUpdated, int? limit, int? offset, int? sort)
        {
            
    
            var path = "/v1/aggregatedCorrelations";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
 if (effect != null) queryParams.Add("effect", ApiClient.ParameterToString(effect)); // query parameter
 if (cause != null) queryParams.Add("cause", ApiClient.ParameterToString(cause)); // query parameter
 if (correlationCoefficient != null) queryParams.Add("correlationCoefficient", ApiClient.ParameterToString(correlationCoefficient)); // query parameter
 if (onsetDelay != null) queryParams.Add("onsetDelay", ApiClient.ParameterToString(onsetDelay)); // query parameter
 if (durationOfAction != null) queryParams.Add("durationOfAction", ApiClient.ParameterToString(durationOfAction)); // query parameter
 if (lastUpdated != null) queryParams.Add("lastUpdated", ApiClient.ParameterToString(lastUpdated)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1AggregatedCorrelationsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1AggregatedCorrelationsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
    
        /// <summary>
        /// Store or Update a Correlation Add correlation
        /// </summary>
        /// <param name="body">Provides correlation data</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns></returns>            
        public void V1AggregatedCorrelationsPost (PostCorrelation body, string accessToken)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling V1AggregatedCorrelationsPost");
            
    
            var path = "/v1/aggregatedCorrelations";
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1AggregatedCorrelationsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1AggregatedCorrelationsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get correlations Get correlations.&lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;correlationCoefficient&lt;/b&gt; - Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action&lt;/li&gt;&lt;li&gt;&lt;b&gt;onsetDelay&lt;/b&gt; - The number of seconds which pass following a cause measurement before an effect would likely be observed.&lt;/li&gt;&lt;li&gt;&lt;b&gt;durationOfAction&lt;/b&gt; - The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="effect">ORIGINAL variable name of the effect variable for which the user desires correlations</param> 
        /// <param name="cause">ORIGINAL variable name of the cause variable for which the user desires correlations</param> 
        /// <param name="correlationCoefficient">Pearson correlation coefficient between cause and effect after lagging by onset delay and grouping by duration of action</param> 
        /// <param name="onsetDelay">The number of seconds which pass following a cause measurement before an effect would likely be observed.</param> 
        /// <param name="durationOfAction">The time in seconds over which the cause would be expected to exert a measurable effect. We have selected a default value for each variable. This default value may be replaced by a user specified by adjusting their variable user settings.</param> 
        /// <param name="lastUpdated">The time that this measurement was last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param> 
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order.</param> 
        /// <returns>List&lt;Correlation&gt;</returns>            
        public List<Correlation> V1CorrelationsGet (string accessToken, string effect, string cause, string correlationCoefficient, string onsetDelay, string durationOfAction, string lastUpdated, int? limit, int? offset, int? sort)
        {
            
    
            var path = "/v1/correlations";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
 if (effect != null) queryParams.Add("effect", ApiClient.ParameterToString(effect)); // query parameter
 if (cause != null) queryParams.Add("cause", ApiClient.ParameterToString(cause)); // query parameter
 if (correlationCoefficient != null) queryParams.Add("correlationCoefficient", ApiClient.ParameterToString(correlationCoefficient)); // query parameter
 if (onsetDelay != null) queryParams.Add("onsetDelay", ApiClient.ParameterToString(onsetDelay)); // query parameter
 if (durationOfAction != null) queryParams.Add("durationOfAction", ApiClient.ParameterToString(durationOfAction)); // query parameter
 if (lastUpdated != null) queryParams.Add("lastUpdated", ApiClient.ParameterToString(lastUpdated)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1CorrelationsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1CorrelationsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
    
        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given cause. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </summary>
        /// <param name="organizationId">Organization ID</param> 
        /// <param name="userId">User id</param> 
        /// <param name="variableName">Effect variable name</param> 
        /// <param name="organizationToken">Organization access token</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="includePublic">Include public correlations, Can be \&quot;1\&quot; or empty.</param> 
        /// <returns>List&lt;Correlation&gt;</returns>            
        public List<Correlation> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken, string includePublic)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
            
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
            
            // verify the required parameter 'organizationToken' is set
            if (organizationToken == null) throw new ApiException(400, "Missing required parameter 'organizationToken' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet");
            
    
            var path = "/v1/organizations/{organizationId}/users/{userId}/variables/{variableName}/causes";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "userId" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "variableName" + "}", ApiClient.ParameterToString(variableName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
 if (organizationToken != null) queryParams.Add("organization_token", ApiClient.ParameterToString(organizationToken)); // query parameter
 if (includePublic != null) queryParams.Add("includePublic", ApiClient.ParameterToString(includePublic)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameCausesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
    
        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user cause variables for a given effect. If parameter \&quot;include_public\&quot; is used, it also returns public correlations. User correlation overwrites or supersedes public correlation.
        /// </summary>
        /// <param name="organizationId">Organization ID</param> 
        /// <param name="userId">User id</param> 
        /// <param name="variableName">Cause variable name</param> 
        /// <param name="organizationToken">Organization access token</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="includePublic">Include public correlations, Can be \&quot;1\&quot; or empty.</param> 
        /// <returns>List&lt;CommonResponse&gt;</returns>            
        public List<CommonResponse> V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet (int? organizationId, int? userId, string variableName, string organizationToken, string accessToken, string includePublic)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
            
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
            
            // verify the required parameter 'organizationToken' is set
            if (organizationToken == null) throw new ApiException(400, "Missing required parameter 'organizationToken' when calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet");
            
    
            var path = "/v1/organizations/{organizationId}/users/{userId}/variables/{variableName}/effects";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "userId" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "variableName" + "}", ApiClient.ParameterToString(variableName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
 if (organizationToken != null) queryParams.Add("organization_token", ApiClient.ParameterToString(organizationToken)); // query parameter
 if (includePublic != null) queryParams.Add("include_public", ApiClient.ParameterToString(includePublic)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1OrganizationsOrganizationIdUsersUserIdVariablesVariableNameEffectsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<CommonResponse>) ApiClient.Deserialize(response.Content, typeof(List<CommonResponse>), response.Headers);
        }
    
        /// <summary>
        /// Get average correlations for variables containing search term Returns the average correlations from all users for all public variables that contain the characters in the search query. Returns average of all users public variable correlations with a specified cause or effect.
        /// </summary>
        /// <param name="search">Name of the variable that you want to know the causes or effects of.</param> 
        /// <param name="effectOrCause">Setting this to effect indicates that the searched variable is the effect and that the causes of this variable should be returned.  cause indicates that the searched variable is the cause and the effects should be returned.</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>List&lt;Correlation&gt;</returns>            
        public List<Correlation> V1PublicCorrelationsSearchSearchGet (string search, string effectOrCause, string accessToken)
        {
            
            // verify the required parameter 'search' is set
            if (search == null) throw new ApiException(400, "Missing required parameter 'search' when calling V1PublicCorrelationsSearchSearchGet");
            
            // verify the required parameter 'effectOrCause' is set
            if (effectOrCause == null) throw new ApiException(400, "Missing required parameter 'effectOrCause' when calling V1PublicCorrelationsSearchSearchGet");
            
    
            var path = "/v1/public/correlations/search/{search}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "search" + "}", ApiClient.ParameterToString(search));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
 if (effectOrCause != null) queryParams.Add("effectOrCause", ApiClient.ParameterToString(effectOrCause)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1PublicCorrelationsSearchSearchGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1PublicCorrelationsSearchSearchGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
    
        /// <summary>
        /// Search user correlations for a given effect Returns average of all correlations and votes for all user cause variables for a given effect
        /// </summary>
        /// <param name="variableName">Effect variable name</param> 
        /// <returns>List&lt;Correlation&gt;</returns>            
        public List<Correlation> V1VariablesVariableNameCausesGet (string variableName)
        {
            
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1VariablesVariableNameCausesGet");
            
    
            var path = "/v1/variables/{variableName}/causes";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "variableName" + "}", ApiClient.ParameterToString(variableName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNameCausesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNameCausesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
    
        /// <summary>
        /// Search user correlations for a given cause Returns average of all correlations and votes for all user effect variables for a given cause
        /// </summary>
        /// <param name="variableName">Cause variable name</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>List&lt;Correlation&gt;</returns>            
        public List<Correlation> V1VariablesVariableNameEffectsGet (string variableName, string accessToken)
        {
            
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1VariablesVariableNameEffectsGet");
            
    
            var path = "/v1/variables/{variableName}/effects";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "variableName" + "}", ApiClient.ParameterToString(variableName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNameEffectsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNameEffectsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
    
        /// <summary>
        /// Search public correlations for a given effect Returns average of all correlations and votes for all public cause variables for a given effect
        /// </summary>
        /// <param name="variableName">Effect variable name</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>List&lt;Correlation&gt;</returns>            
        public List<Correlation> V1VariablesVariableNamePublicCausesGet (string variableName, string accessToken)
        {
            
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1VariablesVariableNamePublicCausesGet");
            
    
            var path = "/v1/variables/{variableName}/public/causes";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "variableName" + "}", ApiClient.ParameterToString(variableName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNamePublicCausesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNamePublicCausesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
    
        /// <summary>
        /// Search public correlations for a given cause Returns average of all correlations and votes for all public cause variables for a given cause
        /// </summary>
        /// <param name="variableName">Cause variable name</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>List&lt;Correlation&gt;</returns>            
        public List<Correlation> V1VariablesVariableNamePublicEffectsGet (string variableName, string accessToken)
        {
            
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1VariablesVariableNamePublicEffectsGet");
            
    
            var path = "/v1/variables/{variableName}/public/effects";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "variableName" + "}", ApiClient.ParameterToString(variableName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNamePublicEffectsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VariablesVariableNamePublicEffectsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Correlation>) ApiClient.Deserialize(response.Content, typeof(List<Correlation>), response.Headers);
        }
    
        /// <summary>
        /// Delete vote Delete previously posted vote
        /// </summary>
        /// <param name="body">The cause and effect variable names for the predictor vote to be deleted.</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>CommonResponse</returns>            
        public CommonResponse V1VotesDeletePost (VoteDelete body, string accessToken)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling V1VotesDeletePost");
            
    
            var path = "/v1/votes/delete";
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1VotesDeletePost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VotesDeletePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponse) ApiClient.Deserialize(response.Content, typeof(CommonResponse), response.Headers);
        }
    
        /// <summary>
        /// Post or update vote This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <param name="body">Contains the cause variable, effect variable, and vote value.</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>CommonResponse</returns>            
        public CommonResponse V1VotesPost (PostVote body, string accessToken)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling V1VotesPost");
            
    
            var path = "/v1/votes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1VotesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1VotesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponse) ApiClient.Deserialize(response.Content, typeof(CommonResponse), response.Headers);
        }
    
    }
}
