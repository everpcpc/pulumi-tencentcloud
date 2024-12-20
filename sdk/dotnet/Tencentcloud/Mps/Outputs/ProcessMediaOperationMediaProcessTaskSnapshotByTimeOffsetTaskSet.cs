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
    public sealed class ProcessMediaOperationMediaProcessTaskSnapshotByTimeOffsetTaskSet
    {
        /// <summary>
        /// ID of a time point screencapturing template.
        /// </summary>
        public readonly int Definition;
        /// <summary>
        /// List of screenshot time points in the format of `s` or `%`:If the string ends in `s`, it means that the time point is in seconds; for example, `3.5s` means that the time point is the 3.5th second;If the string ends in `%`, it means that the time point is the specified percentage of the video duration; for example, `10%` means that the time point is 10% of the video duration.
        /// </summary>
        public readonly ImmutableArray<string> ExtTimeOffsetSets;
        /// <summary>
        /// Rule of the `{number}` variable in the time point screenshot output path.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly Outputs.ProcessMediaOperationMediaProcessTaskSnapshotByTimeOffsetTaskSetObjectNumberFormat? ObjectNumberFormat;
        /// <summary>
        /// Output path to a generated time point screenshot, which can be a relative path or an absolute path. If this parameter is left empty, the following relative path will be used by default: `{inputName}_snapshotByTimeOffset_{definition}_{number}.{format}`.
        /// </summary>
        public readonly string? OutputObjectPath;
        /// <summary>
        /// Target bucket of a generated time point screenshot file. If this parameter is left empty, the `OutputStorage` value of the upper folder will be inherited.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly Outputs.ProcessMediaOperationMediaProcessTaskSnapshotByTimeOffsetTaskSetOutputStorage? OutputStorage;
        /// <summary>
        /// List of time points of screenshots in &amp;lt;font color=red&amp;gt;seconds&amp;lt;/font&amp;gt;.
        /// </summary>
        public readonly ImmutableArray<double> TimeOffsetSets;
        /// <summary>
        /// List of up to 10 image or text watermarks.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.ProcessMediaOperationMediaProcessTaskSnapshotByTimeOffsetTaskSetWatermarkSet> WatermarkSets;

        [OutputConstructor]
        private ProcessMediaOperationMediaProcessTaskSnapshotByTimeOffsetTaskSet(
            int definition,

            ImmutableArray<string> extTimeOffsetSets,

            Outputs.ProcessMediaOperationMediaProcessTaskSnapshotByTimeOffsetTaskSetObjectNumberFormat? objectNumberFormat,

            string? outputObjectPath,

            Outputs.ProcessMediaOperationMediaProcessTaskSnapshotByTimeOffsetTaskSetOutputStorage? outputStorage,

            ImmutableArray<double> timeOffsetSets,

            ImmutableArray<Outputs.ProcessMediaOperationMediaProcessTaskSnapshotByTimeOffsetTaskSetWatermarkSet> watermarkSets)
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
