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
    public interface IConnectorsApi
    {
        /// <summary>
        /// Get embeddable connect javascript Get embeddable connect javascript. Usage:    - Embedding in applications with popups for 3rd-party authentication windows.      Use &#x60;qmSetupInPopup&#x60; function after connecting &#x60;connect.js&#x60;.    - Embedding in applications with popups for 3rd-party authentication windows.      Requires a selector to block. It will be embedded in this block.      Use &#x60;qmSetupOnPage&#x60; function after connecting &#x60;connect.js&#x60;.    - Embedding in mobile applications without popups for 3rd-party authentication.      Use &#x60;qmSetupOnMobile&#x60; function after connecting &#x60;connect.js&#x60;.      if using the MoodiModo Clones, Use &#x60;qmSetupOnIonic&#x60; function after connecting &#x60;connect.js&#x60;. 
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns></returns>
        void V1ConnectJsGet (string accessToken);
        /// <summary>
        /// Mobile connect page This page is designed to be opened in a webview.  Instead of using popup authentication boxes, it uses redirection. You can include the user&#39;s access_token as a URL parameter like https://app.quantimo.do/api/v1/connect/mobile?access_token&#x3D;123
        /// </summary>
        /// <param name="accessToken">User OAuth access token</param>
        /// <returns></returns>
        void V1ConnectMobileGet (string accessToken);
        /// <summary>
        /// Obtain a token from 3rd party data source Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns></returns>
        void V1ConnectorsConnectorConnectGet (string connector, string accessToken);
        /// <summary>
        /// Connection Instructions Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="parameters">JSON Array of Parameters for the request to enable connector.</param>
        /// <param name="url">URL which should be used to enable the connector.</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns></returns>
        void V1ConnectorsConnectorConnectInstructionsGet (string connector, string parameters, string url, bool? usePopup, string accessToken);
        /// <summary>
        /// Connect Parameter Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="displayName">Name of the parameter that is user visible in the form</param>
        /// <param name="key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request)</param>
        /// <param name="placeholder">Placeholder hint value for the parameter input tag.</param>
        /// <param name="type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param>
        /// <param name="usePopup">Should use popup when enabling connector</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="defaultValue">Default parameter value</param>
        /// <returns>ConnectorInstruction</returns>
        ConnectorInstruction V1ConnectorsConnectorConnectParameterGet (string connector, string displayName, string key, string placeholder, string type, bool? usePopup, string accessToken, string defaultValue);
        /// <summary>
        /// Delete stored connection info The disconnect method deletes any stored tokens or connection information from the connectors database.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <returns></returns>
        void V1ConnectorsConnectorDisconnectGet (string connector);
        /// <summary>
        /// Get connector info for user Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>ConnectorInfo</returns>
        ConnectorInfo V1ConnectorsConnectorInfoGet (string connector, string accessToken);
        /// <summary>
        /// Sync with data source The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns></returns>
        void V1ConnectorsConnectorUpdateGet (string connector, string accessToken);
        /// <summary>
        /// List of Connectors A connector pulls data from other data providers using their API or a screenscraper. Returns a list of all available connectors and information about them such as their id, name, whether the user has provided access, logo url, connection instructions, and the update history.
        /// </summary>
        /// <returns>List&lt;Connector&gt;</returns>
        List<Connector> V1ConnectorsListGet ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConnectorsApi : IConnectorsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ConnectorsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConnectorsApi(String basePath)
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
        /// Get embeddable connect javascript Get embeddable connect javascript. Usage:    - Embedding in applications with popups for 3rd-party authentication windows.      Use &#x60;qmSetupInPopup&#x60; function after connecting &#x60;connect.js&#x60;.    - Embedding in applications with popups for 3rd-party authentication windows.      Requires a selector to block. It will be embedded in this block.      Use &#x60;qmSetupOnPage&#x60; function after connecting &#x60;connect.js&#x60;.    - Embedding in mobile applications without popups for 3rd-party authentication.      Use &#x60;qmSetupOnMobile&#x60; function after connecting &#x60;connect.js&#x60;.      if using the MoodiModo Clones, Use &#x60;qmSetupOnIonic&#x60; function after connecting &#x60;connect.js&#x60;. 
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns></returns>            
        public void V1ConnectJsGet (string accessToken)
        {
            
    
            var path = "/v1/connect.js";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2", "internalApiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectJsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectJsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Mobile connect page This page is designed to be opened in a webview.  Instead of using popup authentication boxes, it uses redirection. You can include the user&#39;s access_token as a URL parameter like https://app.quantimo.do/api/v1/connect/mobile?access_token&#x3D;123
        /// </summary>
        /// <param name="accessToken">User OAuth access token</param> 
        /// <returns></returns>            
        public void V1ConnectMobileGet (string accessToken)
        {
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling V1ConnectMobileGet");
            
    
            var path = "/v1/connect/mobile";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2", "internalApiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectMobileGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectMobileGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Obtain a token from 3rd party data source Attempt to obtain a token from the data provider, store it in the database. With this, the connector to continue to obtain new user data until the token is revoked.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns></returns>            
        public void V1ConnectorsConnectorConnectGet (string connector, string accessToken)
        {
            
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling V1ConnectorsConnectorConnectGet");
            
    
            var path = "/v1/connectors/{connector}/connect";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "connector" + "}", ApiClient.ParameterToString(connector));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorConnectGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorConnectGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Connection Instructions Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param> 
        /// <param name="parameters">JSON Array of Parameters for the request to enable connector.</param> 
        /// <param name="url">URL which should be used to enable the connector.</param> 
        /// <param name="usePopup">Should use popup when enabling connector</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns></returns>            
        public void V1ConnectorsConnectorConnectInstructionsGet (string connector, string parameters, string url, bool? usePopup, string accessToken)
        {
            
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling V1ConnectorsConnectorConnectInstructionsGet");
            
            // verify the required parameter 'parameters' is set
            if (parameters == null) throw new ApiException(400, "Missing required parameter 'parameters' when calling V1ConnectorsConnectorConnectInstructionsGet");
            
            // verify the required parameter 'url' is set
            if (url == null) throw new ApiException(400, "Missing required parameter 'url' when calling V1ConnectorsConnectorConnectInstructionsGet");
            
            // verify the required parameter 'usePopup' is set
            if (usePopup == null) throw new ApiException(400, "Missing required parameter 'usePopup' when calling V1ConnectorsConnectorConnectInstructionsGet");
            
    
            var path = "/v1/connectors/{connector}/connectInstructions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "connector" + "}", ApiClient.ParameterToString(connector));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
 if (parameters != null) queryParams.Add("parameters", ApiClient.ParameterToString(parameters)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
 if (usePopup != null) queryParams.Add("usePopup", ApiClient.ParameterToString(usePopup)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorConnectInstructionsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorConnectInstructionsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Connect Parameter Returns instructions that describe what parameters and endpoint to use to connect to the given data provider.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param> 
        /// <param name="displayName">Name of the parameter that is user visible in the form</param> 
        /// <param name="key">Name of the property that the user has to enter such as username or password Connector (used in HTTP request)</param> 
        /// <param name="placeholder">Placeholder hint value for the parameter input tag.</param> 
        /// <param name="type">Type of input field such as those found here http://www.w3schools.com/tags/tag_input.asp</param> 
        /// <param name="usePopup">Should use popup when enabling connector</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="defaultValue">Default parameter value</param> 
        /// <returns>ConnectorInstruction</returns>            
        public ConnectorInstruction V1ConnectorsConnectorConnectParameterGet (string connector, string displayName, string key, string placeholder, string type, bool? usePopup, string accessToken, string defaultValue)
        {
            
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling V1ConnectorsConnectorConnectParameterGet");
            
            // verify the required parameter 'displayName' is set
            if (displayName == null) throw new ApiException(400, "Missing required parameter 'displayName' when calling V1ConnectorsConnectorConnectParameterGet");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling V1ConnectorsConnectorConnectParameterGet");
            
            // verify the required parameter 'placeholder' is set
            if (placeholder == null) throw new ApiException(400, "Missing required parameter 'placeholder' when calling V1ConnectorsConnectorConnectParameterGet");
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling V1ConnectorsConnectorConnectParameterGet");
            
            // verify the required parameter 'usePopup' is set
            if (usePopup == null) throw new ApiException(400, "Missing required parameter 'usePopup' when calling V1ConnectorsConnectorConnectParameterGet");
            
    
            var path = "/v1/connectors/{connector}/connectParameter";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "connector" + "}", ApiClient.ParameterToString(connector));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
 if (defaultValue != null) queryParams.Add("defaultValue", ApiClient.ParameterToString(defaultValue)); // query parameter
 if (displayName != null) queryParams.Add("displayName", ApiClient.ParameterToString(displayName)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (placeholder != null) queryParams.Add("placeholder", ApiClient.ParameterToString(placeholder)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (usePopup != null) queryParams.Add("usePopup", ApiClient.ParameterToString(usePopup)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorConnectParameterGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorConnectParameterGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ConnectorInstruction) ApiClient.Deserialize(response.Content, typeof(ConnectorInstruction), response.Headers);
        }
    
        /// <summary>
        /// Delete stored connection info The disconnect method deletes any stored tokens or connection information from the connectors database.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param> 
        /// <returns></returns>            
        public void V1ConnectorsConnectorDisconnectGet (string connector)
        {
            
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling V1ConnectorsConnectorDisconnectGet");
            
    
            var path = "/v1/connectors/{connector}/disconnect";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "connector" + "}", ApiClient.ParameterToString(connector));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorDisconnectGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorDisconnectGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get connector info for user Returns information about the connector such as the connector id, whether or not is connected for this user (i.e. we have a token or credentials), and its update history for the user.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device. Get a list of available connectors from the /connectors/list endpoint.</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>ConnectorInfo</returns>            
        public ConnectorInfo V1ConnectorsConnectorInfoGet (string connector, string accessToken)
        {
            
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling V1ConnectorsConnectorInfoGet");
            
    
            var path = "/v1/connectors/{connector}/info";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "connector" + "}", ApiClient.ParameterToString(connector));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorInfoGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorInfoGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ConnectorInfo) ApiClient.Deserialize(response.Content, typeof(ConnectorInfo), response.Headers);
        }
    
        /// <summary>
        /// Sync with data source The update method tells the QM Connector Framework to check with the data provider (such as Fitbit or MyFitnessPal) and retrieve any new measurements available.
        /// </summary>
        /// <param name="connector">Lowercase system name of the source application or device</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns></returns>            
        public void V1ConnectorsConnectorUpdateGet (string connector, string accessToken)
        {
            
            // verify the required parameter 'connector' is set
            if (connector == null) throw new ApiException(400, "Missing required parameter 'connector' when calling V1ConnectorsConnectorUpdateGet");
            
    
            var path = "/v1/connectors/{connector}/update";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "connector" + "}", ApiClient.ParameterToString(connector));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorUpdateGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsConnectorUpdateGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// List of Connectors A connector pulls data from other data providers using their API or a screenscraper. Returns a list of all available connectors and information about them such as their id, name, whether the user has provided access, logo url, connection instructions, and the update history.
        /// </summary>
        /// <returns>List&lt;Connector&gt;</returns>            
        public List<Connector> V1ConnectorsListGet ()
        {
            
    
            var path = "/v1/connectors/list";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsListGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1ConnectorsListGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Connector>) ApiClient.Deserialize(response.Content, typeof(List<Connector>), response.Headers);
        }
    
    }
}
