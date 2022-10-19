// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dayu.Inputs
{

    public sealed class CcPolicyV2CcPrecisionPolicyGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Domain.
        /// </summary>
        [Input("domain", required: true)]
        public Input<string> Domain { get; set; } = null!;

        /// <summary>
        /// Ip address.
        /// </summary>
        [Input("ip", required: true)]
        public Input<string> Ip { get; set; } = null!;

        /// <summary>
        /// Policy mode (discard or captcha).
        /// </summary>
        [Input("policyAction", required: true)]
        public Input<string> PolicyAction { get; set; } = null!;

        [Input("policyId")]
        public Input<string>? PolicyId { get; set; }

        [Input("policys", required: true)]
        private InputList<Inputs.CcPolicyV2CcPrecisionPolicyPolicyGetArgs>? _policys;

        /// <summary>
        /// A list of policies.
        /// </summary>
        public InputList<Inputs.CcPolicyV2CcPrecisionPolicyPolicyGetArgs> Policys
        {
            get => _policys ?? (_policys = new InputList<Inputs.CcPolicyV2CcPrecisionPolicyPolicyGetArgs>());
            set => _policys = value;
        }

        /// <summary>
        /// Protocol.
        /// </summary>
        [Input("protocol", required: true)]
        public Input<string> Protocol { get; set; } = null!;

        public CcPolicyV2CcPrecisionPolicyGetArgs()
        {
        }
    }
}