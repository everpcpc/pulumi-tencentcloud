// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Wedata.Inputs
{

    public sealed class DqRuleCompareRuleItemValueListGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Threshold valueNote: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        /// <summary>
        /// Threshold type 1. Low threshold 2. High threshold 3. Common threshold 4. Enumerated valueNote: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        [Input("valueType")]
        public Input<int>? ValueType { get; set; }

        public DqRuleCompareRuleItemValueListGetArgs()
        {
        }
        public static new DqRuleCompareRuleItemValueListGetArgs Empty => new DqRuleCompareRuleItemValueListGetArgs();
    }
}