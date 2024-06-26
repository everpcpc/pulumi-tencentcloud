// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mysql.Outputs
{

    [OutputType]
    public sealed class GetZoneConfigListSellResult
    {
        /// <summary>
        /// Instance type, the possible value ranges are: `UNIVERSAL` (universal type), `EXCLUSIVE` (exclusive type), `BASIC` (basic type), `BASIC_V2` (basic type v2).
        /// </summary>
        public readonly string CdbType;
        /// <summary>
        /// Number of CPU cores.
        /// </summary>
        public readonly int Cpu;
        /// <summary>
        /// Application Scenario Description.
        /// </summary>
        public readonly string Info;
        /// <summary>
        /// Maximum disk size (in GB).
        /// </summary>
        public readonly int MaxVolumeSize;
        /// <summary>
        /// Memory size (in MB).
        /// </summary>
        public readonly int MemSize;
        /// <summary>
        /// Minimum disk size (in GB).
        /// </summary>
        public readonly int MinVolumeSize;
        /// <summary>
        /// Queries per second.
        /// </summary>
        public readonly int Qps;
        /// <summary>
        /// Disk increment (in GB).
        /// </summary>
        public readonly int VolumeStep;

        [OutputConstructor]
        private GetZoneConfigListSellResult(
            string cdbType,

            int cpu,

            string info,

            int maxVolumeSize,

            int memSize,

            int minVolumeSize,

            int qps,

            int volumeStep)
        {
            CdbType = cdbType;
            Cpu = cpu;
            Info = info;
            MaxVolumeSize = maxVolumeSize;
            MemSize = memSize;
            MinVolumeSize = minVolumeSize;
            Qps = qps;
            VolumeStep = volumeStep;
        }
    }
}
