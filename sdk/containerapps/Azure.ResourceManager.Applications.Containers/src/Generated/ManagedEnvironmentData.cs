// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Applications.Containers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Applications.Containers
{
    /// <summary> A class representing the ManagedEnvironment data model. </summary>
    public partial class ManagedEnvironmentData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ManagedEnvironmentData. </summary>
        /// <param name="location"> The location. </param>
        public ManagedEnvironmentData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ManagedEnvironmentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Provisioning state of the Environment. </param>
        /// <param name="daprAIInstrumentationKey"> Azure Monitor instrumentation key used by Dapr to export Service to Service communication telemetry. </param>
        /// <param name="daprAIConnectionString"> Application Insights connection string used by Dapr to export Service to Service communication telemetry. </param>
        /// <param name="vnetConfiguration"> Vnet configuration for the environment. </param>
        /// <param name="deploymentErrors"> Any errors that occurred during deployment or deployment validation. </param>
        /// <param name="defaultDomain"> Default Domain Name for the cluster. </param>
        /// <param name="staticIP"> Static IP of the Environment. </param>
        /// <param name="appLogsConfiguration">
        /// Cluster configuration which enables the log daemon to export
        /// app logs to a destination. Currently only &quot;log-analytics&quot; is
        /// supported
        /// </param>
        /// <param name="zoneRedundant"> Whether or not this Managed Environment is zone-redundant. </param>
        internal ManagedEnvironmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, EnvironmentProvisioningState? provisioningState, string daprAIInstrumentationKey, string daprAIConnectionString, VnetConfiguration vnetConfiguration, string deploymentErrors, string defaultDomain, string staticIP, AppLogsConfiguration appLogsConfiguration, bool? zoneRedundant) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            DaprAIInstrumentationKey = daprAIInstrumentationKey;
            DaprAIConnectionString = daprAIConnectionString;
            VnetConfiguration = vnetConfiguration;
            DeploymentErrors = deploymentErrors;
            DefaultDomain = defaultDomain;
            StaticIP = staticIP;
            AppLogsConfiguration = appLogsConfiguration;
            ZoneRedundant = zoneRedundant;
        }

        /// <summary> Provisioning state of the Environment. </summary>
        public EnvironmentProvisioningState? ProvisioningState { get; }
        /// <summary> Azure Monitor instrumentation key used by Dapr to export Service to Service communication telemetry. </summary>
        public string DaprAIInstrumentationKey { get; set; }
        /// <summary> Application Insights connection string used by Dapr to export Service to Service communication telemetry. </summary>
        public string DaprAIConnectionString { get; set; }
        /// <summary> Vnet configuration for the environment. </summary>
        public VnetConfiguration VnetConfiguration { get; set; }
        /// <summary> Any errors that occurred during deployment or deployment validation. </summary>
        public string DeploymentErrors { get; }
        /// <summary> Default Domain Name for the cluster. </summary>
        public string DefaultDomain { get; }
        /// <summary> Static IP of the Environment. </summary>
        public string StaticIP { get; }
        /// <summary>
        /// Cluster configuration which enables the log daemon to export
        /// app logs to a destination. Currently only &quot;log-analytics&quot; is
        /// supported
        /// </summary>
        public AppLogsConfiguration AppLogsConfiguration { get; set; }
        /// <summary> Whether or not this Managed Environment is zone-redundant. </summary>
        public bool? ZoneRedundant { get; set; }
    }
}
