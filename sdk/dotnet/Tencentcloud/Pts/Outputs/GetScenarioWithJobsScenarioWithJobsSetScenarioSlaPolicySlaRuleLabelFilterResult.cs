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
    public sealed class GetScenarioWithJobsScenarioWithJobsSetScenarioSlaPolicySlaRuleLabelFilterResult
    {
        /// <summary>
        /// Label name.
        /// </summary>
        public readonly string LabelName;
        /// <summary>
        /// Label value.
        /// </summary>
        public readonly string LabelValue;

        [OutputConstructor]
        private GetScenarioWithJobsScenarioWithJobsSetScenarioSlaPolicySlaRuleLabelFilterResult(
            string labelName,

            string labelValue)
        {
            LabelName = labelName;
            LabelValue = labelValue;
        }
    }
}