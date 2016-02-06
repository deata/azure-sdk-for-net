// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.DataLake.Analytics;
using Microsoft.Azure.Management.DataLake.Analytics.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.DataLake.Analytics
{
    /// <summary>
    /// Creates an Azure Data Lake Analytics account management client.
    /// </summary>
    public partial class DataLakeAnalyticsManagementClient : ServiceClient<DataLakeAnalyticsManagementClient>, IDataLakeAnalyticsManagementClient
    {
        private string _apiVersion;
        
        /// <summary>
        /// Gets the API version.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
        }
        
        private Uri _baseUri;
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private int _longRunningOperationInitialTimeout;
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationInitialTimeout
        {
            get { return this._longRunningOperationInitialTimeout; }
            set { this._longRunningOperationInitialTimeout = value; }
        }
        
        private int _longRunningOperationRetryTimeout;
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationRetryTimeout
        {
            get { return this._longRunningOperationRetryTimeout; }
            set { this._longRunningOperationRetryTimeout = value; }
        }
        
        private string _userAgentSuffix;
        
        /// <summary>
        /// Gets or sets the additional UserAgent text to be added to the user
        /// agent header. This is used to further differentiate where requests
        /// are coming from internally.
        /// </summary>
        public string UserAgentSuffix
        {
            get { return this._userAgentSuffix; }
            set { this._userAgentSuffix = value; }
        }
        
        private IDataLakeAnalyticsAccountOperations _dataLakeAnalyticsAccount;
        
        /// <summary>
        /// Operations for managing Data Lake Analytics accounts
        /// </summary>
        public virtual IDataLakeAnalyticsAccountOperations DataLakeAnalyticsAccount
        {
            get { return this._dataLakeAnalyticsAccount; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DataLakeAnalyticsManagementClient
        /// class.
        /// </summary>
        public DataLakeAnalyticsManagementClient()
            : base()
        {
            this._dataLakeAnalyticsAccount = new DataLakeAnalyticsAccountOperations(this);
            this._userAgentSuffix = "";
            this._apiVersion = "2015-10-01-preview";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the DataLakeAnalyticsManagementClient
        /// class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        public DataLakeAnalyticsManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the DataLakeAnalyticsManagementClient
        /// class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        public DataLakeAnalyticsManagementClient(SubscriptionCloudCredentials credentials)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.azure.com");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the DataLakeAnalyticsManagementClient
        /// class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public DataLakeAnalyticsManagementClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._dataLakeAnalyticsAccount = new DataLakeAnalyticsAccountOperations(this);
            this._userAgentSuffix = "";
            this._apiVersion = "2015-10-01-preview";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the DataLakeAnalyticsManagementClient
        /// class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public DataLakeAnalyticsManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the DataLakeAnalyticsManagementClient
        /// class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public DataLakeAnalyticsManagementClient(SubscriptionCloudCredentials credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.azure.com");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another
        /// DataLakeAnalyticsManagementClient instance
        /// </summary>
        /// <param name='client'>
        /// Instance of DataLakeAnalyticsManagementClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<DataLakeAnalyticsManagementClient> client)
        {
            base.Clone(client);
            
            if (client is DataLakeAnalyticsManagementClient)
            {
                DataLakeAnalyticsManagementClient clonedClient = ((DataLakeAnalyticsManagementClient)client);
                
                clonedClient._userAgentSuffix = this._userAgentSuffix;
                clonedClient._credentials = this._credentials;
                clonedClient._baseUri = this._baseUri;
                clonedClient._apiVersion = this._apiVersion;
                clonedClient._longRunningOperationInitialTimeout = this._longRunningOperationInitialTimeout;
                clonedClient._longRunningOperationRetryTimeout = this._longRunningOperationRetryTimeout;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
        
        /// <summary>
        /// Parse enum values for type DataLakeAnalyticsAccountState.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static DataLakeAnalyticsAccountState ParseDataLakeAnalyticsAccountState(string value)
        {
            if ("active".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return DataLakeAnalyticsAccountState.Active;
            }
            if ("suspended".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return DataLakeAnalyticsAccountState.Suspended;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type DataLakeAnalyticsAccountState to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string DataLakeAnalyticsAccountStateToString(DataLakeAnalyticsAccountState value)
        {
            if (value == DataLakeAnalyticsAccountState.Active)
            {
                return "active";
            }
            if (value == DataLakeAnalyticsAccountState.Suspended)
            {
                return "suspended";
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Parse enum values for type DataLakeAnalyticsAccountStatus.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static DataLakeAnalyticsAccountStatus ParseDataLakeAnalyticsAccountStatus(string value)
        {
            if ("Failed".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return DataLakeAnalyticsAccountStatus.Failed;
            }
            if ("Creating".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return DataLakeAnalyticsAccountStatus.Creating;
            }
            if ("Running".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return DataLakeAnalyticsAccountStatus.Running;
            }
            if ("Succeeded".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return DataLakeAnalyticsAccountStatus.Succeeded;
            }
            if ("Patching".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return DataLakeAnalyticsAccountStatus.Patching;
            }
            if ("Suspending".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return DataLakeAnalyticsAccountStatus.Suspending;
            }
            if ("Resuming".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return DataLakeAnalyticsAccountStatus.Resuming;
            }
            if ("Deleting".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return DataLakeAnalyticsAccountStatus.Deleting;
            }
            if ("Deleted".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return DataLakeAnalyticsAccountStatus.Deleted;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type DataLakeAnalyticsAccountStatus to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string DataLakeAnalyticsAccountStatusToString(DataLakeAnalyticsAccountStatus value)
        {
            if (value == DataLakeAnalyticsAccountStatus.Failed)
            {
                return "Failed";
            }
            if (value == DataLakeAnalyticsAccountStatus.Creating)
            {
                return "Creating";
            }
            if (value == DataLakeAnalyticsAccountStatus.Running)
            {
                return "Running";
            }
            if (value == DataLakeAnalyticsAccountStatus.Succeeded)
            {
                return "Succeeded";
            }
            if (value == DataLakeAnalyticsAccountStatus.Patching)
            {
                return "Patching";
            }
            if (value == DataLakeAnalyticsAccountStatus.Suspending)
            {
                return "Suspending";
            }
            if (value == DataLakeAnalyticsAccountStatus.Resuming)
            {
                return "Resuming";
            }
            if (value == DataLakeAnalyticsAccountStatus.Deleting)
            {
                return "Deleting";
            }
            if (value == DataLakeAnalyticsAccountStatus.Deleted)
            {
                return "Deleted";
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='azureAsyncOperation'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public async Task<AzureAsyncOperationResponse> GetLongRunningOperationStatusAsync(string azureAsyncOperation, CancellationToken cancellationToken)
        {
            // Validate
            if (azureAsyncOperation == null)
            {
                throw new ArgumentNullException("azureAsyncOperation");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("azureAsyncOperation", azureAsyncOperation);
                TracingAdapter.Enter(invocationId, this, "GetLongRunningOperationStatusAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + azureAsyncOperation;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK && statusCode != HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    AzureAsyncOperationResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK || statusCode == HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new AzureAsyncOperationResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken statusValue = responseDoc["status"];
                            if (statusValue != null && statusValue.Type != JTokenType.Null)
                            {
                                OperationStatus statusInstance = ((OperationStatus)Enum.Parse(typeof(OperationStatus), ((string)statusValue), true));
                                result.Status = statusInstance;
                            }
                            
                            JToken errorValue = responseDoc["error"];
                            if (errorValue != null && errorValue.Type != JTokenType.Null)
                            {
                                Error errorInstance = new Error();
                                result.Error = errorInstance;
                                
                                JToken codeValue = errorValue["code"];
                                if (codeValue != null && codeValue.Type != JTokenType.Null)
                                {
                                    string codeInstance = ((string)codeValue);
                                    errorInstance.Code = codeInstance;
                                }
                                
                                JToken messageValue = errorValue["message"];
                                if (messageValue != null && messageValue.Type != JTokenType.Null)
                                {
                                    string messageInstance = ((string)messageValue);
                                    errorInstance.Message = messageInstance;
                                }
                                
                                JToken targetValue = errorValue["target"];
                                if (targetValue != null && targetValue.Type != JTokenType.Null)
                                {
                                    string targetInstance = ((string)targetValue);
                                    errorInstance.Target = targetInstance;
                                }
                                
                                JToken detailsArray = errorValue["details"];
                                if (detailsArray != null && detailsArray.Type != JTokenType.Null)
                                {
                                    foreach (JToken detailsValue in ((JArray)detailsArray))
                                    {
                                        ErrorDetails errorDetailsInstance = new ErrorDetails();
                                        errorInstance.Details.Add(errorDetailsInstance);
                                        
                                        JToken codeValue2 = detailsValue["code"];
                                        if (codeValue2 != null && codeValue2.Type != JTokenType.Null)
                                        {
                                            string codeInstance2 = ((string)codeValue2);
                                            errorDetailsInstance.Code = codeInstance2;
                                        }
                                        
                                        JToken messageValue2 = detailsValue["message"];
                                        if (messageValue2 != null && messageValue2.Type != JTokenType.Null)
                                        {
                                            string messageInstance2 = ((string)messageValue2);
                                            errorDetailsInstance.Message = messageInstance2;
                                        }
                                        
                                        JToken targetValue2 = detailsValue["target"];
                                        if (targetValue2 != null && targetValue2.Type != JTokenType.Null)
                                        {
                                            string targetInstance2 = ((string)targetValue2);
                                            errorDetailsInstance.Target = targetInstance2;
                                        }
                                    }
                                }
                                
                                JToken innerErrorValue = errorValue["innerError"];
                                if (innerErrorValue != null && innerErrorValue.Type != JTokenType.Null)
                                {
                                    InnerError innerErrorInstance = new InnerError();
                                    errorInstance.InnerError = innerErrorInstance;
                                    
                                    JToken traceValue = innerErrorValue["trace"];
                                    if (traceValue != null && traceValue.Type != JTokenType.Null)
                                    {
                                        string traceInstance = ((string)traceValue);
                                        innerErrorInstance.Trace = traceInstance;
                                    }
                                    
                                    JToken contextValue = innerErrorValue["context"];
                                    if (contextValue != null && contextValue.Type != JTokenType.Null)
                                    {
                                        string contextInstance = ((string)contextValue);
                                        innerErrorInstance.Context = contextInstance;
                                    }
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}