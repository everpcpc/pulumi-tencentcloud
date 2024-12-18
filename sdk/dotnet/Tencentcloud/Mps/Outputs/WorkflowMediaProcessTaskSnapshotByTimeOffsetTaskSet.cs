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
    public sealed class WorkflowMediaProcessTaskSnapshotByTimeOffsetTaskSet
    {
        /// <summary>
        /// Specified time point screenshot template ID.
        /// </summary>
        public readonly int Definition;
        /// <summary>
        /// Screenshot time point list, the time point supports two formats: s and %:;When the string ends with s, it means that the time point is in seconds, such as 3.5s means that the time point is the 3.5th second.When the string ends with %, it means that the time point is the percentage of the video duration, such as 10% means that the time point is the first 10% of the time in the video.
        /// </summary>
        public readonly ImmutableArray<string> ExtTimeOffsetSets;
        /// <summary>
        /// Rules for the `{number}` variable in the output path after the screenshot at the time point.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly Outputs.WorkflowMediaProcessTaskSnapshotByTimeOffsetTaskSetObjectNumberFormat? ObjectNumberFormat;
        /// <summary>
        /// The output path of the picture file after the snapshot at the time point can be a relative path or an absolute path. If not filled, the default is a relative path: `{inputName}_snapshotByTimeOffset_{definition}_{number}.{format}`.
        /// </summary>
        public readonly string? OutputObjectPath;
        /// <summary>
        /// The target storage of the file after the screenshot at the time point, if not filled, it will inherit the OutputStorage value of the upper layer.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly Outputs.WorkflowMediaProcessTaskSnapshotByTimeOffsetTaskSetOutputStorage? OutputStorage;
        /// <summary>
        /// Screenshot time point list, the unit is &amp;lt;font color=red&amp;gt;seconds&amp;lt;/font&amp;gt;. This parameter is no longer recommended, it is recommended that you use the ExtTimeOffsetSet parameter.
        /// </summary>
        public readonly ImmutableArray<double> TimeOffsetSets;
        /// <summary>
        /// Watermark list, support multiple pictures or text watermarks, up to 10.
        /// </summary>
        public readonly ImmutableArray<Outputs.WorkflowMediaProcessTaskSnapshotByTimeOffsetTaskSetWatermarkSet> WatermarkSets;

        [OutputConstructor]
        private WorkflowMediaProcessTaskSnapshotByTimeOffsetTaskSet(
            int definition,

            ImmutableArray<string> extTimeOffsetSets,

            Outputs.WorkflowMediaProcessTaskSnapshotByTimeOffsetTaskSetObjectNumberFormat? objectNumberFormat,

            string? outputObjectPath,

            Outputs.WorkflowMediaProcessTaskSnapshotByTimeOffsetTaskSetOutputStorage? outputStorage,

            ImmutableArray<double> timeOffsetSets,

            ImmutableArray<Outputs.WorkflowMediaProcessTaskSnapshotByTimeOffsetTaskSetWatermarkSet> watermarkSets)
        {
            Definition = definition;
            ExtTimeOffsetSets = extTimeOffsetSets;
            ObjectNumberFormat = objectNumberFormat;
            OutputObjectPath = outputObjectPath;
            OutputStorage = outputStorage;
            TimeOffsetSets = timeOffsetSets;
            WatermarkSets = watermarkSets;
        }
    }
}
