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
    public sealed class GetDescribeInstanceSlowQueriesBinlogResult
    {
        /// <summary>
        /// Binlog file ID.
        /// </summary>
        public readonly int BinlogId;
        /// <summary>
        /// Binlog file name.
        /// </summary>
        public readonly string FileName;
        /// <summary>
        /// File size in bytes.
        /// </summary>
        public readonly int FileSize;
        /// <summary>
        /// Latest transaction time.
        /// </summary>
        public readonly string FinishTime;
        /// <summary>
        /// start time.
        /// </summary>
        public readonly string StartTime;

        [OutputConstructor]
        private GetDescribeInstanceSlowQueriesBinlogResult(
            int binlogId,

            string fileName,

            int fileSize,

            string finishTime,

            string startTime)
        {
            BinlogId = binlogId;
            FileName = fileName;
            FileSize = fileSize;
            FinishTime = finishTime;
            StartTime = startTime;
        }
    }
}
