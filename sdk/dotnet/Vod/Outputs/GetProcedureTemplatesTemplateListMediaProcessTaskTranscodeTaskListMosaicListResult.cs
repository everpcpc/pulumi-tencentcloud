// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Vod.Outputs
{

    [OutputType]
    public sealed class GetProcedureTemplatesTemplateListMediaProcessTaskTranscodeTaskListMosaicListResult
    {
        /// <summary>
        /// Origin position, which currently can only be: `TopLeft`: the origin of coordinates is in the top-left corner of the video, and the origin of the blur is in the top-left corner of the image or text.
        /// </summary>
        public readonly string CoordinateOrigin;
        /// <summary>
        /// End time offset of blur in seconds. If this parameter is left empty or `0` is entered, the blur will exist till the last video frame; If this value is greater than `0` (e.g., n), the blur will exist till second n; If this value is smaller than `0` (e.g., -n), the blur will exist till second n before the last video frame.
        /// </summary>
        public readonly double EndTimeOffset;
        /// <summary>
        /// Blur height. `%` and `px` formats are supported: If the string ends in `%`, the `height` of the blur will be the specified percentage of the video height; for example, 10% means that Height is 10% of the video height; If the string ends in `px`, the `height` of the blur will be in px; for example, 100px means that Height is 100 px.
        /// </summary>
        public readonly string Height;
        /// <summary>
        /// Start time offset of blur in seconds. If this parameter is left empty or `0` is entered, the blur will appear upon the first video frame. If this parameter is left empty or `0` is entered, the blur will appear upon the first video frame; If this value is greater than `0` (e.g., n), the blur will appear at second n after the first video frame; If this value is smaller than `0` (e.g., -n), the blur will appear at second n before the last video frame.
        /// </summary>
        public readonly double StartTimeOffset;
        /// <summary>
        /// Blur width. `%` and `px` formats are supported: If the string ends in `%`, the `width` of the blur will be the specified percentage of the video width; for example, 10% means that `width` is 10% of the video width; If the string ends in `px`, the `width` of the blur will be in px; for example, 100px means that Width is 100 px.
        /// </summary>
        public readonly string Width;
        /// <summary>
        /// The horizontal position of the origin of the blur relative to the origin of coordinates of the video. `%` and `px` formats are supported: If the string ends in `%`, the XPos of the blur will be the specified percentage of the video width; for example, 10% means that XPos is 10% of the video width; If the string ends in `px`, the XPos of the blur will be the specified px; for example, 100px means that XPos is 100 px.
        /// </summary>
        public readonly string XPos;
        /// <summary>
        /// Vertical position of the origin of blur relative to the origin of coordinates of video. `%` and `px` formats are supported: If the string ends in `%`, the YPos of the blur will be the specified percentage of the video height; for example, 10% means that YPos is 10% of the video height; If the string ends in `px`, the YPos of the blur will be the specified px; for example, 100px means that YPos is 100 px.
        /// </summary>
        public readonly string YPos;

        [OutputConstructor]
        private GetProcedureTemplatesTemplateListMediaProcessTaskTranscodeTaskListMosaicListResult(
            string coordinateOrigin,

            double endTimeOffset,

            string height,

            double startTimeOffset,

            string width,

            string xPos,

            string yPos)
        {
            CoordinateOrigin = coordinateOrigin;
            EndTimeOffset = endTimeOffset;
            Height = height;
            StartTimeOffset = startTimeOffset;
            Width = width;
            XPos = xPos;
            YPos = yPos;
        }
    }
}