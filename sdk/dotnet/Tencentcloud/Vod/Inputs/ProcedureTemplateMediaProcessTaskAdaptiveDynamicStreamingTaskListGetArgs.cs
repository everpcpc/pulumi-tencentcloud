// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Vod.Inputs
{

    public sealed class ProcedureTemplateMediaProcessTaskAdaptiveDynamicStreamingTaskListGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Adaptive bitrate streaming template ID.
        /// </summary>
        [Input("definition", required: true)]
        public Input<string> Definition { get; set; } = null!;

        [Input("subtitleLists")]
        private InputList<string>? _subtitleLists;

        /// <summary>
        /// Subtitle list, element is subtitle ID, support multiple subtitles, up to 16.
        /// </summary>
        public InputList<string> SubtitleLists
        {
            get => _subtitleLists ?? (_subtitleLists = new InputList<string>());
            set => _subtitleLists = value;
        }

        [Input("watermarkLists")]
        private InputList<Inputs.ProcedureTemplateMediaProcessTaskAdaptiveDynamicStreamingTaskListWatermarkListGetArgs>? _watermarkLists;

        /// <summary>
        /// List of up to `10` image or text watermarks. Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public InputList<Inputs.ProcedureTemplateMediaProcessTaskAdaptiveDynamicStreamingTaskListWatermarkListGetArgs> WatermarkLists
        {
            get => _watermarkLists ?? (_watermarkLists = new InputList<Inputs.ProcedureTemplateMediaProcessTaskAdaptiveDynamicStreamingTaskListWatermarkListGetArgs>());
            set => _watermarkLists = value;
        }

        public ProcedureTemplateMediaProcessTaskAdaptiveDynamicStreamingTaskListGetArgs()
        {
        }
        public static new ProcedureTemplateMediaProcessTaskAdaptiveDynamicStreamingTaskListGetArgs Empty => new ProcedureTemplateMediaProcessTaskAdaptiveDynamicStreamingTaskListGetArgs();
    }
}
