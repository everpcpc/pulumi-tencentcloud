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

    public sealed class SecurityPolicyConfigIpTableConfigGetArgs : Pulumi.ResourceArgs
    {
        [Input("rules")]
        private InputList<Inputs.SecurityPolicyConfigIpTableConfigRuleGetArgs>? _rules;

        /// <summary>
        /// Rules list.
        /// </summary>
        public InputList<Inputs.SecurityPolicyConfigIpTableConfigRuleGetArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.SecurityPolicyConfigIpTableConfigRuleGetArgs>());
            set => _rules = value;
        }

        /// <summary>
        /// - `on`: Enable.- `off`: Disable.
        /// </summary>
        [Input("switch")]
        public Input<string>? Switch { get; set; }

        public SecurityPolicyConfigIpTableConfigGetArgs()
        {
        }
    }
}