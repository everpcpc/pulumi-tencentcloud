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
    public sealed class GetWorkSpacesWorkSpaceSetItemResult
    {
        /// <summary>
        /// User AppID.
        /// </summary>
        public readonly int AppId;
        /// <summary>
        /// Workspace cluster information.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetWorkSpacesWorkSpaceSetItemClusterGroupSetItemResult> ClusterGroupSetItems;
        /// <summary>
        /// Creation time.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// Creator UIN.
        /// </summary>
        public readonly string CreatorUin;
        /// <summary>
        /// Workspace description.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly int JobsCount;
        /// <summary>
        /// Main account UIN.
        /// </summary>
        public readonly string OwnerUin;
        /// <summary>
        /// Region.
        /// </summary>
        public readonly string Region;
        /// <summary>
        /// Workspace member count.
        /// </summary>
        public readonly int RoleAuthCount;
        /// <summary>
        /// Workspace role information.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetWorkSpacesWorkSpaceSetItemRoleAuthResult> RoleAuths;
        /// <summary>
        /// Workspace SerialId.
        /// </summary>
        public readonly string SerialId;
        /// <summary>
        /// 1:uninitialized; 2:available; -1:deleted.
        /// </summary>
        public readonly int Status;
        /// <summary>
        /// Update time.
        /// </summary>
        public readonly string UpdateTime;
        /// <summary>
        /// Workspace SerialId.
        /// </summary>
        public readonly string WorkSpaceId;
        /// <summary>
        /// Workspace name.
        /// </summary>
        public readonly string WorkSpaceName;

        [OutputConstructor]
        private GetWorkSpacesWorkSpaceSetItemResult(
            int appId,

            ImmutableArray<Outputs.GetWorkSpacesWorkSpaceSetItemClusterGroupSetItemResult> clusterGroupSetItems,

            string createTime,

            string creatorUin,

            string description,

            int jobsCount,

            string ownerUin,

            string region,

            int roleAuthCount,

            ImmutableArray<Outputs.GetWorkSpacesWorkSpaceSetItemRoleAuthResult> roleAuths,

            string serialId,

            int status,

            string updateTime,

            string workSpaceId,

            string workSpaceName)
        {
            AppId = appId;
            ClusterGroupSetItems = clusterGroupSetItems;
            CreateTime = createTime;
            CreatorUin = creatorUin;
            Description = description;
            JobsCount = jobsCount;
            OwnerUin = ownerUin;
            Region = region;
            RoleAuthCount = roleAuthCount;
            RoleAuths = roleAuths;
            SerialId = serialId;
            Status = status;
            UpdateTime = updateTime;
            WorkSpaceId = workSpaceId;
            WorkSpaceName = workSpaceName;
        }
    }
}