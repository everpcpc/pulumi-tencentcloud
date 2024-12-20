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

    public sealed class TranscodeTemplateEnhanceConfigArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Video Enhancement Configuration.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [Input("videoEnhance")]
        public Input<Inputs.TranscodeTemplateEnhanceConfigVideoEnhanceArgs>? VideoEnhance { get; set; }

        public TranscodeTemplateEnhanceConfigArgs()
        {
        }
        public static new TranscodeTemplateEnhanceConfigArgs Empty => new TranscodeTemplateEnhanceConfigArgs();
    }
}
