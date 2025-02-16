// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Workloads.Models;

namespace Azure.ResourceManager.Workloads
{
    /// <summary> A class representing the SapApplicationServerInstance data model. </summary>
    public partial class SapApplicationServerInstanceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of SapApplicationServerInstanceData. </summary>
        /// <param name="location"> The location. </param>
        public SapApplicationServerInstanceData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of SapApplicationServerInstanceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="instanceNo"> The application server instance id. </param>
        /// <param name="subnetId"> The application server subnet. </param>
        /// <param name="hostname"> The application server SAP host name. </param>
        /// <param name="kernelVersion"> The application server SAP kernel version. </param>
        /// <param name="kernelPatch"> The application server SAP kernel patch. </param>
        /// <param name="ipAddress"> The application server SAP IP Address. </param>
        /// <param name="gatewayPort"> The application server gateway Port. </param>
        /// <param name="icmHttpPort"> The application server ICM HTTP Port. </param>
        /// <param name="icmHttpsPort"> The application server ICM HTTPS Port. </param>
        /// <param name="virtualMachineId"> The virtual machine. </param>
        /// <param name="status"> Defines the SAP Instance status. </param>
        /// <param name="health"> Defines the SAP Instance health. </param>
        /// <param name="provisioningState"> Defines the provisioning states. </param>
        /// <param name="errors"> Defines the Application Instance errors. </param>
        internal SapApplicationServerInstanceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string instanceNo, ResourceIdentifier subnetId, string hostname, string kernelVersion, string kernelPatch, string ipAddress, long? gatewayPort, long? icmHttpPort, long? icmHttpsPort, ResourceIdentifier virtualMachineId, SapVirtualInstanceStatus? status, SapHealthState? health, SapVirtualInstanceProvisioningState? provisioningState, SapVirtualInstanceError errors) : base(id, name, resourceType, systemData, tags, location)
        {
            InstanceNo = instanceNo;
            SubnetId = subnetId;
            Hostname = hostname;
            KernelVersion = kernelVersion;
            KernelPatch = kernelPatch;
            IPAddress = ipAddress;
            GatewayPort = gatewayPort;
            IcmHttpPort = icmHttpPort;
            IcmHttpsPort = icmHttpsPort;
            VirtualMachineId = virtualMachineId;
            Status = status;
            Health = health;
            ProvisioningState = provisioningState;
            Errors = errors;
        }

        /// <summary> The application server instance id. </summary>
        public string InstanceNo { get; }
        /// <summary> The application server subnet. </summary>
        public ResourceIdentifier SubnetId { get; }
        /// <summary> The application server SAP host name. </summary>
        public string Hostname { get; }
        /// <summary> The application server SAP kernel version. </summary>
        public string KernelVersion { get; }
        /// <summary> The application server SAP kernel patch. </summary>
        public string KernelPatch { get; }
        /// <summary> The application server SAP IP Address. </summary>
        public string IPAddress { get; }
        /// <summary> The application server gateway Port. </summary>
        public long? GatewayPort { get; }
        /// <summary> The application server ICM HTTP Port. </summary>
        public long? IcmHttpPort { get; }
        /// <summary> The application server ICM HTTPS Port. </summary>
        public long? IcmHttpsPort { get; }
        /// <summary> The virtual machine. </summary>
        public ResourceIdentifier VirtualMachineId { get; }
        /// <summary> Defines the SAP Instance status. </summary>
        public SapVirtualInstanceStatus? Status { get; }
        /// <summary> Defines the SAP Instance health. </summary>
        public SapHealthState? Health { get; }
        /// <summary> Defines the provisioning states. </summary>
        public SapVirtualInstanceProvisioningState? ProvisioningState { get; }
        /// <summary> Defines the Application Instance errors. </summary>
        internal SapVirtualInstanceError Errors { get; }
        /// <summary> The Virtual Instance for SAP error body. </summary>
        public SapVirtualInstanceErrorDetail ErrorsProperties
        {
            get => Errors?.Properties;
        }
    }
}
