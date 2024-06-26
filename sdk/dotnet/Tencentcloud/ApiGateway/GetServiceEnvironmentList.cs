// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.ApiGateway
{
    public static class GetServiceEnvironmentList
    {
        /// <summary>
        /// Use this data source to query detailed information of apiGateway service_environment_list
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
        ///         var example = Output.Create(Tencentcloud.ApiGateway.GetServiceEnvironmentList.InvokeAsync(new Tencentcloud.ApiGateway.GetServiceEnvironmentListArgs
        ///         {
        ///             ServiceId = "service-nxz6yync",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetServiceEnvironmentListResult> InvokeAsync(GetServiceEnvironmentListArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetServiceEnvironmentListResult>("tencentcloud:ApiGateway/getServiceEnvironmentList:getServiceEnvironmentList", args ?? new GetServiceEnvironmentListArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of apiGateway service_environment_list
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
        ///         var example = Output.Create(Tencentcloud.ApiGateway.GetServiceEnvironmentList.InvokeAsync(new Tencentcloud.ApiGateway.GetServiceEnvironmentListArgs
        ///         {
        ///             ServiceId = "service-nxz6yync",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetServiceEnvironmentListResult> Invoke(GetServiceEnvironmentListInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetServiceEnvironmentListResult>("tencentcloud:ApiGateway/getServiceEnvironmentList:getServiceEnvironmentList", args ?? new GetServiceEnvironmentListInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetServiceEnvironmentListArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// The unique ID of the service to be queried.
        /// </summary>
        [Input("serviceId", required: true)]
        public string ServiceId { get; set; } = null!;

        public GetServiceEnvironmentListArgs()
        {
        }
    }

    public sealed class GetServiceEnvironmentListInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// The unique ID of the service to be queried.
        /// </summary>
        [Input("serviceId", required: true)]
        public Input<string> ServiceId { get; set; } = null!;

        public GetServiceEnvironmentListInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetServiceEnvironmentListResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// Service binding environment details.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetServiceEnvironmentListResultResult> Results;
        public readonly string ServiceId;

        [OutputConstructor]
        private GetServiceEnvironmentListResult(
            string id,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetServiceEnvironmentListResultResult> results,

            string serviceId)
        {
            Id = id;
            ResultOutputFile = resultOutputFile;
            Results = results;
            ServiceId = serviceId;
        }
    }
}
