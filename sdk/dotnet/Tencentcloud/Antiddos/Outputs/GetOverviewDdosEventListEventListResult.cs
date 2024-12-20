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
    public sealed class GetOverviewDdosEventListEventListResult
    {
        /// <summary>
        /// filter event by attack status, start: attacking; end: attack end.
        /// </summary>
        public readonly int AttackStatus;
        /// <summary>
        /// AttackType.
        /// </summary>
        public readonly string AttackType;
        /// <summary>
        /// Dayu sub product code (bgpip represents advanced defense IP; net represents professional version of advanced defense IP).
        /// </summary>
        public readonly string Business;
        /// <summary>
        /// EndTime.
        /// </summary>
        public readonly string EndTime;
        /// <summary>
        /// event id.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// InstanceId.
        /// </summary>
        public readonly string InstanceId;
        /// <summary>
        /// InstanceId.
        /// </summary>
        public readonly string InstanceName;
        /// <summary>
        /// Attack traffic, unit Mbps.
        /// </summary>
        public readonly int Mbps;
        /// <summary>
        /// unit Mbps.
        /// </summary>
        public readonly int Pps;
        /// <summary>
        /// StartTime.
        /// </summary>
        public readonly string StartTime;
        /// <summary>
        /// ip.
        /// </summary>
        public readonly string Vip;

        [OutputConstructor]
        private GetOverviewDdosEventListEventListResult(
            int attackStatus,

            string attackType,

            string business,

            string endTime,

            string id,

            string instanceId,

            string instanceName,

            int mbps,

            int pps,

            string startTime,

            string vip)
        {
            AttackStatus = attackStatus;
            AttackType = attackType;
            Business = business;
            EndTime = endTime;
            Id = id;
            InstanceId = instanceId;
            InstanceName = instanceName;
            Mbps = mbps;
            Pps = pps;
            StartTime = startTime;
            Vip = vip;
        }
    }
}
