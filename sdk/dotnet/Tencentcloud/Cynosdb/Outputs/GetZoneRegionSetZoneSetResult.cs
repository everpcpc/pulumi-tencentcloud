// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cynosdb.Outputs
{

    [OutputType]
    public sealed class GetZoneRegionSetZoneSetResult
    {
        /// <summary>
        /// Whether the user have zone permissionsNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly bool HasPermission;
        /// <summary>
        /// Does it support normal clusters, 0:Not supported 1:Support.
        /// </summary>
        public readonly int IsSupportNormal;
        /// <summary>
        /// Does it support serverless clusters, 0:Not supported 1:Support.
        /// </summary>
        public readonly int IsSupportServerless;
        /// <summary>
        /// Is zone Rdma.
        /// </summary>
        public readonly string IsWholeRdmaZone;
        /// <summary>
        /// Physical zone.
        /// </summary>
        public readonly string PhysicalZone;
        /// <summary>
        /// Zone name in English.
        /// </summary>
        public readonly string Zone;
        /// <summary>
        /// ZoneId.
        /// </summary>
        public readonly int ZoneId;
        /// <summary>
        /// Zone name in Chinesee.
        /// </summary>
        public readonly string ZoneZh;

        [OutputConstructor]
        private GetZoneRegionSetZoneSetResult(
            bool hasPermission,

            int isSupportNormal,

            int isSupportServerless,

            string isWholeRdmaZone,

            string physicalZone,

            string zone,

            int zoneId,

            string zoneZh)
        {
            HasPermission = hasPermission;
            IsSupportNormal = isSupportNormal;
            IsSupportServerless = isSupportServerless;
            IsWholeRdmaZone = isWholeRdmaZone;
            PhysicalZone = physicalZone;
            Zone = zone;
            ZoneId = zoneId;
            ZoneZh = zoneZh;
        }
    }
}
