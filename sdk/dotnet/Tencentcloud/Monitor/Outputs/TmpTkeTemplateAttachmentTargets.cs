// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Monitor.Outputs
{

    [OutputType]
    public sealed class TmpTkeTemplateAttachmentTargets
    {
        /// <summary>
        /// ID of the cluster.
        /// </summary>
        public readonly string? ClusterId;
        /// <summary>
        /// Name the cluster.
        /// </summary>
        public readonly string? ClusterName;
        /// <summary>
        /// Cluster type.
        /// </summary>
        public readonly string? ClusterType;
        /// <summary>
        /// instance id.
        /// </summary>
        public readonly string InstanceId;
        /// <summary>
        /// Name of the prometheus instance.
        /// </summary>
        public readonly string? InstanceName;
        /// <summary>
        /// target area.
        /// </summary>
        public readonly string Region;
        /// <summary>
        /// Last sync template time.
        /// </summary>
        public readonly string? SyncTime;
        /// <summary>
        /// Template version currently in use.
        /// </summary>
        public readonly string? Version;

        [OutputConstructor]
        private TmpTkeTemplateAttachmentTargets(
            string? clusterId,

            string? clusterName,

            string? clusterType,

            string instanceId,

            string? instanceName,

            string region,

            string? syncTime,

            string? version)
        {
            ClusterId = clusterId;
            ClusterName = clusterName;
            ClusterType = clusterType;
            InstanceId = instanceId;
            InstanceName = instanceName;
            Region = region;
            SyncTime = syncTime;
            Version = version;
        }
    }
}
