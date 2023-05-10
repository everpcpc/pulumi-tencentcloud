// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tat.Outputs
{

    [OutputType]
    public sealed class GetInvocationTaskInvocationTaskSetCommandDocumentResult
    {
        /// <summary>
        /// Command type.
        /// </summary>
        public readonly string CommandType;
        /// <summary>
        /// Base64-encoded command.
        /// </summary>
        public readonly string Content;
        /// <summary>
        /// URL of the COS bucket to store the output.
        /// </summary>
        public readonly string OutputCosBucketUrl;
        /// <summary>
        /// Prefix of the output file name.
        /// </summary>
        public readonly string OutputCosKeyPrefix;
        /// <summary>
        /// Timeout period.
        /// </summary>
        public readonly int Timeout;
        /// <summary>
        /// The user who executes the command.
        /// </summary>
        public readonly string Username;
        /// <summary>
        /// Execution path.
        /// </summary>
        public readonly string WorkingDirectory;

        [OutputConstructor]
        private GetInvocationTaskInvocationTaskSetCommandDocumentResult(
            string commandType,

            string content,

            string outputCosBucketUrl,

            string outputCosKeyPrefix,

            int timeout,

            string username,

            string workingDirectory)
        {
            CommandType = commandType;
            Content = content;
            OutputCosBucketUrl = outputCosBucketUrl;
            OutputCosKeyPrefix = outputCosKeyPrefix;
            Timeout = timeout;
            Username = username;
            WorkingDirectory = workingDirectory;
        }
    }
}