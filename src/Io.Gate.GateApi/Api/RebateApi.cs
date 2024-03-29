/*
 * Gate API v4
 *
 * Welcome to Gate.io API  APIv4 provides spot, margin and futures trading operations. There are public APIs to retrieve the real-time market statistics, and private APIs which needs authentication to trade on user's behalf.
 *
 * Contact: support@mail.gate.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Threading.Tasks;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Io.Gate.GateApi.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRebateApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// The broker obtains the transaction history of the recommended user
        /// </summary>
        /// <remarks>
        /// Record time range cannot exceed 30 days
        /// </remarks>
        /// <exception cref="Io.Gate.GateApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currencyPair">Specify the currency pair, if not specified, return all currency pairs (optional)</param>
        /// <param name="userId">User ID. If not specified, all user records will be returned (optional)</param>
        /// <param name="from">Time range beginning, default to 7 days before current time (optional)</param>
        /// <param name="to">Time range ending, default to current time (optional)</param>
        /// <param name="limit">Maximum number of records to be returned in a single list (optional, default to 100)</param>
        /// <param name="offset">List offset, starting from 0 (optional, default to 0)</param>
        /// <returns>List&lt;AgencyTransactionHistory&gt;</returns>
        List<AgencyTransactionHistory> AgencyTransactionHistory (string currencyPair = default(string), string userId = default(string), long? from = default(long?), long? to = default(long?), int? limit = default(int?), int? offset = default(int?));

        /// <summary>
        /// The broker obtains the transaction history of the recommended user
        /// </summary>
        /// <remarks>
        /// Record time range cannot exceed 30 days
        /// </remarks>
        /// <exception cref="Io.Gate.GateApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currencyPair">Specify the currency pair, if not specified, return all currency pairs (optional)</param>
        /// <param name="userId">User ID. If not specified, all user records will be returned (optional)</param>
        /// <param name="from">Time range beginning, default to 7 days before current time (optional)</param>
        /// <param name="to">Time range ending, default to current time (optional)</param>
        /// <param name="limit">Maximum number of records to be returned in a single list (optional, default to 100)</param>
        /// <param name="offset">List offset, starting from 0 (optional, default to 0)</param>
        /// <returns>ApiResponse of List&lt;AgencyTransactionHistory&gt;</returns>
        ApiResponse<List<AgencyTransactionHistory>> AgencyTransactionHistoryWithHttpInfo (string currencyPair = default(string), string userId = default(string), long? from = default(long?), long? to = default(long?), int? limit = default(int?), int? offset = default(int?));
        /// <summary>
        /// The broker obtains the commission history of the recommended user
        /// </summary>
        /// <remarks>
        /// Record time range cannot exceed 30 days
        /// </remarks>
        /// <exception cref="Io.Gate.GateApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currency">Filter by currency. Return all currency records if not specified (optional)</param>
        /// <param name="userId">User ID. If not specified, all user records will be returned (optional)</param>
        /// <param name="from">Time range beginning, default to 7 days before current time (optional)</param>
        /// <param name="to">Time range ending, default to current time (optional)</param>
        /// <param name="limit">Maximum number of records to be returned in a single list (optional, default to 100)</param>
        /// <param name="offset">List offset, starting from 0 (optional, default to 0)</param>
        /// <returns>List&lt;AgencyCommissionHistory&gt;</returns>
        List<AgencyCommissionHistory> AgencyCommissionsHistory (string currency = default(string), string userId = default(string), long? from = default(long?), long? to = default(long?), int? limit = default(int?), int? offset = default(int?));

        /// <summary>
        /// The broker obtains the commission history of the recommended user
        /// </summary>
        /// <remarks>
        /// Record time range cannot exceed 30 days
        /// </remarks>
        /// <exception cref="Io.Gate.GateApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currency">Filter by currency. Return all currency records if not specified (optional)</param>
        /// <param name="userId">User ID. If not specified, all user records will be returned (optional)</param>
        /// <param name="from">Time range beginning, default to 7 days before current time (optional)</param>
        /// <param name="to">Time range ending, default to current time (optional)</param>
        /// <param name="limit">Maximum number of records to be returned in a single list (optional, default to 100)</param>
        /// <param name="offset">List offset, starting from 0 (optional, default to 0)</param>
        /// <returns>ApiResponse of List&lt;AgencyCommissionHistory&gt;</returns>
        ApiResponse<List<AgencyCommissionHistory>> AgencyCommissionsHistoryWithHttpInfo (string currency = default(string), string userId = default(string), long? from = default(long?), long? to = default(long?), int? limit = default(int?), int? offset = default(int?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRebateApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// The broker obtains the transaction history of the recommended user
        /// </summary>
        /// <remarks>
        /// Record time range cannot exceed 30 days
        /// </remarks>
        /// <exception cref="Io.Gate.GateApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currencyPair">Specify the currency pair, if not specified, return all currency pairs (optional)</param>
        /// <param name="userId">User ID. If not specified, all user records will be returned (optional)</param>
        /// <param name="from">Time range beginning, default to 7 days before current time (optional)</param>
        /// <param name="to">Time range ending, default to current time (optional)</param>
        /// <param name="limit">Maximum number of records to be returned in a single list (optional, default to 100)</param>
        /// <param name="offset">List offset, starting from 0 (optional, default to 0)</param>
        /// <returns>Task of List&lt;AgencyTransactionHistory&gt;</returns>
        Task<List<AgencyTransactionHistory>> AgencyTransactionHistoryAsync (string currencyPair = default(string), string userId = default(string), long? from = default(long?), long? to = default(long?), int? limit = default(int?), int? offset = default(int?));

        /// <summary>
        /// The broker obtains the transaction history of the recommended user
        /// </summary>
        /// <remarks>
        /// Record time range cannot exceed 30 days
        /// </remarks>
        /// <exception cref="Io.Gate.GateApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currencyPair">Specify the currency pair, if not specified, return all currency pairs (optional)</param>
        /// <param name="userId">User ID. If not specified, all user records will be returned (optional)</param>
        /// <param name="from">Time range beginning, default to 7 days before current time (optional)</param>
        /// <param name="to">Time range ending, default to current time (optional)</param>
        /// <param name="limit">Maximum number of records to be returned in a single list (optional, default to 100)</param>
        /// <param name="offset">List offset, starting from 0 (optional, default to 0)</param>
        /// <returns>Task of ApiResponse (List&lt;AgencyTransactionHistory&gt;)</returns>
        Task<ApiResponse<List<AgencyTransactionHistory>>> AgencyTransactionHistoryAsyncWithHttpInfo (string currencyPair = default(string), string userId = default(string), long? from = default(long?), long? to = default(long?), int? limit = default(int?), int? offset = default(int?));
        /// <summary>
        /// The broker obtains the commission history of the recommended user
        /// </summary>
        /// <remarks>
        /// Record time range cannot exceed 30 days
        /// </remarks>
        /// <exception cref="Io.Gate.GateApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currency">Filter by currency. Return all currency records if not specified (optional)</param>
        /// <param name="userId">User ID. If not specified, all user records will be returned (optional)</param>
        /// <param name="from">Time range beginning, default to 7 days before current time (optional)</param>
        /// <param name="to">Time range ending, default to current time (optional)</param>
        /// <param name="limit">Maximum number of records to be returned in a single list (optional, default to 100)</param>
        /// <param name="offset">List offset, starting from 0 (optional, default to 0)</param>
        /// <returns>Task of List&lt;AgencyCommissionHistory&gt;</returns>
        Task<List<AgencyCommissionHistory>> AgencyCommissionsHistoryAsync (string currency = default(string), string userId = default(string), long? from = default(long?), long? to = default(long?), int? limit = default(int?), int? offset = default(int?));

        /// <summary>
        /// The broker obtains the commission history of the recommended user
        /// </summary>
        /// <remarks>
        /// Record time range cannot exceed 30 days
        /// </remarks>
        /// <exception cref="Io.Gate.GateApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currency">Filter by currency. Return all currency records if not specified (optional)</param>
        /// <param name="userId">User ID. If not specified, all user records will be returned (optional)</param>
        /// <param name="from">Time range beginning, default to 7 days before current time (optional)</param>
        /// <param name="to">Time range ending, default to current time (optional)</param>
        /// <param name="limit">Maximum number of records to be returned in a single list (optional, default to 100)</param>
        /// <param name="offset">List offset, starting from 0 (optional, default to 0)</param>
        /// <returns>Task of ApiResponse (List&lt;AgencyCommissionHistory&gt;)</returns>
        Task<ApiResponse<List<AgencyCommissionHistory>>> AgencyCommissionsHistoryAsyncWithHttpInfo (string currency = default(string), string userId = default(string), long? from = default(long?), long? to = default(long?), int? limit = default(int?), int? offset = default(int?));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRebateApi : IRebateApiSync, IRebateApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RebateApi : IRebateApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RebateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RebateApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RebateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RebateApi(string basePath)
        {
            this.Configuration = Io.Gate.GateApi.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.Client = new ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Io.Gate.GateApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RebateApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RebateApi(Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Io.Gate.GateApi.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Io.Gate.GateApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RebateApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public RebateApi(ISynchronousClient client,IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Io.Gate.GateApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// The broker obtains the transaction history of the recommended user Record time range cannot exceed 30 days
        /// </summary>
        /// <exception cref="Io.Gate.GateApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currencyPair">Specify the currency pair, if not specified, return all currency pairs (optional)</param>
        /// <param name="userId">User ID. If not specified, all user records will be returned (optional)</param>
        /// <param name="from">Time range beginning, default to 7 days before current time (optional)</param>
        /// <param name="to">Time range ending, default to current time (optional)</param>
        /// <param name="limit">Maximum number of records to be returned in a single list (optional, default to 100)</param>
        /// <param name="offset">List offset, starting from 0 (optional, default to 0)</param>
        /// <returns>List&lt;AgencyTransactionHistory&gt;</returns>
        public List<AgencyTransactionHistory> AgencyTransactionHistory (string currencyPair = default(string), string userId = default(string), long? from = default(long?), long? to = default(long?), int? limit = default(int?), int? offset = default(int?))
        {
             ApiResponse<List<AgencyTransactionHistory>> localVarResponse = AgencyTransactionHistoryWithHttpInfo(currencyPair, userId, from, to, limit, offset);
             return localVarResponse.Data;
        }

        /// <summary>
        /// The broker obtains the transaction history of the recommended user Record time range cannot exceed 30 days
        /// </summary>
        /// <exception cref="Io.Gate.GateApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currencyPair">Specify the currency pair, if not specified, return all currency pairs (optional)</param>
        /// <param name="userId">User ID. If not specified, all user records will be returned (optional)</param>
        /// <param name="from">Time range beginning, default to 7 days before current time (optional)</param>
        /// <param name="to">Time range ending, default to current time (optional)</param>
        /// <param name="limit">Maximum number of records to be returned in a single list (optional, default to 100)</param>
        /// <param name="offset">List offset, starting from 0 (optional, default to 0)</param>
        /// <returns>ApiResponse of List&lt;AgencyTransactionHistory&gt;</returns>
        public ApiResponse<List<AgencyTransactionHistory>> AgencyTransactionHistoryWithHttpInfo (string currencyPair = default(string), string userId = default(string), long? from = default(long?), long? to = default(long?), int? limit = default(int?), int? offset = default(int?))
        {
            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = {
            };

            // to determine the Accept header
            string[] _accepts = {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (currencyPair != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "currency_pair", currencyPair));
            }
            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "user_id", userId));
            }
            if (from != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "from", from));
            }
            if (to != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "to", to));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (offset != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "offset", offset));
            }

            // authentication (apiv4) required
            localVarRequestOptions.RequireApiV4Auth = true;

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<AgencyTransactionHistory>>("/rebate/agency/transaction_history", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AgencyTransactionHistory", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// The broker obtains the transaction history of the recommended user Record time range cannot exceed 30 days
        /// </summary>
        /// <exception cref="Io.Gate.GateApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currencyPair">Specify the currency pair, if not specified, return all currency pairs (optional)</param>
        /// <param name="userId">User ID. If not specified, all user records will be returned (optional)</param>
        /// <param name="from">Time range beginning, default to 7 days before current time (optional)</param>
        /// <param name="to">Time range ending, default to current time (optional)</param>
        /// <param name="limit">Maximum number of records to be returned in a single list (optional, default to 100)</param>
        /// <param name="offset">List offset, starting from 0 (optional, default to 0)</param>
        /// <returns>Task of List&lt;AgencyTransactionHistory&gt;</returns>
        public async Task<List<AgencyTransactionHistory>> AgencyTransactionHistoryAsync (string currencyPair = default(string), string userId = default(string), long? from = default(long?), long? to = default(long?), int? limit = default(int?), int? offset = default(int?))
        {
             Io.Gate.GateApi.Client.ApiResponse<List<AgencyTransactionHistory>> localVarResponse = await AgencyTransactionHistoryAsyncWithHttpInfo(currencyPair, userId, from, to, limit, offset);
             return localVarResponse.Data;

        }

        /// <summary>
        /// The broker obtains the transaction history of the recommended user Record time range cannot exceed 30 days
        /// </summary>
        /// <exception cref="Io.Gate.GateApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currencyPair">Specify the currency pair, if not specified, return all currency pairs (optional)</param>
        /// <param name="userId">User ID. If not specified, all user records will be returned (optional)</param>
        /// <param name="from">Time range beginning, default to 7 days before current time (optional)</param>
        /// <param name="to">Time range ending, default to current time (optional)</param>
        /// <param name="limit">Maximum number of records to be returned in a single list (optional, default to 100)</param>
        /// <param name="offset">List offset, starting from 0 (optional, default to 0)</param>
        /// <returns>Task of ApiResponse (List&lt;AgencyTransactionHistory&gt;)</returns>
        public async Task<ApiResponse<List<AgencyTransactionHistory>>> AgencyTransactionHistoryAsyncWithHttpInfo (string currencyPair = default(string), string userId = default(string), long? from = default(long?), long? to = default(long?), int? limit = default(int?), int? offset = default(int?))
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);

            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);

            if (currencyPair != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "currency_pair", currencyPair));
            }
            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "user_id", userId));
            }
            if (from != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "from", from));
            }
            if (to != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "to", to));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (offset != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "offset", offset));
            }

            // authentication (apiv4) required
            localVarRequestOptions.RequireApiV4Auth = true;

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<AgencyTransactionHistory>>("/rebate/agency/transaction_history", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AgencyTransactionHistory", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// The broker obtains the commission history of the recommended user Record time range cannot exceed 30 days
        /// </summary>
        /// <exception cref="Io.Gate.GateApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currency">Filter by currency. Return all currency records if not specified (optional)</param>
        /// <param name="userId">User ID. If not specified, all user records will be returned (optional)</param>
        /// <param name="from">Time range beginning, default to 7 days before current time (optional)</param>
        /// <param name="to">Time range ending, default to current time (optional)</param>
        /// <param name="limit">Maximum number of records to be returned in a single list (optional, default to 100)</param>
        /// <param name="offset">List offset, starting from 0 (optional, default to 0)</param>
        /// <returns>List&lt;AgencyCommissionHistory&gt;</returns>
        public List<AgencyCommissionHistory> AgencyCommissionsHistory (string currency = default(string), string userId = default(string), long? from = default(long?), long? to = default(long?), int? limit = default(int?), int? offset = default(int?))
        {
             ApiResponse<List<AgencyCommissionHistory>> localVarResponse = AgencyCommissionsHistoryWithHttpInfo(currency, userId, from, to, limit, offset);
             return localVarResponse.Data;
        }

        /// <summary>
        /// The broker obtains the commission history of the recommended user Record time range cannot exceed 30 days
        /// </summary>
        /// <exception cref="Io.Gate.GateApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currency">Filter by currency. Return all currency records if not specified (optional)</param>
        /// <param name="userId">User ID. If not specified, all user records will be returned (optional)</param>
        /// <param name="from">Time range beginning, default to 7 days before current time (optional)</param>
        /// <param name="to">Time range ending, default to current time (optional)</param>
        /// <param name="limit">Maximum number of records to be returned in a single list (optional, default to 100)</param>
        /// <param name="offset">List offset, starting from 0 (optional, default to 0)</param>
        /// <returns>ApiResponse of List&lt;AgencyCommissionHistory&gt;</returns>
        public ApiResponse<List<AgencyCommissionHistory>> AgencyCommissionsHistoryWithHttpInfo (string currency = default(string), string userId = default(string), long? from = default(long?), long? to = default(long?), int? limit = default(int?), int? offset = default(int?))
        {
            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = {
            };

            // to determine the Accept header
            string[] _accepts = {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (currency != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "currency", currency));
            }
            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "user_id", userId));
            }
            if (from != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "from", from));
            }
            if (to != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "to", to));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (offset != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "offset", offset));
            }

            // authentication (apiv4) required
            localVarRequestOptions.RequireApiV4Auth = true;

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<AgencyCommissionHistory>>("/rebate/agency/commission_history", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AgencyCommissionsHistory", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// The broker obtains the commission history of the recommended user Record time range cannot exceed 30 days
        /// </summary>
        /// <exception cref="Io.Gate.GateApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currency">Filter by currency. Return all currency records if not specified (optional)</param>
        /// <param name="userId">User ID. If not specified, all user records will be returned (optional)</param>
        /// <param name="from">Time range beginning, default to 7 days before current time (optional)</param>
        /// <param name="to">Time range ending, default to current time (optional)</param>
        /// <param name="limit">Maximum number of records to be returned in a single list (optional, default to 100)</param>
        /// <param name="offset">List offset, starting from 0 (optional, default to 0)</param>
        /// <returns>Task of List&lt;AgencyCommissionHistory&gt;</returns>
        public async Task<List<AgencyCommissionHistory>> AgencyCommissionsHistoryAsync (string currency = default(string), string userId = default(string), long? from = default(long?), long? to = default(long?), int? limit = default(int?), int? offset = default(int?))
        {
             Io.Gate.GateApi.Client.ApiResponse<List<AgencyCommissionHistory>> localVarResponse = await AgencyCommissionsHistoryAsyncWithHttpInfo(currency, userId, from, to, limit, offset);
             return localVarResponse.Data;

        }

        /// <summary>
        /// The broker obtains the commission history of the recommended user Record time range cannot exceed 30 days
        /// </summary>
        /// <exception cref="Io.Gate.GateApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currency">Filter by currency. Return all currency records if not specified (optional)</param>
        /// <param name="userId">User ID. If not specified, all user records will be returned (optional)</param>
        /// <param name="from">Time range beginning, default to 7 days before current time (optional)</param>
        /// <param name="to">Time range ending, default to current time (optional)</param>
        /// <param name="limit">Maximum number of records to be returned in a single list (optional, default to 100)</param>
        /// <param name="offset">List offset, starting from 0 (optional, default to 0)</param>
        /// <returns>Task of ApiResponse (List&lt;AgencyCommissionHistory&gt;)</returns>
        public async Task<ApiResponse<List<AgencyCommissionHistory>>> AgencyCommissionsHistoryAsyncWithHttpInfo (string currency = default(string), string userId = default(string), long? from = default(long?), long? to = default(long?), int? limit = default(int?), int? offset = default(int?))
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);

            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);

            if (currency != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "currency", currency));
            }
            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "user_id", userId));
            }
            if (from != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "from", from));
            }
            if (to != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "to", to));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (offset != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "offset", offset));
            }

            // authentication (apiv4) required
            localVarRequestOptions.RequireApiV4Auth = true;

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<AgencyCommissionHistory>>("/rebate/agency/commission_history", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AgencyCommissionsHistory", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
