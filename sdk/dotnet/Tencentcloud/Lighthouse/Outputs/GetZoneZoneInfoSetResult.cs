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
    public sealed class GetZoneZoneInfoSetResult
    {
        /// <summary>
        /// Instance purchase page availability zone display label.
        /// </summary>
        public readonly string InstanceDisplayLabel;
        /// <summary>
        /// Availability zone.
        /// </summary>
        public readonly string Zone;
        /// <summary>
        /// Chinese name of availability zone.
        /// </summary>
        public readonly string ZoneName;

        [OutputConstructor]
        private GetZoneZoneInfoSetResult(
            string instanceDisplayLabel,

            string zone,

            string zoneName)
        {
            InstanceDisplayLabel = instanceDisplayLabel;
            Zone = zone;
            ZoneName = zoneName;
        }
    }
}