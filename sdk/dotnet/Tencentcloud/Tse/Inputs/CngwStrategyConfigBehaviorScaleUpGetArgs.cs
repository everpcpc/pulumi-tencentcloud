// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tse.Inputs
{

    public sealed class CngwStrategyConfigBehaviorScaleUpGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("policies")]
        private InputList<Inputs.CngwStrategyConfigBehaviorScaleUpPolicyGetArgs>? _policies;

        /// <summary>
        /// policies of scale up
        /// Note: This field may return null, indicating that a valid value is not available.
        /// </summary>
        public InputList<Inputs.CngwStrategyConfigBehaviorScaleUpPolicyGetArgs> Policies
        {
            get => _policies ?? (_policies = new InputList<Inputs.CngwStrategyConfigBehaviorScaleUpPolicyGetArgs>());
            set => _policies = value;
        }

        /// <summary>
        /// type of policy, default value: max
        /// Note: This field may return null, indicating that a valid value is not available.
        /// </summary>
        [Input("selectPolicy")]
        public Input<string>? SelectPolicy { get; set; }

        /// <summary>
        /// stability window time, unit:second, default 0 when scale up
        /// Note: This field may return null, indicating that a valid value is not available.
        /// </summary>
        [Input("stabilizationWindowSeconds")]
        public Input<int>? StabilizationWindowSeconds { get; set; }

        public CngwStrategyConfigBehaviorScaleUpGetArgs()
        {
        }
        public static new CngwStrategyConfigBehaviorScaleUpGetArgs Empty => new CngwStrategyConfigBehaviorScaleUpGetArgs();
    }
}