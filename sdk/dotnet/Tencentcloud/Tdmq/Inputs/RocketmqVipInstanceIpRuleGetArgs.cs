// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tdmq.Inputs
{

    public sealed class RocketmqVipInstanceIpRuleGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to allow or deny.
        /// </summary>
        [Input("allow", required: true)]
        public Input<bool> Allow { get; set; } = null!;

        /// <summary>
        /// IP address block information.
        /// </summary>
        [Input("ipRule", required: true)]
        public Input<string> IpRule { get; set; } = null!;

        /// <summary>
        /// Remark.
        /// </summary>
        [Input("remark", required: true)]
        public Input<string> Remark { get; set; } = null!;

        public RocketmqVipInstanceIpRuleGetArgs()
        {
        }
        public static new RocketmqVipInstanceIpRuleGetArgs Empty => new RocketmqVipInstanceIpRuleGetArgs();
    }
}