// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tcr.Inputs
{

    public sealed class InstanceSecurityPolicyGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The public network IP address of the access source.
        /// </summary>
        [Input("cidrBlock")]
        public Input<string>? CidrBlock { get; set; }

        /// <summary>
        /// Remarks of policy.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Index of policy.
        /// </summary>
        [Input("index")]
        public Input<int>? Index { get; set; }

        /// <summary>
        /// Version of policy.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public InstanceSecurityPolicyGetArgs()
        {
        }
        public static new InstanceSecurityPolicyGetArgs Empty => new InstanceSecurityPolicyGetArgs();
    }
}
