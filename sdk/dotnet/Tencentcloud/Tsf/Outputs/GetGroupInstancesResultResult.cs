// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tsf.Outputs
{

    [OutputType]
    public sealed class GetGroupInstancesResultResult
    {
        /// <summary>
        /// List of machine instances.Note: This field may return null, which means no valid value was found.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetGroupInstancesResultContentResult> Contents;
        /// <summary>
        /// Total number of machine instances.Note: This field may return null, which means no valid value was found.
        /// </summary>
        public readonly int TotalCount;

        [OutputConstructor]
        private GetGroupInstancesResultResult(
            ImmutableArray<Outputs.GetGroupInstancesResultContentResult> contents,

            int totalCount)
        {
            Contents = contents;
            TotalCount = totalCount;
        }
    }
}