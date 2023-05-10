// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Teo.Inputs
{

    public sealed class DdosPolicyDdosRuleAllowBlockArgs : Pulumi.ResourceArgs
    {
        [Input("allowBlockIps")]
        private InputList<Inputs.DdosPolicyDdosRuleAllowBlockAllowBlockIpArgs>? _allowBlockIps;

        /// <summary>
        /// DDoS black-white list detail.
        /// </summary>
        public InputList<Inputs.DdosPolicyDdosRuleAllowBlockAllowBlockIpArgs> AllowBlockIps
        {
            get => _allowBlockIps ?? (_allowBlockIps = new InputList<Inputs.DdosPolicyDdosRuleAllowBlockAllowBlockIpArgs>());
            set => _allowBlockIps = value;
        }

        /// <summary>
        /// - `on`: Enable. `AllowBlockIps` parameter is required.- `off`: Disable.
        /// </summary>
        [Input("switch")]
        public Input<string>? Switch { get; set; }

        public DdosPolicyDdosRuleAllowBlockArgs()
        {
        }
    }
}