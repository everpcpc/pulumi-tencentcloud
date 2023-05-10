// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cfs.Outputs
{

    [OutputType]
    public sealed class GetMountTargetsMountTargetResult
    {
        /// <summary>
        /// CCN instance ID used by CFS Turbo.
        /// </summary>
        public readonly string CcnId;
        /// <summary>
        /// CCN IP range used by CFS Turbo.
        /// </summary>
        public readonly string CidrBlock;
        /// <summary>
        /// File system ID.
        /// </summary>
        public readonly string FileSystemId;
        /// <summary>
        /// Mount root-directory.
        /// </summary>
        public readonly string FsId;
        /// <summary>
        /// Mount target IP.
        /// </summary>
        public readonly string IpAddress;
        /// <summary>
        /// Mount target status.
        /// </summary>
        public readonly string LifeCycleState;
        /// <summary>
        /// Mount target ID.
        /// </summary>
        public readonly string MountTargetId;
        /// <summary>
        /// Network type.
        /// </summary>
        public readonly string NetworkInterface;
        /// <summary>
        /// Subnet ID.
        /// </summary>
        public readonly string SubnetId;
        /// <summary>
        /// Subnet name.
        /// </summary>
        public readonly string SubnetName;
        /// <summary>
        /// VPC ID.
        /// </summary>
        public readonly string VpcId;
        /// <summary>
        /// VPC name.
        /// </summary>
        public readonly string VpcName;

        [OutputConstructor]
        private GetMountTargetsMountTargetResult(
            string ccnId,

            string cidrBlock,

            string fileSystemId,

            string fsId,

            string ipAddress,

            string lifeCycleState,

            string mountTargetId,

            string networkInterface,

            string subnetId,

            string subnetName,

            string vpcId,

            string vpcName)
        {
            CcnId = ccnId;
            CidrBlock = cidrBlock;
            FileSystemId = fileSystemId;
            FsId = fsId;
            IpAddress = ipAddress;
            LifeCycleState = lifeCycleState;
            MountTargetId = mountTargetId;
            NetworkInterface = networkInterface;
            SubnetId = subnetId;
            SubnetName = subnetName;
            VpcId = vpcId;
            VpcName = vpcName;
        }
    }
}