// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Lighthouse
{
    public static class GetInstanceTrafficPackage
    {
        /// <summary>
        /// Use this data source to query detailed information of lighthouse instance_traffic_package
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
        ///     var instanceTrafficPackage = Tencentcloud.Lighthouse.GetInstanceTrafficPackage.Invoke();
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetInstanceTrafficPackageResult> InvokeAsync(GetInstanceTrafficPackageArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetInstanceTrafficPackageResult>("tencentcloud:Lighthouse/getInstanceTrafficPackage:getInstanceTrafficPackage", args ?? new GetInstanceTrafficPackageArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of lighthouse instance_traffic_package
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
        ///     var instanceTrafficPackage = Tencentcloud.Lighthouse.GetInstanceTrafficPackage.Invoke();
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetInstanceTrafficPackageResult> Invoke(GetInstanceTrafficPackageInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetInstanceTrafficPackageResult>("tencentcloud:Lighthouse/getInstanceTrafficPackage:getInstanceTrafficPackage", args ?? new GetInstanceTrafficPackageInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetInstanceTrafficPackageArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceIds")]
        private List<string>? _instanceIds;

        /// <summary>
        /// Instance ID list.
        /// </summary>
        public List<string> InstanceIds
        {
            get => _instanceIds ?? (_instanceIds = new List<string>());
            set => _instanceIds = value;
        }

        /// <summary>
        /// Number of returned results. Default value is 20. Maximum value is 100.
        /// </summary>
        [Input("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Offset. Default value is 0.
        /// </summary>
        [Input("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetInstanceTrafficPackageArgs()
        {
        }
        public static new GetInstanceTrafficPackageArgs Empty => new GetInstanceTrafficPackageArgs();
    }

    public sealed class GetInstanceTrafficPackageInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceIds")]
        private InputList<string>? _instanceIds;

        /// <summary>
        /// Instance ID list.
        /// </summary>
        public InputList<string> InstanceIds
        {
            get => _instanceIds ?? (_instanceIds = new InputList<string>());
            set => _instanceIds = value;
        }

        /// <summary>
        /// Number of returned results. Default value is 20. Maximum value is 100.
        /// </summary>
        [Input("limit")]
        public Input<int>? Limit { get; set; }

        /// <summary>
        /// Offset. Default value is 0.
        /// </summary>
        [Input("offset")]
        public Input<int>? Offset { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetInstanceTrafficPackageInvokeArgs()
        {
        }
        public static new GetInstanceTrafficPackageInvokeArgs Empty => new GetInstanceTrafficPackageInvokeArgs();
    }


    [OutputType]
    public sealed class GetInstanceTrafficPackageResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<string> InstanceIds;
        /// <summary>
        /// List of details of instance traffic packages.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetInstanceTrafficPackageInstanceTrafficPackageSetResult> InstanceTrafficPackageSets;
        public readonly int? Limit;
        public readonly int? Offset;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetInstanceTrafficPackageResult(
            string id,

            ImmutableArray<string> instanceIds,

            ImmutableArray<Outputs.GetInstanceTrafficPackageInstanceTrafficPackageSetResult> instanceTrafficPackageSets,

            int? limit,

            int? offset,

            string? resultOutputFile)
        {
            Id = id;
            InstanceIds = instanceIds;
            InstanceTrafficPackageSets = instanceTrafficPackageSets;
            Limit = limit;
            Offset = offset;
            ResultOutputFile = resultOutputFile;
        }
    }
}