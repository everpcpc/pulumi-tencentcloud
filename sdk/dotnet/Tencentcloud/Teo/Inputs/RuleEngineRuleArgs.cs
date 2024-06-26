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

    public sealed class RuleEngineRuleArgs : Pulumi.ResourceArgs
    {
        [Input("actions", required: true)]
        private InputList<Inputs.RuleEngineRuleActionArgs>? _actions;

        /// <summary>
        /// Actions list of the rule. See details in data source `rule_engine_setting`.
        /// </summary>
        public InputList<Inputs.RuleEngineRuleActionArgs> Actions
        {
            get => _actions ?? (_actions = new InputList<Inputs.RuleEngineRuleActionArgs>());
            set => _actions = value;
        }

        [Input("ors", required: true)]
        private InputList<Inputs.RuleEngineRuleOrArgs>? _ors;

        /// <summary>
        /// OR Conditions list of the rule. Rule would be triggered if any of the condition is true.
        /// </summary>
        public InputList<Inputs.RuleEngineRuleOrArgs> Ors
        {
            get => _ors ?? (_ors = new InputList<Inputs.RuleEngineRuleOrArgs>());
            set => _ors = value;
        }

        [Input("subRules")]
        private InputList<Inputs.RuleEngineRuleSubRuleArgs>? _subRules;

        /// <summary>
        /// Actions list of the rule. See details in data source `rule_engine_setting`.
        /// </summary>
        public InputList<Inputs.RuleEngineRuleSubRuleArgs> SubRules
        {
            get => _subRules ?? (_subRules = new InputList<Inputs.RuleEngineRuleSubRuleArgs>());
            set => _subRules = value;
        }

        public RuleEngineRuleArgs()
        {
        }
    }
}
