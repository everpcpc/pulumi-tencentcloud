// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tdmq.Outputs
{

    [OutputType]
    public sealed class RocketmqVipInstanceIpRule
    {
        /// <summary>
        /// Whether to allow or deny.
        /// </summary>
        public readonly bool Allow;
        /// <summary>
        /// IP address block information.
        /// </summary>
        public readonly string IpRule;
        /// <summary>
        /// Remark.
        /// </summary>
        public readonly string Remark;

        [OutputConstructor]
        private RocketmqVipInstanceIpRule(
            bool allow,

            string ipRule,

            string remark)
        {
            Allow = allow;
            IpRule = ipRule;
            Remark = remark;
        }
    }
}