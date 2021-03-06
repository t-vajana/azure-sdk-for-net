// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Resources;

namespace Azure.Management.Resources
{
    /// <summary> Resources service management client. </summary>
    public class ResourcesManagementClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _subscriptionId;

        /// <summary> Initializes a new instance of ResourcesManagementClient for mocking. </summary>
        protected ResourcesManagementClient()
        {
        }

        /// <summary> Initializes a new instance of ResourcesManagementClient. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="tokenCredential"> The OAuth token for making client requests. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public ResourcesManagementClient(string subscriptionId, TokenCredential tokenCredential, ResourcesManagementClientOptions options = null) : this(null, subscriptionId, tokenCredential, options)
        {
        }
        /// <summary> Initializes a new instance of ResourcesManagementClient. </summary>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="tokenCredential"> The OAuth token for making client requests. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public ResourcesManagementClient(Uri endpoint, string subscriptionId, TokenCredential tokenCredential, ResourcesManagementClientOptions options = null)
        {
            endpoint ??= new Uri("https://management.azure.com");
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }

            options ??= new ResourcesManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, endpoint, options);
            _endpoint = endpoint;
            _subscriptionId = subscriptionId;
        }

        /// <summary> Creates a new instance of OperationsClient. </summary>
        public virtual OperationsClient GetOperationsClient()
        {
            return new OperationsClient(_clientDiagnostics, _pipeline, _endpoint);
        }

        /// <summary> Creates a new instance of DeploymentsClient. </summary>
        public virtual DeploymentsClient GetDeploymentsClient()
        {
            return new DeploymentsClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of ProvidersClient. </summary>
        public virtual ProvidersClient GetProvidersClient()
        {
            return new ProvidersClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of ResourcesClient. </summary>
        public virtual ResourcesClient GetResourcesClient()
        {
            return new ResourcesClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of ResourceGroupsClient. </summary>
        public virtual ResourceGroupsClient GetResourceGroupsClient()
        {
            return new ResourceGroupsClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of TagsClient. </summary>
        public virtual TagsClient GetTagsClient()
        {
            return new TagsClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of DeploymentClient. </summary>
        public virtual DeploymentClient GetDeploymentClient()
        {
            return new DeploymentClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of SubscriptionsClient. </summary>
        public virtual SubscriptionsClient GetSubscriptionsClient()
        {
            return new SubscriptionsClient(_clientDiagnostics, _pipeline, _endpoint);
        }

        /// <summary> Creates a new instance of TenantsClient. </summary>
        public virtual TenantsClient GetTenantsClient()
        {
            return new TenantsClient(_clientDiagnostics, _pipeline, _endpoint);
        }

        /// <summary> Creates a new instance of PolicyAssignmentsClient. </summary>
        public virtual PolicyAssignmentsClient GetPolicyAssignmentsClient()
        {
            return new PolicyAssignmentsClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of PolicyDefinitionsClient. </summary>
        public virtual PolicyDefinitionsClient GetPolicyDefinitionsClient()
        {
            return new PolicyDefinitionsClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of PolicySetDefinitionsClient. </summary>
        public virtual PolicySetDefinitionsClient GetPolicySetDefinitionsClient()
        {
            return new PolicySetDefinitionsClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of DeploymentScriptsClient. </summary>
        public virtual DeploymentScriptsClient GetDeploymentScriptsClient()
        {
            return new DeploymentScriptsClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of ServiceClient. </summary>
        public virtual ServiceClient GetServiceClient()
        {
            return new ServiceClient(_clientDiagnostics, _pipeline, _endpoint);
        }

        /// <summary> Creates a new instance of FeaturesClient. </summary>
        public virtual FeaturesClient GetFeaturesClient()
        {
            return new FeaturesClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of AuthorizationClient. </summary>
        public virtual AuthorizationClient GetAuthorizationClient()
        {
            return new AuthorizationClient(_clientDiagnostics, _pipeline, _endpoint);
        }

        /// <summary> Creates a new instance of ManagementLocksClient. </summary>
        public virtual ManagementLocksClient GetManagementLocksClient()
        {
            return new ManagementLocksClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of ResourceLinksClient. </summary>
        public virtual ResourceLinksClient GetResourceLinksClient()
        {
            return new ResourceLinksClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of ApplicationsClient. </summary>
        public virtual ApplicationsClient GetApplicationsClient()
        {
            return new ApplicationsClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of ApplicationDefinitionsClient. </summary>
        public virtual ApplicationDefinitionsClient GetApplicationDefinitionsClient()
        {
            return new ApplicationDefinitionsClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }
    }
}
