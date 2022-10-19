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
    public sealed class ProcedureTemplateMediaProcessTaskAnimatedGraphicTaskList
    {
        /// <summary>
        /// Animated image generating template ID.
        /// </summary>
        public readonly string Definition;
        /// <summary>
        /// End time of animated image in video in seconds.
        /// </summary>
        public readonly double EndTimeOffset;
        /// <summary>
        /// Start time of animated image in video in seconds.
        /// </summary>
        public readonly double StartTimeOffset;

        [OutputConstructor]
        private ProcedureTemplateMediaProcessTaskAnimatedGraphicTaskList(
            string definition,

            double endTimeOffset,

            double startTimeOffset)
        {
            Definition = definition;
            EndTimeOffset = endTimeOffset;
            StartTimeOffset = startTimeOffset;
        }
    }
}