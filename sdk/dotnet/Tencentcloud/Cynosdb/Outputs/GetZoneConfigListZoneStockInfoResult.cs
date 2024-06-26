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
    public sealed class GetZoneConfigListZoneStockInfoResult
    {
        /// <summary>
        /// Has stock.
        /// </summary>
        public readonly bool HasStock;
        /// <summary>
        /// Availability zone.
        /// </summary>
        public readonly string Zone;

        [OutputConstructor]
        private GetZoneConfigListZoneStockInfoResult(
            bool hasStock,

            string zone)
        {
            HasStock = hasStock;
            Zone = zone;
        }
    }
}
