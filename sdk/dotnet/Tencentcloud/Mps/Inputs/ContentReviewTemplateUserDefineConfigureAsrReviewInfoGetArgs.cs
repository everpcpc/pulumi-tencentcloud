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

    public sealed class ContentReviewTemplateUserDefineConfigureAsrReviewInfoGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The score threshold for judging suspected violations. When the smart review reaches the score above, it is considered suspected violations. If it is not filled, the default is 100 points. Value range: 0~100.
        /// </summary>
        [Input("blockConfidence")]
        public Input<int>? BlockConfidence { get; set; }

        [Input("labelSets")]
        private InputList<string>? _labelSets;

        /// <summary>
        /// User-defined asr tags, the review result contains the selected tag and returns the result, if the filter tag is empty, all review results are returned. If you want to use the tag filtering function, when adding a asr library, you need to add the corresponding character tag.The maximum number of tags is 10, and the length of each tag is up to 16 characters.
        /// </summary>
        public InputList<string> LabelSets
        {
            get => _labelSets ?? (_labelSets = new InputList<string>());
            set => _labelSets = value;
        }

        /// <summary>
        /// The score threshold for judging whether manual review is required for violations. When the intelligent review reaches the score above, it is considered that manual review is required. If it is not filled, the default is 75 points. Value range: 0~100.
        /// </summary>
        [Input("reviewConfidence")]
        public Input<int>? ReviewConfidence { get; set; }

        /// <summary>
        /// User-defined asr review task switch, optional value:ON/OFF.
        /// </summary>
        [Input("switch", required: true)]
        public Input<string> Switch { get; set; } = null!;

        public ContentReviewTemplateUserDefineConfigureAsrReviewInfoGetArgs()
        {
        }
        public static new ContentReviewTemplateUserDefineConfigureAsrReviewInfoGetArgs Empty => new ContentReviewTemplateUserDefineConfigureAsrReviewInfoGetArgs();
    }
}