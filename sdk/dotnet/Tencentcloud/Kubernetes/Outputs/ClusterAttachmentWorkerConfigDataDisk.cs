// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Kubernetes.Outputs
{

    [OutputType]
    public sealed class ClusterAttachmentWorkerConfigDataDisk
    {
        /// <summary>
        /// Indicate whether to auto format and mount or not. Default is `false`.
        /// </summary>
        public readonly bool? AutoFormatAndMount;
        /// <summary>
        /// The name of the device or partition to mount. NOTE: this argument doesn't support setting in node pool, or will leads to mount error.
        /// </summary>
        public readonly string? DiskPartition;
        /// <summary>
        /// Volume of disk in GB. Default is `0`.
        /// </summary>
        public readonly int? DiskSize;
        /// <summary>
        /// Types of disk, available values: `CLOUD_PREMIUM` and `CLOUD_SSD`.
        /// </summary>
        public readonly string? DiskType;
        /// <summary>
        /// File system, e.g. `ext3/ext4/xfs`.
        /// </summary>
        public readonly string? FileSystem;
        /// <summary>
        /// Mount target.
        /// </summary>
        public readonly string? MountTarget;

        [OutputConstructor]
        private ClusterAttachmentWorkerConfigDataDisk(
            bool? autoFormatAndMount,

            string? diskPartition,

            int? diskSize,

            string? diskType,

            string? fileSystem,

            string? mountTarget)
        {
            AutoFormatAndMount = autoFormatAndMount;
            DiskPartition = diskPartition;
            DiskSize = diskSize;
            DiskType = diskType;
            FileSystem = fileSystem;
            MountTarget = mountTarget;
        }
    }
}