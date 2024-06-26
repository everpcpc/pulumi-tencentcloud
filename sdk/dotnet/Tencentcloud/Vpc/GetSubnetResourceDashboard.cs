// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Vpc
{
    public static class GetSubnetResourceDashboard
    {
        /// <summary>
        /// Use this data source to query detailed information of vpc subnet_resource_dashboard
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var subnetResourceDashboard = Output.Create(Tencentcloud.Vpc.GetSubnetResourceDashboard.InvokeAsync(new Tencentcloud.Vpc.GetSubnetResourceDashboardArgs
        ///         {
        ///             SubnetIds = 
        ///             {
        ///                 "subnet-i9tpf6hq",
        ///             },
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetSubnetResourceDashboardResult> InvokeAsync(GetSubnetResourceDashboardArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSubnetResourceDashboardResult>("tencentcloud:Vpc/getSubnetResourceDashboard:getSubnetResourceDashboard", args ?? new GetSubnetResourceDashboardArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of vpc subnet_resource_dashboard
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var subnetResourceDashboard = Output.Create(Tencentcloud.Vpc.GetSubnetResourceDashboard.InvokeAsync(new Tencentcloud.Vpc.GetSubnetResourceDashboardArgs
        ///         {
        ///             SubnetIds = 
        ///             {
        ///                 "subnet-i9tpf6hq",
        ///             },
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetSubnetResourceDashboardResult> Invoke(GetSubnetResourceDashboardInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetSubnetResourceDashboardResult>("tencentcloud:Vpc/getSubnetResourceDashboard:getSubnetResourceDashboard", args ?? new GetSubnetResourceDashboardInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSubnetResourceDashboardArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("subnetIds", required: true)]
        private List<string>? _subnetIds;

        /// <summary>
        /// Subnet instance ID, such as `subnet-f1xjkw1b`.
        /// </summary>
        public List<string> SubnetIds
        {
            get => _subnetIds ?? (_subnetIds = new List<string>());
            set => _subnetIds = value;
        }

        public GetSubnetResourceDashboardArgs()
        {
        }
    }

    public sealed class GetSubnetResourceDashboardInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("subnetIds", required: true)]
        private InputList<string>? _subnetIds;

        /// <summary>
        /// Subnet instance ID, such as `subnet-f1xjkw1b`.
        /// </summary>
        public InputList<string> SubnetIds
        {
            get => _subnetIds ?? (_subnetIds = new InputList<string>());
            set => _subnetIds = value;
        }

        public GetSubnetResourceDashboardInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSubnetResourceDashboardResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Information of resources returned.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSubnetResourceDashboardResourceStatisticsSetResult> ResourceStatisticsSets;
        public readonly string? ResultOutputFile;
        public readonly ImmutableArray<string> SubnetIds;

        [OutputConstructor]
        private GetSubnetResourceDashboardResult(
            string id,

            ImmutableArray<Outputs.GetSubnetResourceDashboardResourceStatisticsSetResult> resourceStatisticsSets,

            string? resultOutputFile,

            ImmutableArray<string> subnetIds)
        {
            Id = id;
            ResourceStatisticsSets = resourceStatisticsSets;
            ResultOutputFile = resultOutputFile;
            SubnetIds = subnetIds;
        }
    }
}
