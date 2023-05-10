// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ci.Outputs
{

    [OutputType]
    public sealed class MediaPicProcessTemplatePicProcess
    {
        /// <summary>
        /// Whether to return the original image information.
        /// </summary>
        public readonly string? IsPicInfo;
        /// <summary>
        /// Image processing rules, 1: basic image processing, please refer to the basic image processing document, 2: image compression, please refer to the image compression document, 3: blind watermark, please refer to the blind watermark document.
        /// </summary>
        public readonly string ProcessRule;

        [OutputConstructor]
        private MediaPicProcessTemplatePicProcess(
            string? isPicInfo,

            string processRule)
        {
            IsPicInfo = isPicInfo;
            ProcessRule = processRule;
        }
    }
}