// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Gaap.Outputs
{

    [OutputType]
    public sealed class GetRuleRealServersBindRealServerSetResult
    {
        /// <summary>
        /// When the real server is a domain name, the domain name is resolved to one or more IPs, and this field represents the list of abnormal IPs. When the status is abnormal, but the field is empty, it indicates that the domain name resolution is abnormal.
        /// </summary>
        public readonly ImmutableArray<string> DownIpLists;
        /// <summary>
        /// The primary and secondary roles of the real server:master represents primary, slave represents secondary, and this parameter must be in the active and standby mode of the real server when the listener is turned on.
        /// </summary>
        public readonly string RealServerFailoverRole;
        /// <summary>
        /// Real Server Id.
        /// </summary>
        public readonly string RealServerId;
        /// <summary>
        /// Real Server IP or domain.
        /// </summary>
        public readonly string RealServerIp;
        /// <summary>
        /// Real Server PortNote: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly int RealServerPort;
        /// <summary>
        /// RealServerStatus: 0 indicates normal;1 indicates an exception.When the health check status is not enabled, it is always normal.Note: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly int RealServerStatus;
        /// <summary>
        /// Real Server Weight.
        /// </summary>
        public readonly int RealServerWeight;

        [OutputConstructor]
        private GetRuleRealServersBindRealServerSetResult(
            ImmutableArray<string> downIpLists,

            string realServerFailoverRole,

            string realServerId,

            string realServerIp,

            int realServerPort,

            int realServerStatus,

            int realServerWeight)
        {
            DownIpLists = downIpLists;
            RealServerFailoverRole = realServerFailoverRole;
            RealServerId = realServerId;
            RealServerIp = realServerIp;
            RealServerPort = realServerPort;
            RealServerStatus = realServerStatus;
            RealServerWeight = realServerWeight;
        }
    }
}
