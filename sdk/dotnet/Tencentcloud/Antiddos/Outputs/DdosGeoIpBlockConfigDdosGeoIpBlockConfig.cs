// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Antiddos.Outputs
{

    [OutputType]
    public sealed class DdosGeoIpBlockConfigDdosGeoIpBlockConfig
    {
        /// <summary>
        /// Blocking action, value [drop (intercept) trans (release)].
        /// </summary>
        public readonly string Action;
        /// <summary>
        /// When RegionType is customized, an AreaList must be filled in, with a maximum of 128 entries;.
        /// </summary>
        public readonly ImmutableArray<int> AreaLists;
        /// <summary>
        /// Region type, value [oversea (overseas) China (domestic) customized (custom region)].
        /// </summary>
        public readonly string RegionType;

        [OutputConstructor]
        private DdosGeoIpBlockConfigDdosGeoIpBlockConfig(
            string action,

            ImmutableArray<int> areaLists,

            string regionType)
        {
            Action = action;
            AreaLists = areaLists;
            RegionType = regionType;
        }
    }
}
