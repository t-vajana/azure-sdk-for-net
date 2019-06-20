// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The network configuration for the job.
    /// </summary>
    public partial class JobNetworkConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the JobNetworkConfiguration class.
        /// </summary>
        public JobNetworkConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobNetworkConfiguration class.
        /// </summary>
        /// <param name="subnetId">The ARM resource identifier of the virtual
        /// network subnet which nodes running tasks from the job will join for
        /// the duration of the task. This will only work with a
        /// VirtualMachineConfiguration pool.</param>
        public JobNetworkConfiguration(string subnetId)
        {
            SubnetId = subnetId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ARM resource identifier of the virtual network
        /// subnet which nodes running tasks from the job will join for the
        /// duration of the task. This will only work with a
        /// VirtualMachineConfiguration pool.
        /// </summary>
        /// <remarks>
        /// The virtual network must be in the same region and subscription as
        /// the Azure Batch account. The specified subnet should have enough
        /// free IP addresses to accommodate the number of nodes which will run
        /// tasks from the job. This can be up to the number of nodes in the
        /// pool. The 'MicrosoftAzureBatch' service principal must have the
        /// 'Classic Virtual Machine Contributor' Role-Based Access Control
        /// (RBAC) role for the specified VNet so that Azure Batch service can
        /// schedule tasks on the compute nodes. This can be verified by
        /// checking if the specified VNet has any associated Network Security
        /// Groups (NSG). If communication to the compute nodes in the
        /// specified subnet is denied by an NSG, then the Batch service will
        /// set the state of the compute nodes to unusable. This is of the form
        /// /subscriptions/{subscription}/resourceGroups/{group}/providers/{provider}/virtualNetworks/{network}/subnets/{subnet}.
        /// If the specified VNet has any associated Network Security Groups
        /// (NSG), then a few reserved system ports must be enabled for inbound
        /// communication from the Azure Batch service. For pools created with
        /// a Virtual Machine configuration, enable ports 29876 and 29877, as
        /// well as port 22 for Linux and port 3389 for Windows. Port 443 is
        /// also required to be open for outbound connections for
        /// communications to Azure Storage. For more details see:
        /// https://docs.microsoft.com/en-us/azure/batch/batch-api-basics#virtual-network-vnet-and-firewall-configuration
        /// </remarks>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }

    }
}