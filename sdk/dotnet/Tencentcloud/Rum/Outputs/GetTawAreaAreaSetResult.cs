// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Rum.Outputs
{

    [OutputType]
    public sealed class GetTawAreaAreaSetResult
    {
        /// <summary>
        /// Region abbreviation.
        /// </summary>
        public readonly string AreaAbbr;
        /// <summary>
        /// Area id.
        /// </summary>
        public readonly int AreaId;
        /// <summary>
        /// Area key.
        /// </summary>
        public readonly string AreaKey;
        /// <summary>
        /// Area name.
        /// </summary>
        public readonly string AreaName;
        /// <summary>
        /// Area code.
        /// </summary>
        public readonly string AreaRegionCode;
        /// <summary>
        /// Area code id.
        /// </summary>
        public readonly string AreaRegionId;
        /// <summary>
        /// Area status `1`:&amp;amp;#39;valid&amp;amp;#39;; `2`:&amp;amp;#39;invalid&amp;amp;#39;.
        /// </summary>
        public readonly int AreaStatus;

        [OutputConstructor]
        private GetTawAreaAreaSetResult(
            string areaAbbr,

            int areaId,

            string areaKey,

            string areaName,

            string areaRegionCode,

            string areaRegionId,

            int areaStatus)
        {
            AreaAbbr = areaAbbr;
            AreaId = areaId;
            AreaKey = areaKey;
            AreaName = areaName;
            AreaRegionCode = areaRegionCode;
            AreaRegionId = areaRegionId;
            AreaStatus = areaStatus;
        }
    }
}