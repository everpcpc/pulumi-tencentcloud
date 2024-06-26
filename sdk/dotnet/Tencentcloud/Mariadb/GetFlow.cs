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
    public static class GetFlow
    {
        /// <summary>
        /// Use this data source to query detailed information of mariadb flow
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
        ///         var flow = Output.Create(Tencentcloud.Mariadb.GetFlow.InvokeAsync(new Tencentcloud.Mariadb.GetFlowArgs
        ///         {
        ///             FlowId = 1307,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetFlowResult> InvokeAsync(GetFlowArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetFlowResult>("tencentcloud:Mariadb/getFlow:getFlow", args ?? new GetFlowArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of mariadb flow
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
        ///         var flow = Output.Create(Tencentcloud.Mariadb.GetFlow.InvokeAsync(new Tencentcloud.Mariadb.GetFlowArgs
        ///         {
        ///             FlowId = 1307,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetFlowResult> Invoke(GetFlowInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetFlowResult>("tencentcloud:Mariadb/getFlow:getFlow", args ?? new GetFlowInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetFlowArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Flow ID returned by async request API.
        /// </summary>
        [Input("flowId", required: true)]
        public int FlowId { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetFlowArgs()
        {
        }
    }

    public sealed class GetFlowInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Flow ID returned by async request API.
        /// </summary>
        [Input("flowId", required: true)]
        public Input<int> FlowId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetFlowInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetFlowResult
    {
        public readonly int FlowId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// Flow status. 0: succeeded, 1: failed, 2: running.
        /// </summary>
        public readonly int Status;

        [OutputConstructor]
        private GetFlowResult(
            int flowId,

            string id,

            string? resultOutputFile,

            int status)
        {
            FlowId = flowId;
            Id = id;
            ResultOutputFile = resultOutputFile;
            Status = status;
        }
    }
}
