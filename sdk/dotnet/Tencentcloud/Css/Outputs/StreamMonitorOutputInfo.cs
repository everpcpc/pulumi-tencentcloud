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
    public sealed class StreamMonitorOutputInfo
    {
        /// <summary>
        /// Monitor task play path.limit 32 bytes.
        /// </summary>
        public readonly string? OutputApp;
        /// <summary>
        /// Monitor task output play domain.limit 128 bytes.
        /// </summary>
        public readonly string? OutputDomain;
        /// <summary>
        /// Monitor task output height, limit[1, 1080].
        /// </summary>
        public readonly int OutputStreamHeight;
        /// <summary>
        /// Monitor task output stream name.limit 256 bytes.
        /// </summary>
        public readonly string? OutputStreamName;
        /// <summary>
        /// Output stream width, limit[1, 1920].
        /// </summary>
        public readonly int OutputStreamWidth;

        [OutputConstructor]
        private StreamMonitorOutputInfo(
            string? outputApp,

            string? outputDomain,

            int outputStreamHeight,

            string? outputStreamName,

            int outputStreamWidth)
        {
            OutputApp = outputApp;
            OutputDomain = outputDomain;
            OutputStreamHeight = outputStreamHeight;
            OutputStreamName = outputStreamName;
            OutputStreamWidth = outputStreamWidth;
        }
    }
}
