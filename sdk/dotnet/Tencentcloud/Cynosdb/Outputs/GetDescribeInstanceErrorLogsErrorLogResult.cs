// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cynosdb.Outputs
{

    [OutputType]
    public sealed class GetDescribeInstanceErrorLogsErrorLogResult
    {
        /// <summary>
        /// Note to log content: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly string Content;
        /// <summary>
        /// Log level note: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly string Level;
        /// <summary>
        /// Log timestamp note: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly int Timestamp;

        [OutputConstructor]
        private GetDescribeInstanceErrorLogsErrorLogResult(
            string content,

            string level,

            int timestamp)
        {
            Content = content;
            Level = level;
            Timestamp = timestamp;
        }
    }
}