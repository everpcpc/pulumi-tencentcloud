// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.As.Inputs
{

    public sealed class LoadBalancerForwardLoadBalancerTargetAttributeArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Target port.
        /// </summary>
        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        /// <summary>
        /// Target weight.
        /// </summary>
        [Input("weight", required: true)]
        public Input<int> Weight { get; set; } = null!;

        public LoadBalancerForwardLoadBalancerTargetAttributeArgs()
        {
        }
        public static new LoadBalancerForwardLoadBalancerTargetAttributeArgs Empty => new LoadBalancerForwardLoadBalancerTargetAttributeArgs();
    }
}