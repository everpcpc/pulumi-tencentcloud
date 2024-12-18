// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Css.Outputs
{

    [OutputType]
    public sealed class RecordTemplateHlsSpecialParam
    {
        /// <summary>
        /// HLS freewheeling timeout. Value range [0, 1800].
        /// </summary>
        public readonly int? FlowContinueDuration;

        [OutputConstructor]
        private RecordTemplateHlsSpecialParam(int? flowContinueDuration)
        {
            FlowContinueDuration = flowContinueDuration;
        }
    }
}
