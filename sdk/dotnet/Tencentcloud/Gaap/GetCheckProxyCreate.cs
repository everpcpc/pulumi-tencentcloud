// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Gaap
{
    public static class GetCheckProxyCreate
    {
        /// <summary>
        /// Use this data source to query detailed information of gaap check proxy create
        /// </summary>
        public static Task<GetCheckProxyCreateResult> InvokeAsync(GetCheckProxyCreateArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetCheckProxyCreateResult>("tencentcloud:Gaap/getCheckProxyCreate:getCheckProxyCreate", args ?? new GetCheckProxyCreateArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of gaap check proxy create
        /// </summary>
        public static Output<GetCheckProxyCreateResult> Invoke(GetCheckProxyCreateInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetCheckProxyCreateResult>("tencentcloud:Gaap/getCheckProxyCreate:getCheckProxyCreate", args ?? new GetCheckProxyCreateInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetCheckProxyCreateArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The access (acceleration) area of the proxy. The value can be obtained through the interface DescribeAccessRegionsByDestRegion.
        /// </summary>
        [Input("accessRegion", required: true)]
        public string AccessRegion { get; set; } = null!;

        /// <summary>
        /// The upper limit of proxy bandwidth, in Mbps.
        /// </summary>
        [Input("bandwidth", required: true)]
        public int Bandwidth { get; set; }

        /// <summary>
        /// The upper limit of chanproxynel concurrency, representing the number of simultaneous online connections, in tens of thousands.
        /// </summary>
        [Input("concurrent", required: true)]
        public int Concurrent { get; set; }

        /// <summary>
        /// If creating a proxy under a proxy group, you need to fill in the ID of the proxy group.
        /// </summary>
        [Input("groupId")]
        public string? GroupId { get; set; }

        /// <summary>
        /// IP version, can be taken as IPv4 or IPv6, with a default value of IPv4.
        /// </summary>
        [Input("ipAddressVersion")]
        public string? IpAddressVersion { get; set; }

        /// <summary>
        /// Network type, can take values &amp;amp;#39;normal&amp;amp;#39;, &amp;amp;#39;cn2&amp;amp;#39;, default value normal.
        /// </summary>
        [Input("networkType")]
        public string? NetworkType { get; set; }

        /// <summary>
        /// Channel package type. Thunder represents the standard proxy group, Accelerator represents the game accelerator proxy, and CrossBorder represents the cross-border proxy.
        /// </summary>
        [Input("packageType")]
        public string? PackageType { get; set; }

        /// <summary>
        /// The origin area of the proxy. The value can be obtained through the interface DescribeDestRegions.
        /// </summary>
        [Input("realServerRegion", required: true)]
        public string RealServerRegion { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetCheckProxyCreateArgs()
        {
        }
        public static new GetCheckProxyCreateArgs Empty => new GetCheckProxyCreateArgs();
    }

    public sealed class GetCheckProxyCreateInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The access (acceleration) area of the proxy. The value can be obtained through the interface DescribeAccessRegionsByDestRegion.
        /// </summary>
        [Input("accessRegion", required: true)]
        public Input<string> AccessRegion { get; set; } = null!;

        /// <summary>
        /// The upper limit of proxy bandwidth, in Mbps.
        /// </summary>
        [Input("bandwidth", required: true)]
        public Input<int> Bandwidth { get; set; } = null!;

        /// <summary>
        /// The upper limit of chanproxynel concurrency, representing the number of simultaneous online connections, in tens of thousands.
        /// </summary>
        [Input("concurrent", required: true)]
        public Input<int> Concurrent { get; set; } = null!;

        /// <summary>
        /// If creating a proxy under a proxy group, you need to fill in the ID of the proxy group.
        /// </summary>
        [Input("groupId")]
        public Input<string>? GroupId { get; set; }

        /// <summary>
        /// IP version, can be taken as IPv4 or IPv6, with a default value of IPv4.
        /// </summary>
        [Input("ipAddressVersion")]
        public Input<string>? IpAddressVersion { get; set; }

        /// <summary>
        /// Network type, can take values &amp;amp;#39;normal&amp;amp;#39;, &amp;amp;#39;cn2&amp;amp;#39;, default value normal.
        /// </summary>
        [Input("networkType")]
        public Input<string>? NetworkType { get; set; }

        /// <summary>
        /// Channel package type. Thunder represents the standard proxy group, Accelerator represents the game accelerator proxy, and CrossBorder represents the cross-border proxy.
        /// </summary>
        [Input("packageType")]
        public Input<string>? PackageType { get; set; }

        /// <summary>
        /// The origin area of the proxy. The value can be obtained through the interface DescribeDestRegions.
        /// </summary>
        [Input("realServerRegion", required: true)]
        public Input<string> RealServerRegion { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetCheckProxyCreateInvokeArgs()
        {
        }
        public static new GetCheckProxyCreateInvokeArgs Empty => new GetCheckProxyCreateInvokeArgs();
    }


    [OutputType]
    public sealed class GetCheckProxyCreateResult
    {
        public readonly string AccessRegion;
        public readonly int Bandwidth;
        /// <summary>
        /// Query whether the proxy with the given configuration can be created, 1 can be created, 0 cannot be created.
        /// </summary>
        public readonly int CheckFlag;
        public readonly int Concurrent;
        public readonly string? GroupId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? IpAddressVersion;
        public readonly string? NetworkType;
        public readonly string? PackageType;
        public readonly string RealServerRegion;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetCheckProxyCreateResult(
            string accessRegion,

            int bandwidth,

            int checkFlag,

            int concurrent,

            string? groupId,

            string id,

            string? ipAddressVersion,

            string? networkType,

            string? packageType,

            string realServerRegion,

            string? resultOutputFile)
        {
            AccessRegion = accessRegion;
            Bandwidth = bandwidth;
            CheckFlag = checkFlag;
            Concurrent = concurrent;
            GroupId = groupId;
            Id = id;
            IpAddressVersion = ipAddressVersion;
            NetworkType = networkType;
            PackageType = packageType;
            RealServerRegion = realServerRegion;
            ResultOutputFile = resultOutputFile;
        }
    }
}