// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Vod.Outputs
{

    [OutputType]
    public sealed class TranscodeTemplateAudioTemplate
    {
        /// <summary>
        /// Audio channel system. Valid values:1: mono-channel2: dual-channel6: stereoYou cannot set the sound channel as stereo for media files in container formats for audios (FLAC, OGG, MP3, M4A).Default value: 2.
        /// </summary>
        public readonly int? AudioChannel;
        /// <summary>
        /// Audio stream bitrate in Kbps. Value range: 0 and [26, 256].If the value is 0, the bitrate of the audio stream will be the same as that of the original audio.
        /// </summary>
        public readonly int Bitrate;
        /// <summary>
        /// The audio codec.If `Container` is `mp3`, the valid value is:`libmp3lame`If `Container` is `ogg` or `flac`, the valid value is:`flac`If `Container` is `m4a`, the valid values are:`libfdk_aac``libmp3lame``ac3`If `Container` is `mp4` or `flv`, the valid values are:`libfdk_aac` (Recommended for MP4)`libmp3lame` (Recommended for FLV)`mp2`If `Container` is `hls`, the valid value is:`libfdk_aac`If `Format` is `HLS` or `MPEG-DASH`, the valid value is:`libfdk_aac`If `Container` is `wav`, the valid value is:`pcm16`.
        /// </summary>
        public readonly string Codec;
        /// <summary>
        /// The audio sample rate. Valid values:`16000` (valid only if `Codec` is `pcm16`)`32000``44100``48000`Unit: Hz.
        /// </summary>
        public readonly int SampleRate;

        [OutputConstructor]
        private TranscodeTemplateAudioTemplate(
            int? audioChannel,

            int bitrate,

            string codec,

            int sampleRate)
        {
            AudioChannel = audioChannel;
            Bitrate = bitrate;
            Codec = codec;
            SampleRate = sampleRate;
        }
    }
}