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
    public sealed class GetZoneResultZoneListResult
    {
        /// <summary>
        /// app id.
        /// </summary>
        public readonly int AppId;
        /// <summary>
        /// extra flag.
        /// </summary>
        public readonly string Exflag;
        /// <summary>
        /// Manually set flags.
        /// </summary>
        public readonly bool Flag;
        /// <summary>
        /// internal APP.
        /// </summary>
        public readonly int IsInternalApp;
        /// <summary>
        /// Standard Edition Sold Out Information.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetZoneResultZoneListSalesInfoResult> SalesInfos;
        /// <summary>
        /// json object, key is model, value true is sold out, false is not sold out.
        /// </summary>
        public readonly string SoldOut;
        /// <summary>
        /// zone id.
        /// </summary>
        public readonly string ZoneId;
        /// <summary>
        /// zone name.
        /// </summary>
        public readonly string ZoneName;
        /// <summary>
        /// zone status.
        /// </summary>
        public readonly int ZoneStatus;

        [OutputConstructor]
        private GetZoneResultZoneListResult(
            int appId,

            string exflag,

            bool flag,

            int isInternalApp,

            ImmutableArray<Outputs.GetZoneResultZoneListSalesInfoResult> salesInfos,

            string soldOut,

            string zoneId,

            string zoneName,

            int zoneStatus)
        {
            AppId = appId;
            Exflag = exflag;
            Flag = flag;
            IsInternalApp = isInternalApp;
            SalesInfos = salesInfos;
            SoldOut = soldOut;
            ZoneId = zoneId;
            ZoneName = zoneName;
            ZoneStatus = zoneStatus;
        }
    }
}