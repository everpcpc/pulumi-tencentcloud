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
    public sealed class OutputOutput
    {
        /// <summary>
        /// IP whitelist list, the format is CIDR, such as 0.0.0.0/0. When the Protocol is RTMP_PULL, it is valid, and if it is empty, it means that the client IP is not limited.
        /// </summary>
        public readonly ImmutableArray<string> AllowIpLists;
        /// <summary>
        /// Output description.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// The maximum number of concurrent pull streams, the maximum is 4, and the default is 4. Only SRT or RTMP_PULL can set this parameter.
        /// </summary>
        public readonly int? MaxConcurrent;
        /// <summary>
        /// The name of the output.
        /// </summary>
        public readonly string OutputName;
        /// <summary>
        /// Output region.
        /// </summary>
        public readonly string OutputRegion;
        /// <summary>
        /// Output protocol, optional [SRT|RTP|RTMP|RTMP_PULL].
        /// </summary>
        public readonly string Protocol;
        /// <summary>
        /// Output RTMP configuration.
        /// </summary>
        public readonly Outputs.OutputOutputRtmpSettings? RtmpSettings;
        /// <summary>
        /// Output RTP configuration.
        /// </summary>
        public readonly Outputs.OutputOutputRtpSettings? RtpSettings;
        /// <summary>
        /// configuration of the output SRT.
        /// </summary>
        public readonly Outputs.OutputOutputSrtSettings? SrtSettings;

        [OutputConstructor]
        private OutputOutput(
            ImmutableArray<string> allowIpLists,

            string description,

            int? maxConcurrent,

            string outputName,

            string outputRegion,

            string protocol,

            Outputs.OutputOutputRtmpSettings? rtmpSettings,

            Outputs.OutputOutputRtpSettings? rtpSettings,

            Outputs.OutputOutputSrtSettings? srtSettings)
        {
            AllowIpLists = allowIpLists;
            Description = description;
            MaxConcurrent = maxConcurrent;
            OutputName = outputName;
            OutputRegion = outputRegion;
            Protocol = protocol;
            RtmpSettings = rtmpSettings;
            RtpSettings = rtpSettings;
            SrtSettings = srtSettings;
        }
    }
}
