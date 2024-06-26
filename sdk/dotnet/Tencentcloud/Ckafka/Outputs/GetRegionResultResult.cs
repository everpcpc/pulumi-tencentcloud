// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ckafka.Outputs
{

    [OutputType]
    public sealed class GetRegionResultResult
    {
        /// <summary>
        /// area name.
        /// </summary>
        public readonly string AreaName;
        /// <summary>
        /// Whether to support ipv6, 0: means not supported, 1: means supported.
        /// </summary>
        public readonly int Ipv6;
        /// <summary>
        /// Whether to support cross-availability zones, 0: means not supported, 1: means supported.
        /// </summary>
        public readonly int MultiZone;
        /// <summary>
        /// Region Code.
        /// </summary>
        public readonly string RegionCode;
        /// <summary>
        /// Region Code(V3 version).
        /// </summary>
        public readonly string RegionCodeV3;
        /// <summary>
        /// region ID.
        /// </summary>
        public readonly int RegionId;
        /// <summary>
        /// geographical name.
        /// </summary>
        public readonly string RegionName;
        /// <summary>
        /// NONE: The default value does not support any special models CVM: Supports CVM types.
        /// </summary>
        public readonly string Support;

        [OutputConstructor]
        private GetRegionResultResult(
            string areaName,

            int ipv6,

            int multiZone,

            string regionCode,

            string regionCodeV3,

            int regionId,

            string regionName,

            string support)
        {
            AreaName = areaName;
            Ipv6 = ipv6;
            MultiZone = multiZone;
            RegionCode = regionCode;
            RegionCodeV3 = regionCodeV3;
            RegionId = regionId;
            RegionName = regionName;
            Support = support;
        }
    }
}
