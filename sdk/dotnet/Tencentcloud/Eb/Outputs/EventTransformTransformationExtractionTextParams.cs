// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Eb.Outputs
{

    [OutputType]
    public sealed class EventTransformTransformationExtractionTextParams
    {
        /// <summary>
        /// Fill in the regular expression: length 128.
        /// </summary>
        public readonly string? Regex;
        /// <summary>
        /// `Comma`, `|`, `tab`, `space`, `newline`, `%`, `#`, the limit length is 1.
        /// </summary>
        public readonly string? Separator;

        [OutputConstructor]
        private EventTransformTransformationExtractionTextParams(
            string? regex,

            string? separator)
        {
            Regex = regex;
            Separator = separator;
        }
    }
}