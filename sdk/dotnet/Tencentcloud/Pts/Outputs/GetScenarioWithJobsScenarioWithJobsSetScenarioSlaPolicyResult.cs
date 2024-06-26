// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Pts.Outputs
{

    [OutputType]
    public sealed class GetScenarioWithJobsScenarioWithJobsSetScenarioSlaPolicyResult
    {
        /// <summary>
        /// The alert channel.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetScenarioWithJobsScenarioWithJobsSetScenarioSlaPolicyAlertChannelResult> AlertChannels;
        /// <summary>
        /// The SLA rules.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetScenarioWithJobsScenarioWithJobsSetScenarioSlaPolicySlaRuleResult> SlaRules;

        [OutputConstructor]
        private GetScenarioWithJobsScenarioWithJobsSetScenarioSlaPolicyResult(
            ImmutableArray<Outputs.GetScenarioWithJobsScenarioWithJobsSetScenarioSlaPolicyAlertChannelResult> alertChannels,

            ImmutableArray<Outputs.GetScenarioWithJobsScenarioWithJobsSetScenarioSlaPolicySlaRuleResult> slaRules)
        {
            AlertChannels = alertChannels;
            SlaRules = slaRules;
        }
    }
}
