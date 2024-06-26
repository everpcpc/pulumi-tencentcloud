// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ssl.Outputs
{

    [OutputType]
    public sealed class GetDescribeHostUpdateRecordDeployRecordListResult
    {
        /// <summary>
        /// New certificate ID.
        /// </summary>
        public readonly string CertId;
        /// <summary>
        /// Deployment time.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// Record ID.
        /// </summary>
        public readonly int Id;
        /// <summary>
        /// Original certificate ID.
        /// </summary>
        public readonly string OldCertId;
        /// <summary>
        /// List of regional deploymentNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly ImmutableArray<string> Regions;
        /// <summary>
        /// List of resource types.
        /// </summary>
        public readonly ImmutableArray<string> ResourceTypes;
        /// <summary>
        /// Deployment state.
        /// </summary>
        public readonly int Status;
        /// <summary>
        /// Last update time.
        /// </summary>
        public readonly string UpdateTime;

        [OutputConstructor]
        private GetDescribeHostUpdateRecordDeployRecordListResult(
            string certId,

            string createTime,

            int id,

            string oldCertId,

            ImmutableArray<string> regions,

            ImmutableArray<string> resourceTypes,

            int status,

            string updateTime)
        {
            CertId = certId;
            CreateTime = createTime;
            Id = id;
            OldCertId = oldCertId;
            Regions = regions;
            ResourceTypes = resourceTypes;
            Status = status;
            UpdateTime = updateTime;
        }
    }
}
