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

    public sealed class ContentReviewTemplateProhibitedConfigureGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Voice Prohibition Control Parameters.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [Input("asrReviewInfo")]
        public Input<Inputs.ContentReviewTemplateProhibitedConfigureAsrReviewInfoGetArgs>? AsrReviewInfo { get; set; }

        /// <summary>
        /// Ocr Prohibition Control Parameters.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [Input("ocrReviewInfo")]
        public Input<Inputs.ContentReviewTemplateProhibitedConfigureOcrReviewInfoGetArgs>? OcrReviewInfo { get; set; }

        public ContentReviewTemplateProhibitedConfigureGetArgs()
        {
        }
        public static new ContentReviewTemplateProhibitedConfigureGetArgs Empty => new ContentReviewTemplateProhibitedConfigureGetArgs();
    }
}