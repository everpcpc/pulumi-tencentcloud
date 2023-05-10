// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dnspod.Outputs
{

    [OutputType]
    public sealed class GetRecordsResultResult
    {
        /// <summary>
        /// The record split zone.
        /// </summary>
        public readonly string Line;
        /// <summary>
        /// The split zone ID.
        /// </summary>
        public readonly string LineId;
        /// <summary>
        /// The monitoring status of the record. Valid values: OK (normal), WARN (warning), and DOWN (downtime). It is empty if no monitoring is set or the monitoring is suspended.
        /// </summary>
        public readonly string MonitorStatus;
        /// <summary>
        /// The MX value, applicable to the MX record only.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly int Mx;
        /// <summary>
        /// The host name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Record ID.
        /// </summary>
        public readonly int RecordId;
        /// <summary>
        /// The record remarks.
        /// </summary>
        public readonly string Remark;
        /// <summary>
        /// The record status. Valid values: ENABLE (enabled), DISABLE (disabled).
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// The record cache time.
        /// </summary>
        public readonly int Ttl;
        /// <summary>
        /// The record type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The update time.
        /// </summary>
        public readonly string UpdatedOn;
        /// <summary>
        /// The record value.
        /// </summary>
        public readonly string Value;
        /// <summary>
        /// The record weight, which is required for round-robin DNS records.
        /// </summary>
        public readonly int Weight;

        [OutputConstructor]
        private GetRecordsResultResult(
            string line,

            string lineId,

            string monitorStatus,

            int mx,

            string name,

            int recordId,

            string remark,

            string status,

            int ttl,

            string type,

            string updatedOn,

            string value,

            int weight)
        {
            Line = line;
            LineId = lineId;
            MonitorStatus = monitorStatus;
            Mx = mx;
            Name = name;
            RecordId = recordId;
            Remark = remark;
            Status = status;
            Ttl = ttl;
            Type = type;
            UpdatedOn = updatedOn;
            Value = value;
            Weight = weight;
        }
    }
}