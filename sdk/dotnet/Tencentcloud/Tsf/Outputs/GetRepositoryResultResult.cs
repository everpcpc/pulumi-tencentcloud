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
    public sealed class GetRepositoryResultResult
    {
        /// <summary>
        /// Repository information list. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRepositoryResultContentResult> Contents;
        /// <summary>
        /// Total Repository.
        /// </summary>
        public readonly int TotalCount;

        [OutputConstructor]
        private GetRepositoryResultResult(
            ImmutableArray<Outputs.GetRepositoryResultContentResult> contents,

            int totalCount)
        {
            Contents = contents;
            TotalCount = totalCount;
        }
    }
}