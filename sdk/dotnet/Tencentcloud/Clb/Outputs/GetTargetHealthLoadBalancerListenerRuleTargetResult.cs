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
    public sealed class GetTargetHealthLoadBalancerListenerRuleTargetResult
    {
        /// <summary>
        /// Current health status. true: healthy; false: unhealthy.
        /// </summary>
        public readonly bool HealthStatus;
        /// <summary>
        /// Detailed information about the current health status. Alive: healthy; Dead: exceptional; Unknown: check not started/checking/unknown status.
        /// </summary>
        public readonly string HealthStatusDetail;
        /// <summary>
        /// Private IP of the target.
        /// </summary>
        public readonly string Ip;
        /// <summary>
        /// Port bound to the target.
        /// </summary>
        public readonly int Port;
        /// <summary>
        /// Instance ID of the target, such as ins-12345678.
        /// </summary>
        public readonly string TargetId;

        [OutputConstructor]
        private GetTargetHealthLoadBalancerListenerRuleTargetResult(
            bool healthStatus,

            string healthStatusDetail,

            string ip,

            int port,

            string targetId)
        {
            HealthStatus = healthStatus;
            HealthStatusDetail = healthStatusDetail;
            Ip = ip;
            Port = port;
            TargetId = targetId;
        }
    }
}