// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mps.Outputs
{

    [OutputType]
    public sealed class ScheduleActivityActivityParaTranscodeTaskOutputStorage
    {
        /// <summary>
        /// The location to save the output object in COS. This parameter is valid and required when `Type` is COS.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly Outputs.ScheduleActivityActivityParaTranscodeTaskOutputStorageCosOutputStorage? CosOutputStorage;
        /// <summary>
        /// The AWS S3 bucket to save the output file. This parameter is required if `Type` is `AWS-S3`.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly Outputs.ScheduleActivityActivityParaTranscodeTaskOutputStorageS3OutputStorage? S3OutputStorage;
        /// <summary>
        /// The storage type for a media processing output file. Valid values: `COS`: Tencent Cloud COS `AWS-S3`: AWS S3. This type is only supported for AWS tasks, and the output bucket must be in the same region as the bucket of the source file.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ScheduleActivityActivityParaTranscodeTaskOutputStorage(
            Outputs.ScheduleActivityActivityParaTranscodeTaskOutputStorageCosOutputStorage? cosOutputStorage,

            Outputs.ScheduleActivityActivityParaTranscodeTaskOutputStorageS3OutputStorage? s3OutputStorage,

            string type)
        {
            CosOutputStorage = cosOutputStorage;
            S3OutputStorage = s3OutputStorage;
            Type = type;
        }
    }
}