// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mps.Inputs
{

    public sealed class OutputOutputRtmpSettingsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// RTMP Chunk size, range is [4096, 40960].
        /// </summary>
        [Input("chunkSize")]
        public Input<int>? ChunkSize { get; set; }

        [Input("destinations", required: true)]
        private InputList<Inputs.OutputOutputRtmpSettingsDestinationGetArgs>? _destinations;

        /// <summary>
        /// The target address of the relay can be filled in 1~2.
        /// </summary>
        public InputList<Inputs.OutputOutputRtmpSettingsDestinationGetArgs> Destinations
        {
            get => _destinations ?? (_destinations = new InputList<Inputs.OutputOutputRtmpSettingsDestinationGetArgs>());
            set => _destinations = value;
        }

        public OutputOutputRtmpSettingsGetArgs()
        {
        }
        public static new OutputOutputRtmpSettingsGetArgs Empty => new OutputOutputRtmpSettingsGetArgs();
    }
}
