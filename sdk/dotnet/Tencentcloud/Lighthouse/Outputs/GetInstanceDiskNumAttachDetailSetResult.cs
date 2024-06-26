// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Lighthouse.Outputs
{

    [OutputType]
    public sealed class GetInstanceDiskNumAttachDetailSetResult
    {
        /// <summary>
        /// Number of elastic cloud disks mounted to the instance.
        /// </summary>
        public readonly int AttachedDiskCount;
        /// <summary>
        /// Instance Id.
        /// </summary>
        public readonly string InstanceId;
        /// <summary>
        /// Number of elastic cloud disks that can be mounted.
        /// </summary>
        public readonly int MaxAttachCount;

        [OutputConstructor]
        private GetInstanceDiskNumAttachDetailSetResult(
            int attachedDiskCount,

            string instanceId,

            int maxAttachCount)
        {
            AttachedDiskCount = attachedDiskCount;
            InstanceId = instanceId;
            MaxAttachCount = maxAttachCount;
        }
    }
}
