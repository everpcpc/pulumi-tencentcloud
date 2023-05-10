// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ci.Outputs
{

    [OutputType]
    public sealed class MediaVideoMontageTemplateAudio
    {
        /// <summary>
        /// Original audio bit rate, unit: Kbps, Value range: [8, 1000].
        /// </summary>
        public readonly string? Bitrate;
        /// <summary>
        /// number of channels- When Codec is set to aac, support 1, 2, 4, 5, 6, 8- When Codec is set to mp3, support 1, 2.
        /// </summary>
        public readonly string? Channels;
        /// <summary>
        /// Codec format, value aac, mp3.
        /// </summary>
        public readonly string Codec;
        /// <summary>
        /// Whether to delete the source audio stream, the value is true, false.
        /// </summary>
        public readonly string? Remove;
        /// <summary>
        /// Sampling Rate- Unit: Hz- Optional 11025, 22050, 32000, 44100, 48000, 96000- Different packages, mp3 supports different sampling rates, as shown in the table below.
        /// </summary>
        public readonly string? Samplerate;

        [OutputConstructor]
        private MediaVideoMontageTemplateAudio(
            string? bitrate,

            string? channels,

            string codec,

            string? remove,

            string? samplerate)
        {
            Bitrate = bitrate;
            Channels = channels;
            Codec = codec;
            Remove = remove;
            Samplerate = samplerate;
        }
    }
}