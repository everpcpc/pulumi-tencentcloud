// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ckafka
{
    public static class GetConnectResource
    {
        /// <summary>
        /// Use this data source to query detailed information of ckafka connect_resource
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
        ///         var connectResource = Output.Create(Tencentcloud.Ckafka.GetConnectResource.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetConnectResourceResult> InvokeAsync(GetConnectResourceArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetConnectResourceResult>("tencentcloud:Ckafka/getConnectResource:getConnectResource", args ?? new GetConnectResourceArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of ckafka connect_resource
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
        ///         var connectResource = Output.Create(Tencentcloud.Ckafka.GetConnectResource.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetConnectResourceResult> Invoke(GetConnectResourceInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetConnectResourceResult>("tencentcloud:Ckafka/getConnectResource:getConnectResource", args ?? new GetConnectResourceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetConnectResourceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Return the number, the default is 20, the maximum is 100.
        /// </summary>
        [Input("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Page offset, default is 0.
        /// </summary>
        [Input("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Keyword query of the connection source, query the connection in the connection management list in the local region according to the region (only support the connection source containing the region input).
        /// </summary>
        [Input("resourceRegion")]
        public string? ResourceRegion { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// Keyword for search.
        /// </summary>
        [Input("searchWord")]
        public string? SearchWord { get; set; }

        /// <summary>
        /// connection source type.
        /// </summary>
        [Input("type")]
        public string? Type { get; set; }

        public GetConnectResourceArgs()
        {
        }
    }

    public sealed class GetConnectResourceInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Return the number, the default is 20, the maximum is 100.
        /// </summary>
        [Input("limit")]
        public Input<int>? Limit { get; set; }

        /// <summary>
        /// Page offset, default is 0.
        /// </summary>
        [Input("offset")]
        public Input<int>? Offset { get; set; }

        /// <summary>
        /// Keyword query of the connection source, query the connection in the connection management list in the local region according to the region (only support the connection source containing the region input).
        /// </summary>
        [Input("resourceRegion")]
        public Input<string>? ResourceRegion { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// Keyword for search.
        /// </summary>
        [Input("searchWord")]
        public Input<string>? SearchWord { get; set; }

        /// <summary>
        /// connection source type.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public GetConnectResourceInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetConnectResourceResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly int? Limit;
        public readonly int? Offset;
        public readonly string? ResourceRegion;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// Connection source list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetConnectResourceResultResult> Results;
        public readonly string? SearchWord;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private GetConnectResourceResult(
            string id,

            int? limit,

            int? offset,

            string? resourceRegion,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetConnectResourceResultResult> results,

            string? searchWord,

            string? type)
        {
            Id = id;
            Limit = limit;
            Offset = offset;
            ResourceRegion = resourceRegion;
            ResultOutputFile = resultOutputFile;
            Results = results;
            SearchWord = searchWord;
            Type = type;
        }
    }
}
