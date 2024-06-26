// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mps.Outputs
{

    [OutputType]
    public sealed class FlowInputGroupRtmpPullSettings
    {
        /// <summary>
        /// The source site address of the RTMP source site, there can only be one.
        /// </summary>
        public readonly ImmutableArray<Outputs.FlowInputGroupRtmpPullSettingsSourceAddress> SourceAddresses;

        [OutputConstructor]
        private FlowInputGroupRtmpPullSettings(ImmutableArray<Outputs.FlowInputGroupRtmpPullSettingsSourceAddress> sourceAddresses)
        {
            SourceAddresses = sourceAddresses;
        }
    }
}
