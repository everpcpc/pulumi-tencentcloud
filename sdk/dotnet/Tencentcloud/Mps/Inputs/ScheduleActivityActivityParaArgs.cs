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

    public sealed class ScheduleActivityActivityParaArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// An adaptive bitrate streaming task.
        /// </summary>
        [Input("adaptiveDynamicStreamingTask")]
        public Input<Inputs.ScheduleActivityActivityParaAdaptiveDynamicStreamingTaskArgs>? AdaptiveDynamicStreamingTask { get; set; }

        /// <summary>
        /// A content analysis task.
        /// </summary>
        [Input("aiAnalysisTask")]
        public Input<Inputs.ScheduleActivityActivityParaAiAnalysisTaskArgs>? AiAnalysisTask { get; set; }

        /// <summary>
        /// A content moderation task.
        /// </summary>
        [Input("aiContentReviewTask")]
        public Input<Inputs.ScheduleActivityActivityParaAiContentReviewTaskArgs>? AiContentReviewTask { get; set; }

        /// <summary>
        /// A content recognition task.
        /// </summary>
        [Input("aiRecognitionTask")]
        public Input<Inputs.ScheduleActivityActivityParaAiRecognitionTaskArgs>? AiRecognitionTask { get; set; }

        /// <summary>
        /// An animated screenshot generation task.
        /// </summary>
        [Input("animatedGraphicTask")]
        public Input<Inputs.ScheduleActivityActivityParaAnimatedGraphicTaskArgs>? AnimatedGraphicTask { get; set; }

        /// <summary>
        /// An image sprite generation task.
        /// </summary>
        [Input("imageSpriteTask")]
        public Input<Inputs.ScheduleActivityActivityParaImageSpriteTaskArgs>? ImageSpriteTask { get; set; }

        /// <summary>
        /// A sampled screencapturing task.
        /// </summary>
        [Input("sampleSnapshotTask")]
        public Input<Inputs.ScheduleActivityActivityParaSampleSnapshotTaskArgs>? SampleSnapshotTask { get; set; }

        /// <summary>
        /// A time point screencapturing task.
        /// </summary>
        [Input("snapshotByTimeOffsetTask")]
        public Input<Inputs.ScheduleActivityActivityParaSnapshotByTimeOffsetTaskArgs>? SnapshotByTimeOffsetTask { get; set; }

        /// <summary>
        /// A transcoding task.
        /// </summary>
        [Input("transcodeTask")]
        public Input<Inputs.ScheduleActivityActivityParaTranscodeTaskArgs>? TranscodeTask { get; set; }

        public ScheduleActivityActivityParaArgs()
        {
        }
        public static new ScheduleActivityActivityParaArgs Empty => new ScheduleActivityActivityParaArgs();
    }
}