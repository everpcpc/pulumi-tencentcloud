// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Teo.Outputs
{

    [OutputType]
    public sealed class RuleEngineRuleAction
    {
        /// <summary>
        /// Define a code action.
        /// </summary>
        public readonly Outputs.RuleEngineRuleActionCodeAction? CodeAction;
        /// <summary>
        /// Define a normal action.
        /// </summary>
        public readonly Outputs.RuleEngineRuleActionNormalAction? NormalAction;
        /// <summary>
        /// Define a rewrite action.
        /// </summary>
        public readonly Outputs.RuleEngineRuleActionRewriteAction? RewriteAction;

        [OutputConstructor]
        private RuleEngineRuleAction(
            Outputs.RuleEngineRuleActionCodeAction? codeAction,

            Outputs.RuleEngineRuleActionNormalAction? normalAction,

            Outputs.RuleEngineRuleActionRewriteAction? rewriteAction)
        {
            CodeAction = codeAction;
            NormalAction = normalAction;
            RewriteAction = rewriteAction;
        }
    }
}