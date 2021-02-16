// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Orbital
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// Azure Orbital service
    /// </summary>
    public partial class AzureOrbitalClient : ServiceClient<AzureOrbitalClient>, IAzureOrbitalClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// Azure Subscription ID.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Version of the API to be used with the client request.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default value is
        /// 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When set to
        /// true a unique x-ms-client-request-id value is generated and included in
        /// each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        public virtual IOperations Operations { get; private set; }

        /// <summary>
        /// Gets the IOrbitalOperations.
        /// </summary>
        public virtual IOrbitalOperations Orbital { get; private set; }

        /// <summary>
        /// Gets the ISpacecraftsOperations.
        /// </summary>
        public virtual ISpacecraftsOperations Spacecrafts { get; private set; }

        /// <summary>
        /// Gets the IContactProfilesOperations.
        /// </summary>
        public virtual IContactProfilesOperations ContactProfiles { get; private set; }

        /// <summary>
        /// Initializes a new instance of the AzureOrbitalClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling AzureOrbitalClient.Dispose(). False: will not dispose provided httpClient</param>
        protected AzureOrbitalClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AzureOrbitalClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected AzureOrbitalClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AzureOrbitalClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected AzureOrbitalClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AzureOrbitalClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected AzureOrbitalClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the AzureOrbitalClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected AzureOrbitalClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the AzureOrbitalClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AzureOrbitalClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the AzureOrbitalClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling AzureOrbitalClient.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AzureOrbitalClient(ServiceClientCredentials credentials, HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the AzureOrbitalClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AzureOrbitalClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the AzureOrbitalClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AzureOrbitalClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the AzureOrbitalClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AzureOrbitalClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            Operations = new Operations(this);
            Orbital = new OrbitalOperations(this);
            Spacecrafts = new SpacecraftsOperations(this);
            ContactProfiles = new ContactProfilesOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            ApiVersion = "2020-09-01-preview";
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}
