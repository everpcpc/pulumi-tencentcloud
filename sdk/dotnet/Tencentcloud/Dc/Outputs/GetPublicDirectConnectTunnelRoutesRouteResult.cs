// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dc.Outputs
{

    [OutputType]
    public sealed class GetPublicDirectConnectTunnelRoutesRouteResult
    {
        /// <summary>
        /// ASPath info.
        /// </summary>
        public readonly ImmutableArray<string> AsPaths;
        /// <summary>
        /// Network CIDR.
        /// </summary>
        public readonly string DestinationCidrBlock;
        /// <summary>
        /// Route next hop ip.
        /// </summary>
        public readonly string NextHop;
        /// <summary>
        /// direct connect tunnel route id.
        /// </summary>
        public readonly string RouteId;
        /// <summary>
        /// Route type: BGP/STATIC route.
        /// </summary>
        public readonly string RouteType;
        /// <summary>
        /// ENABLE: routing is enabled, DISABLE: routing is disabled.
        /// </summary>
        public readonly string Status;

        [OutputConstructor]
        private GetPublicDirectConnectTunnelRoutesRouteResult(
            ImmutableArray<string> asPaths,

            string destinationCidrBlock,

            string nextHop,

            string routeId,

            string routeType,

            string status)
        {
            AsPaths = asPaths;
            DestinationCidrBlock = destinationCidrBlock;
            NextHop = nextHop;
            RouteId = routeId;
            RouteType = routeType;
            Status = status;
        }
    }
}
