// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mariadb
{
    public static class GetOrders
    {
        /// <summary>
        /// Use this data source to query detailed information of mariadb orders
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
        ///         var orders = Output.Create(Tencentcloud.Mariadb.GetOrders.InvokeAsync(new Tencentcloud.Mariadb.GetOrdersArgs
        ///         {
        ///             DealName = "20230607164033835942781",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetOrdersResult> InvokeAsync(GetOrdersArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetOrdersResult>("tencentcloud:Mariadb/getOrders:getOrders", args ?? new GetOrdersArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of mariadb orders
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
        ///         var orders = Output.Create(Tencentcloud.Mariadb.GetOrders.InvokeAsync(new Tencentcloud.Mariadb.GetOrdersArgs
        ///         {
        ///             DealName = "20230607164033835942781",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetOrdersResult> Invoke(GetOrdersInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetOrdersResult>("tencentcloud:Mariadb/getOrders:getOrders", args ?? new GetOrdersInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetOrdersArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// List of long order numbers to be queried, which are returned for the APIs for creating, renewing, or scaling instances.
        /// </summary>
        [Input("dealName", required: true)]
        public string DealName { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetOrdersArgs()
        {
        }
    }

    public sealed class GetOrdersInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// List of long order numbers to be queried, which are returned for the APIs for creating, renewing, or scaling instances.
        /// </summary>
        [Input("dealName", required: true)]
        public Input<string> DealName { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetOrdersInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetOrdersResult
    {
        /// <summary>
        /// Order number.
        /// </summary>
        public readonly string DealName;
        /// <summary>
        /// Order information list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetOrdersDealResult> Deals;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetOrdersResult(
            string dealName,

            ImmutableArray<Outputs.GetOrdersDealResult> deals,

            string id,

            string? resultOutputFile)
        {
            DealName = dealName;
            Deals = deals;
            Id = id;
            ResultOutputFile = resultOutputFile;
        }
    }
}
