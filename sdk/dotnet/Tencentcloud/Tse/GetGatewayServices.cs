// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tse
{
    public static class GetGatewayServices
    {
        /// <summary>
        /// Use this data source to query detailed information of tse gateway_services
        /// 
        /// ## Example Usage
        /// 
        /// &lt;!--Start PulumiCodeChooser --&gt;
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var gatewayServices = Tencentcloud.Tse.GetGatewayServices.Invoke(new()
        ///     {
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.Tse.Inputs.GetGatewayServicesFilterInputArgs
        ///             {
        ///                 Key = "name",
        ///                 Value = "test",
        ///             },
        ///         },
        ///         GatewayId = "gateway-ddbb709b",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetGatewayServicesResult> InvokeAsync(GetGatewayServicesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetGatewayServicesResult>("tencentcloud:Tse/getGatewayServices:getGatewayServices", args ?? new GetGatewayServicesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of tse gateway_services
        /// 
        /// ## Example Usage
        /// 
        /// &lt;!--Start PulumiCodeChooser --&gt;
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var gatewayServices = Tencentcloud.Tse.GetGatewayServices.Invoke(new()
        ///     {
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.Tse.Inputs.GetGatewayServicesFilterInputArgs
        ///             {
        ///                 Key = "name",
        ///                 Value = "test",
        ///             },
        ///         },
        ///         GatewayId = "gateway-ddbb709b",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetGatewayServicesResult> Invoke(GetGatewayServicesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetGatewayServicesResult>("tencentcloud:Tse/getGatewayServices:getGatewayServices", args ?? new GetGatewayServicesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetGatewayServicesArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetGatewayServicesFilterArgs>? _filters;

        /// <summary>
        /// filter conditions, valid value:name,upstreamType.
        /// </summary>
        public List<Inputs.GetGatewayServicesFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetGatewayServicesFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// gateway ID.
        /// </summary>
        [Input("gatewayId", required: true)]
        public string GatewayId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetGatewayServicesArgs()
        {
        }
        public static new GetGatewayServicesArgs Empty => new GetGatewayServicesArgs();
    }

    public sealed class GetGatewayServicesInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetGatewayServicesFilterInputArgs>? _filters;

        /// <summary>
        /// filter conditions, valid value:name,upstreamType.
        /// </summary>
        public InputList<Inputs.GetGatewayServicesFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetGatewayServicesFilterInputArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// gateway ID.
        /// </summary>
        [Input("gatewayId", required: true)]
        public Input<string> GatewayId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetGatewayServicesInvokeArgs()
        {
        }
        public static new GetGatewayServicesInvokeArgs Empty => new GetGatewayServicesInvokeArgs();
    }


    [OutputType]
    public sealed class GetGatewayServicesResult
    {
        public readonly ImmutableArray<Outputs.GetGatewayServicesFilterResult> Filters;
        public readonly string GatewayId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// result.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetGatewayServicesResultResult> Results;

        [OutputConstructor]
        private GetGatewayServicesResult(
            ImmutableArray<Outputs.GetGatewayServicesFilterResult> filters,

            string gatewayId,

            string id,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetGatewayServicesResultResult> results)
        {
            Filters = filters;
            GatewayId = gatewayId;
            Id = id;
            ResultOutputFile = resultOutputFile;
            Results = results;
        }
    }
}