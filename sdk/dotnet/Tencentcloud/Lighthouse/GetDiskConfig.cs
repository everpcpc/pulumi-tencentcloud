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
    public static class GetDiskConfig
    {
        /// <summary>
        /// Use this data source to query detailed information of lighthouse disk_config
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
        ///     var diskConfig = Tencentcloud.Lighthouse.GetDiskConfig.Invoke(new()
        ///     {
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.Lighthouse.Inputs.GetDiskConfigFilterInputArgs
        ///             {
        ///                 Name = "zone",
        ///                 Values = new[]
        ///                 {
        ///                     "ap-guangzhou-3",
        ///                 },
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetDiskConfigResult> InvokeAsync(GetDiskConfigArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDiskConfigResult>("tencentcloud:Lighthouse/getDiskConfig:getDiskConfig", args ?? new GetDiskConfigArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of lighthouse disk_config
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
        ///     var diskConfig = Tencentcloud.Lighthouse.GetDiskConfig.Invoke(new()
        ///     {
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.Lighthouse.Inputs.GetDiskConfigFilterInputArgs
        ///             {
        ///                 Name = "zone",
        ///                 Values = new[]
        ///                 {
        ///                     "ap-guangzhou-3",
        ///                 },
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetDiskConfigResult> Invoke(GetDiskConfigInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDiskConfigResult>("tencentcloud:Lighthouse/getDiskConfig:getDiskConfig", args ?? new GetDiskConfigInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDiskConfigArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetDiskConfigFilterArgs>? _filters;

        /// <summary>
        /// Filter list.zoneFilter by availability zone.Type: StringRequired: no.
        /// </summary>
        public List<Inputs.GetDiskConfigFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetDiskConfigFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetDiskConfigArgs()
        {
        }
        public static new GetDiskConfigArgs Empty => new GetDiskConfigArgs();
    }

    public sealed class GetDiskConfigInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetDiskConfigFilterInputArgs>? _filters;

        /// <summary>
        /// Filter list.zoneFilter by availability zone.Type: StringRequired: no.
        /// </summary>
        public InputList<Inputs.GetDiskConfigFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetDiskConfigFilterInputArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetDiskConfigInvokeArgs()
        {
        }
        public static new GetDiskConfigInvokeArgs Empty => new GetDiskConfigInvokeArgs();
    }


    [OutputType]
    public sealed class GetDiskConfigResult
    {
        /// <summary>
        /// List of cloud disk configurations.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDiskConfigDiskConfigSetResult> DiskConfigSets;
        public readonly ImmutableArray<Outputs.GetDiskConfigFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetDiskConfigResult(
            ImmutableArray<Outputs.GetDiskConfigDiskConfigSetResult> diskConfigSets,

            ImmutableArray<Outputs.GetDiskConfigFilterResult> filters,

            string id,

            string? resultOutputFile)
        {
            DiskConfigSets = diskConfigSets;
            Filters = filters;
            Id = id;
            ResultOutputFile = resultOutputFile;
        }
    }
}