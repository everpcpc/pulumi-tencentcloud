// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ckafka.Outputs
{

    [OutputType]
    public sealed class DatahubTaskTransformsParamBatchAnalyse
    {
        /// <summary>
        /// ONE BY ONE single output, MERGE combined output.
        /// </summary>
        public readonly string Format;

        [OutputConstructor]
        private DatahubTaskTransformsParamBatchAnalyse(string format)
        {
            Format = format;
        }
    }
}