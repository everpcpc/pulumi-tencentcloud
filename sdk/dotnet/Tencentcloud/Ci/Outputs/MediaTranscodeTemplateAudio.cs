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
    public sealed class MediaTranscodeTemplateAudio
    {
        /// <summary>
        /// Original audio bit rate, unit: Kbps, Value range: [8, 1000].
        /// </summary>
        public readonly string? Bitrate;
        /// <summary>
        /// number of channels- When Codec is set to aac/flac, support 1, 2, 4, 5, 6, 8- When Codec is set to mp3/opus, support 1, 2- When Codec is set to Vorbis, only 2 is supported- When Codec is set to amr, only 1 is supported- When Codec is set to pcm_s16le, only 1 and 2 are supported- When the encapsulation format is dash, 8 is not supported.
        /// </summary>
        public readonly string? Channels;
        /// <summary>
        /// Codec format, value aac, mp3, flac, amr, Vorbis, opus, pcm_s16le.
        /// </summary>
        public readonly string? Codec;
        /// <summary>
        /// Keep dual audio tracks, the value is true, false. This parameter is invalid when Video.Codec is H.265.
        /// </summary>
        public readonly string? KeepTwoTracks;
        /// <summary>
        /// Whether to delete the source audio stream, the value is true, false.
        /// </summary>
        public readonly string? Remove;
        /// <summary>
        /// Sampling bit width- When Codec is set to aac, support fltp- When Codec is set to mp3, fltp, s16p, s32p are supported- When Codec is set to flac, s16, s32, s16p, s32p are supported- When Codec is set to amr, support s16, s16p- When Codec is set to opus, support s16- When Codec is set to pcm_s16le, support s16- When Codec is set to Vorbis, support fltp- This parameter is invalid when Video.Codec is H.265.
        /// </summary>
        public readonly string? SampleFormat;
        /// <summary>
        /// Sampling Rate- Unit: Hz- Optional 8000, 11025, 12000, 16000, 22050, 24000, 32000, 44100, 48000, 88200, 96000- Different packages, mp3 supports different sampling rates, as shown in the table below- When Codec is set to amr, only 8000 is supported- When Codec is set to opus, it supports 8000, 16000, 24000, 48000.
        /// </summary>
        public readonly string? Samplerate;
        /// <summary>
        /// Convert track, the value is true, false. This parameter is invalid when Video.Codec is H.265.
        /// </summary>
        public readonly string? SwitchTrack;

        [OutputConstructor]
        private MediaTranscodeTemplateAudio(
            string? bitrate,

            string? channels,

            string? codec,

            string? keepTwoTracks,

            string? remove,

            string? sampleFormat,

            string? samplerate,

            string? switchTrack)
        {
            Bitrate = bitrate;
            Channels = channels;
            Codec = codec;
            KeepTwoTracks = keepTwoTracks;
            Remove = remove;
            SampleFormat = sampleFormat;
            Samplerate = samplerate;
            SwitchTrack = switchTrack;
        }
    }
}