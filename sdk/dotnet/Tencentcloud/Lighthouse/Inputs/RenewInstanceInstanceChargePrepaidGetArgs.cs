// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Lighthouse.Inputs
{

    public sealed class RenewInstanceInstanceChargePrepaidGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The duration of purchasing an instance. Unit is month. Valid values are (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 24, 36, 48, 60).
        /// </summary>
        [Input("period", required: true)]
        public Input<int> Period { get; set; } = null!;

        /// <summary>
        /// Automatic renewal logo. Values:
        /// </summary>
        [Input("renewFlag")]
        public Input<string>? RenewFlag { get; set; }

        public RenewInstanceInstanceChargePrepaidGetArgs()
        {
        }
        public static new RenewInstanceInstanceChargePrepaidGetArgs Empty => new RenewInstanceInstanceChargePrepaidGetArgs();
    }
}