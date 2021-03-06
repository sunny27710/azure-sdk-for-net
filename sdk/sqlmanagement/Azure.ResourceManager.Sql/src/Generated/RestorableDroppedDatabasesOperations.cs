// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> The RestorableDroppedDatabases service client. </summary>
    public partial class RestorableDroppedDatabasesOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal RestorableDroppedDatabasesRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of RestorableDroppedDatabasesOperations for mocking. </summary>
        protected RestorableDroppedDatabasesOperations()
        {
        }
        /// <summary> Initializes a new instance of RestorableDroppedDatabasesOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal RestorableDroppedDatabasesOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new RestorableDroppedDatabasesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a deleted database that can be restored. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="restorableDroppededDatabaseId"> The id of the deleted database in the form of databaseName,deletionTimeInFileTimeFormat. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RestorableDroppedDatabase>> GetAsync(string resourceGroupName, string serverName, string restorableDroppededDatabaseId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RestorableDroppedDatabasesOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, serverName, restorableDroppededDatabaseId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a deleted database that can be restored. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="restorableDroppededDatabaseId"> The id of the deleted database in the form of databaseName,deletionTimeInFileTimeFormat. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RestorableDroppedDatabase> Get(string resourceGroupName, string serverName, string restorableDroppededDatabaseId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RestorableDroppedDatabasesOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, serverName, restorableDroppededDatabaseId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of deleted databases that can be restored. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="serverName"/> is null. </exception>
        public virtual AsyncPageable<RestorableDroppedDatabase> ListByServerAsync(string resourceGroupName, string serverName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }

            async Task<Page<RestorableDroppedDatabase>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestorableDroppedDatabasesOperations.ListByServer");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByServerAsync(resourceGroupName, serverName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Gets a list of deleted databases that can be restored. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="serverName"/> is null. </exception>
        public virtual Pageable<RestorableDroppedDatabase> ListByServer(string resourceGroupName, string serverName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }

            Page<RestorableDroppedDatabase> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestorableDroppedDatabasesOperations.ListByServer");
                scope.Start();
                try
                {
                    var response = RestClient.ListByServer(resourceGroupName, serverName, cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
