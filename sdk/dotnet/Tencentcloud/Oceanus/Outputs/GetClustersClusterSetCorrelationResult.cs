// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Oceanus.Outputs
{

    [OutputType]
    public sealed class GetClustersClusterSetCorrelationResult
    {
        /// <summary>
        /// Cluster ID.
        /// </summary>
        public readonly int ClusterGroupId;
        /// <summary>
        /// Cluster SerialId.
        /// </summary>
        public readonly string ClusterGroupSerialId;
        /// <summary>
        /// Cluster name.
        /// </summary>
        public readonly string ClusterName;
        /// <summary>
        /// Project ID.
        /// </summary>
        public readonly int ProjectId;
        /// <summary>
        /// Project ID in string format.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string ProjectIdStr;
        /// <summary>
        /// The status of the cluster. Possible values are 1 (uninitialized), 3 (initializing), and 2 (running).
        /// </summary>
        public readonly int Status;
        /// <summary>
        /// Workspace SerialId.
        /// </summary>
        public readonly string WorkSpaceId;
        /// <summary>
        /// Workspace name.
        /// </summary>
        public readonly string WorkSpaceName;

        [OutputConstructor]
        private GetClustersClusterSetCorrelationResult(
            int clusterGroupId,

            string clusterGroupSerialId,

            string clusterName,

            int projectId,

            string projectIdStr,

            int status,

            string workSpaceId,

            string workSpaceName)
        {
            ClusterGroupId = clusterGroupId;
            ClusterGroupSerialId = clusterGroupSerialId;
            ClusterName = clusterName;
            ProjectId = projectId;
            ProjectIdStr = projectIdStr;
            Status = status;
            WorkSpaceId = workSpaceId;
            WorkSpaceName = workSpaceName;
        }
    }
}