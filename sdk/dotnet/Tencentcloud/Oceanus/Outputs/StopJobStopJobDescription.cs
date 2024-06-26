// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Oceanus.Outputs
{

    [OutputType]
    public sealed class StopJobStopJobDescription
    {
        /// <summary>
        /// Job Id.
        /// </summary>
        public readonly string JobId;
        /// <summary>
        /// Stop type,1 stopped 2 paused.
        /// </summary>
        public readonly int StopType;

        [OutputConstructor]
        private StopJobStopJobDescription(
            string jobId,

            int stopType)
        {
            JobId = jobId;
            StopType = stopType;
        }
    }
}
