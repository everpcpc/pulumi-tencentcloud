// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Sqlserver.Outputs
{

    [OutputType]
    public sealed class GetZoneConfigZoneListSpecinfoListResult
    {
        /// <summary>
        /// Billing mode under this specification. Valid values are `POSTPAID_BY_HOUR`, `PREPAID` and `ALL`. `ALL` means both POSTPAID_BY_HOUR and PREPAID.
        /// </summary>
        public readonly string ChargeType;
        /// <summary>
        /// Number of CPU cores.
        /// </summary>
        public readonly int Cpu;
        /// <summary>
        /// Database version information. Valid values: `2008R2 (SQL Server 2008 Enterprise)`, `2012SP3 (SQL Server 2012 Enterprise)`, `2016SP1 (SQL Server 2016 Enterprise)`, `201602 (SQL Server 2016 Standard)`, `2017 (SQL Server 2017 Enterprise)`.
        /// </summary>
        public readonly string DbVersion;
        /// <summary>
        /// Version name corresponding to the `db_version` field.
        /// </summary>
        public readonly string DbVersionName;
        /// <summary>
        /// Model ID.
        /// </summary>
        public readonly string MachineType;
        /// <summary>
        /// Maximum disk size under this specification in GB.
        /// </summary>
        public readonly int MaxStorageSize;
        /// <summary>
        /// Memory size in GB.
        /// </summary>
        public readonly int Memory;
        /// <summary>
        /// Minimum disk size under this specification in GB.
        /// </summary>
        public readonly int MinStorageSize;
        /// <summary>
        /// QPS of this specification.
        /// </summary>
        public readonly int Qps;
        /// <summary>
        /// Instance specification ID.
        /// </summary>
        public readonly int SpecId;

        [OutputConstructor]
        private GetZoneConfigZoneListSpecinfoListResult(
            string chargeType,

            int cpu,

            string dbVersion,

            string dbVersionName,

            string machineType,

            int maxStorageSize,

            int memory,

            int minStorageSize,

            int qps,

            int specId)
        {
            ChargeType = chargeType;
            Cpu = cpu;
            DbVersion = dbVersion;
            DbVersionName = dbVersionName;
            MachineType = machineType;
            MaxStorageSize = maxStorageSize;
            Memory = memory;
            MinStorageSize = minStorageSize;
            Qps = qps;
            SpecId = specId;
        }
    }
}