// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mysql.Outputs
{

    [OutputType]
    public sealed class GetProjectSecurityGroupGroupResult
    {
        /// <summary>
        /// Creation time, time format: yyyy-mm-dd hh:mm:sss.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// inbound rules.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProjectSecurityGroupGroupInboundResult> Inbounds;
        /// <summary>
        /// outbound rules.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProjectSecurityGroupGroupOutboundResult> Outbounds;
        /// <summary>
        /// project id.
        /// </summary>
        public readonly int ProjectId;
        /// <summary>
        /// Security group ID.
        /// </summary>
        public readonly string SecurityGroupId;
        /// <summary>
        /// Security group name.
        /// </summary>
        public readonly string SecurityGroupName;
        /// <summary>
        /// Security group remark.
        /// </summary>
        public readonly string SecurityGroupRemark;

        [OutputConstructor]
        private GetProjectSecurityGroupGroupResult(
            string createTime,

            ImmutableArray<Outputs.GetProjectSecurityGroupGroupInboundResult> inbounds,

            ImmutableArray<Outputs.GetProjectSecurityGroupGroupOutboundResult> outbounds,

            int projectId,

            string securityGroupId,

            string securityGroupName,

            string securityGroupRemark)
        {
            CreateTime = createTime;
            Inbounds = inbounds;
            Outbounds = outbounds;
            ProjectId = projectId;
            SecurityGroupId = securityGroupId;
            SecurityGroupName = securityGroupName;
            SecurityGroupRemark = securityGroupRemark;
        }
    }
}
