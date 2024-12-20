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
    public sealed class GetSchedulesScheduleInfoSetActivityActivityParaTranscodeTaskRawParameterResult
    {
        /// <summary>
        /// Audio stream configuration parameter. This field is required when `RemoveAudio` is 0.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSchedulesScheduleInfoSetActivityActivityParaTranscodeTaskRawParameterAudioTemplateResult> AudioTemplates;
        /// <summary>
        /// Container. Valid values: mp4; flv; hls; mp3; flac; ogg; m4a. Among them, mp3, flac, ogg, and m4a are for audio files.
        /// </summary>
        public readonly string Container;
        /// <summary>
        /// Whether to remove audio data. Valid values:0: retain;1: remove.Default value: 0.
        /// </summary>
        public readonly int RemoveAudio;
        /// <summary>
        /// Whether to remove video data. Valid values:0: retain;1: remove.Default value: 0.
        /// </summary>
        public readonly int RemoveVideo;
        /// <summary>
        /// TESHD transcoding parameter.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSchedulesScheduleInfoSetActivityActivityParaTranscodeTaskRawParameterTehdConfigResult> TehdConfigs;
        /// <summary>
        /// Video stream configuration parameter. This field is required when `RemoveVideo` is 0.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSchedulesScheduleInfoSetActivityActivityParaTranscodeTaskRawParameterVideoTemplateResult> VideoTemplates;

        [OutputConstructor]
        private GetSchedulesScheduleInfoSetActivityActivityParaTranscodeTaskRawParameterResult(
            ImmutableArray<Outputs.GetSchedulesScheduleInfoSetActivityActivityParaTranscodeTaskRawParameterAudioTemplateResult> audioTemplates,

            string container,

            int removeAudio,

            int removeVideo,

            ImmutableArray<Outputs.GetSchedulesScheduleInfoSetActivityActivityParaTranscodeTaskRawParameterTehdConfigResult> tehdConfigs,

            ImmutableArray<Outputs.GetSchedulesScheduleInfoSetActivityActivityParaTranscodeTaskRawParameterVideoTemplateResult> videoTemplates)
        {
            AudioTemplates = audioTemplates;
            Container = container;
            RemoveAudio = removeAudio;
            RemoveVideo = removeVideo;
            TehdConfigs = tehdConfigs;
            VideoTemplates = videoTemplates;
        }
    }
}
