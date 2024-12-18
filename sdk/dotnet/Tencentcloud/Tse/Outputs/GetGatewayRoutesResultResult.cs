// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tse.Outputs
{

    [OutputType]
    public sealed class GetGatewayRoutesResultResult
    {
        /// <summary>
        /// route list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetGatewayRoutesResultRouteListResult> RouteLists;
        /// <summary>
        /// total count.
        /// </summary>
        public readonly int TotalCount;

        [OutputConstructor]
        private GetGatewayRoutesResultResult(
            ImmutableArray<Outputs.GetGatewayRoutesResultRouteListResult> routeLists,

            int totalCount)
        {
            RouteLists = routeLists;
            TotalCount = totalCount;
        }
    }
}
