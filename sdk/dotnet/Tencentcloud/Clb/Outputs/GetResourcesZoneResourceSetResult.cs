// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Clb.Outputs
{

    [OutputType]
    public sealed class GetResourcesZoneResourceSetResult
    {
        /// <summary>
        /// Whether the AZ is an edge zone. Values: true, false.
        /// </summary>
        public readonly bool EdgeZone;
        /// <summary>
        /// IP version. Values: IPv4, IPv6, and IPv6_Nat.
        /// </summary>
        public readonly string IpVersion;
        /// <summary>
        /// Whether the AZ is a LocalZone. Values: true, false.
        /// </summary>
        public readonly bool LocalZone;
        /// <summary>
        /// Primary AZ, such as ap-guangzhou-1.
        /// </summary>
        public readonly string MasterZone;
        /// <summary>
        /// List of resources. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetResourcesZoneResourceSetResourceSetResult> ResourceSets;
        /// <summary>
        /// Secondary AZ, such as ap-guangzhou-2. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string SlaveZone;
        /// <summary>
        /// Region of the AZ, such as ap-guangzhou.
        /// </summary>
        public readonly string ZoneRegion;
        /// <summary>
        /// Type of resources in the zone. Values: SHARED, EXCLUSIVE.
        /// </summary>
        public readonly string ZoneResourceType;

        [OutputConstructor]
        private GetResourcesZoneResourceSetResult(
            bool edgeZone,

            string ipVersion,

            bool localZone,

            string masterZone,

            ImmutableArray<Outputs.GetResourcesZoneResourceSetResourceSetResult> resourceSets,

            string slaveZone,

            string zoneRegion,

            string zoneResourceType)
        {
            EdgeZone = edgeZone;
            IpVersion = ipVersion;
            LocalZone = localZone;
            MasterZone = masterZone;
            ResourceSets = resourceSets;
            SlaveZone = slaveZone;
            ZoneRegion = zoneRegion;
            ZoneResourceType = zoneResourceType;
        }
    }
}
