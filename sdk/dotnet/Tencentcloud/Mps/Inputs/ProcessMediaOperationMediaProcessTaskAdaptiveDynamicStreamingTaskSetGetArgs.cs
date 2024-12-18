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

    public sealed class ProcessMediaOperationMediaProcessTaskAdaptiveDynamicStreamingTaskSetGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("addOnSubtitles")]
        private InputList<Inputs.ProcessMediaOperationMediaProcessTaskAdaptiveDynamicStreamingTaskSetAddOnSubtitleGetArgs>? _addOnSubtitles;

        /// <summary>
        /// The subtitle file to add.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public InputList<Inputs.ProcessMediaOperationMediaProcessTaskAdaptiveDynamicStreamingTaskSetAddOnSubtitleGetArgs> AddOnSubtitles
        {
            get => _addOnSubtitles ?? (_addOnSubtitles = new InputList<Inputs.ProcessMediaOperationMediaProcessTaskAdaptiveDynamicStreamingTaskSetAddOnSubtitleGetArgs>());
            set => _addOnSubtitles = value;
        }

        /// <summary>
        /// Adaptive bitrate streaming template ID.
        /// </summary>
        [Input("definition", required: true)]
        public Input<int> Definition { get; set; } = null!;

        /// <summary>
        /// The relative or absolute output path of the manifest file after being transcoded to adaptive bitrate streaming. If this parameter is left empty, a relative path in the following format will be used by default: `{inputName}_adaptiveDynamicStreaming_{definition}.{format}`.
        /// </summary>
        [Input("outputObjectPath")]
        public Input<string>? OutputObjectPath { get; set; }

        /// <summary>
        /// Target bucket of an output file after being transcoded to adaptive bitrate streaming. If this parameter is left empty, the `OutputStorage` value of the upper folder will be inherited.Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [Input("outputStorage")]
        public Input<Inputs.ProcessMediaOperationMediaProcessTaskAdaptiveDynamicStreamingTaskSetOutputStorageGetArgs>? OutputStorage { get; set; }

        /// <summary>
        /// The relative output path of the segment file after being transcoded to adaptive bitrate streaming (in HLS format only). If this parameter is left empty, a relative path in the following format will be used by default: `{inputName}_adaptiveDynamicStreaming_{definition}_{subStreamNumber}_{segmentNumber}.{format}`.
        /// </summary>
        [Input("segmentObjectName")]
        public Input<string>? SegmentObjectName { get; set; }

        /// <summary>
        /// The relative output path of the substream file after being transcoded to adaptive bitrate streaming. If this parameter is left empty, a relative path in the following format will be used by default: `{inputName}_adaptiveDynamicStreaming_{definition}_{subStreamNumber}.{format}`.
        /// </summary>
        [Input("subStreamObjectName")]
        public Input<string>? SubStreamObjectName { get; set; }

        [Input("watermarkSets")]
        private InputList<Inputs.ProcessMediaOperationMediaProcessTaskAdaptiveDynamicStreamingTaskSetWatermarkSetGetArgs>? _watermarkSets;

        /// <summary>
        /// List of up to 10 image or text watermarks.
        /// </summary>
        public InputList<Inputs.ProcessMediaOperationMediaProcessTaskAdaptiveDynamicStreamingTaskSetWatermarkSetGetArgs> WatermarkSets
        {
            get => _watermarkSets ?? (_watermarkSets = new InputList<Inputs.ProcessMediaOperationMediaProcessTaskAdaptiveDynamicStreamingTaskSetWatermarkSetGetArgs>());
            set => _watermarkSets = value;
        }

        public ProcessMediaOperationMediaProcessTaskAdaptiveDynamicStreamingTaskSetGetArgs()
        {
        }
        public static new ProcessMediaOperationMediaProcessTaskAdaptiveDynamicStreamingTaskSetGetArgs Empty => new ProcessMediaOperationMediaProcessTaskAdaptiveDynamicStreamingTaskSetGetArgs();
    }
}
