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

    public sealed class ProcessMediaOperationMediaProcessTaskTranscodeTaskSetRawParameterAudioTemplateGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Audio channel system. Valid values:1: Mono2: Dual6: StereoWhen the media is packaged in audio format (FLAC, OGG, MP3, M4A), the sound channel cannot be set to stereo.Default value: 2.
        /// </summary>
        [Input("audioChannel")]
        public Input<int>? AudioChannel { get; set; }

        /// <summary>
        /// Audio stream bitrate in Kbps. Value range: 0 and [26, 256].If the value is 0, the bitrate of the audio stream will be the same as that of the original audio.
        /// </summary>
        [Input("bitrate", required: true)]
        public Input<int> Bitrate { get; set; } = null!;

        /// <summary>
        /// Audio stream codec.When the outer `Container` parameter is `mp3`, the valid value is:libmp3lame.When the outer `Container` parameter is `ogg` or `flac`, the valid value is:flac.When the outer `Container` parameter is `m4a`, the valid values include:libfdk_aac;libmp3lame;ac3.When the outer `Container` parameter is `mp4` or `flv`, the valid values include:libfdk_aac: more suitable for mp4;libmp3lame: more suitable for flv.When the outer `Container` parameter is `hls`, the valid values include:libfdk_aac;libmp3lame.
        /// </summary>
        [Input("codec", required: true)]
        public Input<string> Codec { get; set; } = null!;

        /// <summary>
        /// Audio stream sample rate. Valid values:32,00044,10048,000In Hz.
        /// </summary>
        [Input("sampleRate", required: true)]
        public Input<int> SampleRate { get; set; } = null!;

        public ProcessMediaOperationMediaProcessTaskTranscodeTaskSetRawParameterAudioTemplateGetArgs()
        {
        }
        public static new ProcessMediaOperationMediaProcessTaskTranscodeTaskSetRawParameterAudioTemplateGetArgs Empty => new ProcessMediaOperationMediaProcessTaskTranscodeTaskSetRawParameterAudioTemplateGetArgs();
    }
}