// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Kubernetes
{
    public static class GetClusterNodePools
    {
        /// <summary>
        /// Use this data source to query detailed information of kubernetes cluster_node_pools
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
        ///     var clusterNodePools = Tencentcloud.Kubernetes.GetClusterNodePools.Invoke(new()
        ///     {
        ///         ClusterId = "cls-kzilgv5m",
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.Kubernetes.Inputs.GetClusterNodePoolsFilterInputArgs
        ///             {
        ///                 Name = "NodePoolsName",
        ///                 Values = new[]
        ///                 {
        ///                     "mynodepool_xxxx",
        ///                 },
        ///             },
        ///             new Tencentcloud.Kubernetes.Inputs.GetClusterNodePoolsFilterInputArgs
        ///             {
        ///                 Name = "NodePoolsId",
        ///                 Values = new[]
        ///                 {
        ///                     "np-ngjwhdv4",
        ///                 },
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetClusterNodePoolsResult> InvokeAsync(GetClusterNodePoolsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetClusterNodePoolsResult>("tencentcloud:Kubernetes/getClusterNodePools:getClusterNodePools", args ?? new GetClusterNodePoolsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of kubernetes cluster_node_pools
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
        ///     var clusterNodePools = Tencentcloud.Kubernetes.GetClusterNodePools.Invoke(new()
        ///     {
        ///         ClusterId = "cls-kzilgv5m",
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.Kubernetes.Inputs.GetClusterNodePoolsFilterInputArgs
        ///             {
        ///                 Name = "NodePoolsName",
        ///                 Values = new[]
        ///                 {
        ///                     "mynodepool_xxxx",
        ///                 },
        ///             },
        ///             new Tencentcloud.Kubernetes.Inputs.GetClusterNodePoolsFilterInputArgs
        ///             {
        ///                 Name = "NodePoolsId",
        ///                 Values = new[]
        ///                 {
        ///                     "np-ngjwhdv4",
        ///                 },
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetClusterNodePoolsResult> Invoke(GetClusterNodePoolsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetClusterNodePoolsResult>("tencentcloud:Kubernetes/getClusterNodePools:getClusterNodePools", args ?? new GetClusterNodePoolsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetClusterNodePoolsArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// ID of the cluster.
        /// </summary>
        [Input("clusterId", required: true)]
        public string ClusterId { get; set; } = null!;

        [Input("filters")]
        private List<Inputs.GetClusterNodePoolsFilterArgs>? _filters;

        /// <summary>
        /// NodePoolsName, Filter according to the node pool name, type: String, required: no. NodePoolsId, Filter according to the node pool ID, type: String, required: no. tags, Filter according to the label key value pairs, type: String, required: no. tag:tag-key, Filter according to the label key value pairs, type: String, required: no.
        /// </summary>
        public List<Inputs.GetClusterNodePoolsFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetClusterNodePoolsFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetClusterNodePoolsArgs()
        {
        }
        public static new GetClusterNodePoolsArgs Empty => new GetClusterNodePoolsArgs();
    }

    public sealed class GetClusterNodePoolsInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// ID of the cluster.
        /// </summary>
        [Input("clusterId", required: true)]
        public Input<string> ClusterId { get; set; } = null!;

        [Input("filters")]
        private InputList<Inputs.GetClusterNodePoolsFilterInputArgs>? _filters;

        /// <summary>
        /// NodePoolsName, Filter according to the node pool name, type: String, required: no. NodePoolsId, Filter according to the node pool ID, type: String, required: no. tags, Filter according to the label key value pairs, type: String, required: no. tag:tag-key, Filter according to the label key value pairs, type: String, required: no.
        /// </summary>
        public InputList<Inputs.GetClusterNodePoolsFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetClusterNodePoolsFilterInputArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetClusterNodePoolsInvokeArgs()
        {
        }
        public static new GetClusterNodePoolsInvokeArgs Empty => new GetClusterNodePoolsInvokeArgs();
    }


    [OutputType]
    public sealed class GetClusterNodePoolsResult
    {
        public readonly string ClusterId;
        public readonly ImmutableArray<Outputs.GetClusterNodePoolsFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Node Pool List.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetClusterNodePoolsNodePoolSetResult> NodePoolSets;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetClusterNodePoolsResult(
            string clusterId,

            ImmutableArray<Outputs.GetClusterNodePoolsFilterResult> filters,

            string id,

            ImmutableArray<Outputs.GetClusterNodePoolsNodePoolSetResult> nodePoolSets,

            string? resultOutputFile)
        {
            ClusterId = clusterId;
            Filters = filters;
            Id = id;
            NodePoolSets = nodePoolSets;
            ResultOutputFile = resultOutputFile;
        }
    }
}