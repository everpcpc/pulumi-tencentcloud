// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tsf.Outputs
{

    [OutputType]
    public sealed class LaneLaneGroupList
    {
        /// <summary>
        /// application ID.
        /// </summary>
        public readonly string? ApplicationId;
        /// <summary>
        /// application name.
        /// </summary>
        public readonly string? ApplicationName;
        /// <summary>
        /// cluster type.
        /// </summary>
        public readonly string? ClusterType;
        /// <summary>
        /// creation time.
        /// </summary>
        public readonly int? CreateTime;
        /// <summary>
        /// Whether to enter the application.
        /// </summary>
        public readonly bool Entrance;
        /// <summary>
        /// Deployment group ID.
        /// </summary>
        public readonly string GroupId;
        /// <summary>
        /// deployment group name.
        /// </summary>
        public readonly string? GroupName;
        /// <summary>
        /// Swimlane deployment group ID.
        /// </summary>
        public readonly string? LaneGroupId;
        /// <summary>
        /// Lane ID.
        /// </summary>
        public readonly string? LaneId;
        /// <summary>
        /// Namespace ID.
        /// </summary>
        public readonly string? NamespaceId;
        /// <summary>
        /// namespace name.
        /// </summary>
        public readonly string? NamespaceName;
        /// <summary>
        /// update time.
        /// </summary>
        public readonly int? UpdateTime;

        [OutputConstructor]
        private LaneLaneGroupList(
            string? applicationId,

            string? applicationName,

            string? clusterType,

            int? createTime,

            bool entrance,

            string groupId,

            string? groupName,

            string? laneGroupId,

            string? laneId,

            string? namespaceId,

            string? namespaceName,

            int? updateTime)
        {
            ApplicationId = applicationId;
            ApplicationName = applicationName;
            ClusterType = clusterType;
            CreateTime = createTime;
            Entrance = entrance;
            GroupId = groupId;
            GroupName = groupName;
            LaneGroupId = laneGroupId;
            LaneId = laneId;
            NamespaceId = namespaceId;
            NamespaceName = namespaceName;
            UpdateTime = updateTime;
        }
    }
}
