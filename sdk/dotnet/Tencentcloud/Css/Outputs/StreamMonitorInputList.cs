// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Css.Outputs
{

    [OutputType]
    public sealed class StreamMonitorInputList
    {
        /// <summary>
        /// Description content.limit 256 bytes.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Wait monitor input push path.limit 32 bytes.
        /// </summary>
        public readonly string? InputApp;
        /// <summary>
        /// Wait monitor input push domain.limit 128 bytes.
        /// </summary>
        public readonly string? InputDomain;
        /// <summary>
        /// Wait monitor input stream name.limit 256 bytes.
        /// </summary>
        public readonly string InputStreamName;
        /// <summary>
        /// Wait monitor input stream push url.
        /// </summary>
        public readonly string? InputUrl;

        [OutputConstructor]
        private StreamMonitorInputList(
            string? description,

            string? inputApp,

            string? inputDomain,

            string inputStreamName,

            string? inputUrl)
        {
            Description = description;
            InputApp = inputApp;
            InputDomain = inputDomain;
            InputStreamName = inputStreamName;
            InputUrl = inputUrl;
        }
    }
}
