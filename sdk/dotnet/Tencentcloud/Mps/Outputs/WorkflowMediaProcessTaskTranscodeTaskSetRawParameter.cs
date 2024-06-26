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
    public sealed class WorkflowMediaProcessTaskTranscodeTaskSetRawParameter
    {
        /// <summary>
        /// Audio stream configuration parameters, when RemoveAudio is 0, this field is required.
        /// </summary>
        public readonly Outputs.WorkflowMediaProcessTaskTranscodeTaskSetRawParameterAudioTemplate? AudioTemplate;
        /// <summary>
        /// Encapsulation format, optional values: mp4, flv, hls, mp3, flac, ogg, m4a. Among them, mp3, flac, ogg, m4a are pure audio files.
        /// </summary>
        public readonly string Container;
        /// <summary>
        /// Whether to remove audio data, value:0: reserved.1: remove.Default: 0.
        /// </summary>
        public readonly int? RemoveAudio;
        /// <summary>
        /// Whether to remove video data, value:0: reserved.1: remove.Default: 0.
        /// </summary>
        public readonly int? RemoveVideo;
        /// <summary>
        /// Ultra-fast HD transcoding parameters.
        /// </summary>
        public readonly Outputs.WorkflowMediaProcessTaskTranscodeTaskSetRawParameterTehdConfig? TehdConfig;
        /// <summary>
        /// Video stream configuration parameters, when RemoveVideo is 0, this field is required.
        /// </summary>
        public readonly Outputs.WorkflowMediaProcessTaskTranscodeTaskSetRawParameterVideoTemplate? VideoTemplate;

        [OutputConstructor]
        private WorkflowMediaProcessTaskTranscodeTaskSetRawParameter(
            Outputs.WorkflowMediaProcessTaskTranscodeTaskSetRawParameterAudioTemplate? audioTemplate,

            string container,

            int? removeAudio,

            int? removeVideo,

            Outputs.WorkflowMediaProcessTaskTranscodeTaskSetRawParameterTehdConfig? tehdConfig,

            Outputs.WorkflowMediaProcessTaskTranscodeTaskSetRawParameterVideoTemplate? videoTemplate)
        {
            AudioTemplate = audioTemplate;
            Container = container;
            RemoveAudio = removeAudio;
            RemoveVideo = removeVideo;
            TehdConfig = tehdConfig;
            VideoTemplate = videoTemplate;
        }
    }
}
