// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cwp
{
    public static class GetMachinesSimple
    {
        /// <summary>
        /// Use this data source to query detailed information of cwp machines_simple
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
        ///     var example = Tencentcloud.Cwp.GetMachinesSimple.Invoke(new()
        ///     {
        ///         MachineRegion = "ap-guangzhou",
        ///         MachineType = "CVM",
        ///         ProjectIds = new[]
        ///         {
        ///             1210293,
        ///             1157652,
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// 
        /// ### Query by Keyword filter
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
        ///     var example = Tencentcloud.Cwp.GetMachinesSimple.Invoke(new()
        ///     {
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.Cwp.Inputs.GetMachinesSimpleFilterInputArgs
        ///             {
        ///                 ExactMatch = true,
        ///                 Name = "Keywords",
        ///                 Values = new[]
        ///                 {
        ///                     "tf_example",
        ///                 },
        ///             },
        ///         },
        ///         MachineRegion = "ap-guangzhou",
        ///         MachineType = "CVM",
        ///         ProjectIds = new[]
        ///         {
        ///             0,
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// 
        /// ### Query by Version filter
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
        ///     var example = Tencentcloud.Cwp.GetMachinesSimple.Invoke(new()
        ///     {
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.Cwp.Inputs.GetMachinesSimpleFilterInputArgs
        ///             {
        ///                 ExactMatch = true,
        ///                 Name = "Version",
        ///                 Values = new[]
        ///                 {
        ///                     "BASIC_VERSION",
        ///                 },
        ///             },
        ///         },
        ///         MachineRegion = "ap-guangzhou",
        ///         MachineType = "CVM",
        ///         ProjectIds = new[]
        ///         {
        ///             0,
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// 
        /// ### Query by TagId filter
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
        ///     var example = Tencentcloud.Cwp.GetMachinesSimple.Invoke(new()
        ///     {
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.Cwp.Inputs.GetMachinesSimpleFilterInputArgs
        ///             {
        ///                 ExactMatch = true,
        ///                 Name = "TagId",
        ///                 Values = new[]
        ///                 {
        ///                     "13771",
        ///                 },
        ///             },
        ///         },
        ///         MachineRegion = "all-regions",
        ///         MachineType = "ALL",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetMachinesSimpleResult> InvokeAsync(GetMachinesSimpleArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetMachinesSimpleResult>("tencentcloud:Cwp/getMachinesSimple:getMachinesSimple", args ?? new GetMachinesSimpleArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of cwp machines_simple
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
        ///     var example = Tencentcloud.Cwp.GetMachinesSimple.Invoke(new()
        ///     {
        ///         MachineRegion = "ap-guangzhou",
        ///         MachineType = "CVM",
        ///         ProjectIds = new[]
        ///         {
        ///             1210293,
        ///             1157652,
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// 
        /// ### Query by Keyword filter
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
        ///     var example = Tencentcloud.Cwp.GetMachinesSimple.Invoke(new()
        ///     {
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.Cwp.Inputs.GetMachinesSimpleFilterInputArgs
        ///             {
        ///                 ExactMatch = true,
        ///                 Name = "Keywords",
        ///                 Values = new[]
        ///                 {
        ///                     "tf_example",
        ///                 },
        ///             },
        ///         },
        ///         MachineRegion = "ap-guangzhou",
        ///         MachineType = "CVM",
        ///         ProjectIds = new[]
        ///         {
        ///             0,
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// 
        /// ### Query by Version filter
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
        ///     var example = Tencentcloud.Cwp.GetMachinesSimple.Invoke(new()
        ///     {
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.Cwp.Inputs.GetMachinesSimpleFilterInputArgs
        ///             {
        ///                 ExactMatch = true,
        ///                 Name = "Version",
        ///                 Values = new[]
        ///                 {
        ///                     "BASIC_VERSION",
        ///                 },
        ///             },
        ///         },
        ///         MachineRegion = "ap-guangzhou",
        ///         MachineType = "CVM",
        ///         ProjectIds = new[]
        ///         {
        ///             0,
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// 
        /// ### Query by TagId filter
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
        ///     var example = Tencentcloud.Cwp.GetMachinesSimple.Invoke(new()
        ///     {
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.Cwp.Inputs.GetMachinesSimpleFilterInputArgs
        ///             {
        ///                 ExactMatch = true,
        ///                 Name = "TagId",
        ///                 Values = new[]
        ///                 {
        ///                     "13771",
        ///                 },
        ///             },
        ///         },
        ///         MachineRegion = "all-regions",
        ///         MachineType = "ALL",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetMachinesSimpleResult> Invoke(GetMachinesSimpleInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetMachinesSimpleResult>("tencentcloud:Cwp/getMachinesSimple:getMachinesSimple", args ?? new GetMachinesSimpleInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetMachinesSimpleArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetMachinesSimpleFilterArgs>? _filters;

        /// <summary>
        /// filter list.
        /// </summary>
        public List<Inputs.GetMachinesSimpleFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetMachinesSimpleFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// The area where the machine belongs,Such as: ap-guangzhou, ap-shanghai, all-regions: All server region types.
        /// </summary>
        [Input("machineRegion", required: true)]
        public string MachineRegion { get; set; } = null!;

        /// <summary>
        /// Service types. -CVM: Cloud Virtual Machine; -ECM: Edge Computing Machine; -LH: Lighthouse; -Other: Mixed cloud; -ALL: All server types.
        /// </summary>
        [Input("machineType", required: true)]
        public string MachineType { get; set; } = null!;

        [Input("projectIds")]
        private List<int>? _projectIds;

        /// <summary>
        /// Project id list.
        /// </summary>
        public List<int> ProjectIds
        {
            get => _projectIds ?? (_projectIds = new List<int>());
            set => _projectIds = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetMachinesSimpleArgs()
        {
        }
        public static new GetMachinesSimpleArgs Empty => new GetMachinesSimpleArgs();
    }

    public sealed class GetMachinesSimpleInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetMachinesSimpleFilterInputArgs>? _filters;

        /// <summary>
        /// filter list.
        /// </summary>
        public InputList<Inputs.GetMachinesSimpleFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetMachinesSimpleFilterInputArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// The area where the machine belongs,Such as: ap-guangzhou, ap-shanghai, all-regions: All server region types.
        /// </summary>
        [Input("machineRegion", required: true)]
        public Input<string> MachineRegion { get; set; } = null!;

        /// <summary>
        /// Service types. -CVM: Cloud Virtual Machine; -ECM: Edge Computing Machine; -LH: Lighthouse; -Other: Mixed cloud; -ALL: All server types.
        /// </summary>
        [Input("machineType", required: true)]
        public Input<string> MachineType { get; set; } = null!;

        [Input("projectIds")]
        private InputList<int>? _projectIds;

        /// <summary>
        /// Project id list.
        /// </summary>
        public InputList<int> ProjectIds
        {
            get => _projectIds ?? (_projectIds = new InputList<int>());
            set => _projectIds = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetMachinesSimpleInvokeArgs()
        {
        }
        public static new GetMachinesSimpleInvokeArgs Empty => new GetMachinesSimpleInvokeArgs();
    }


    [OutputType]
    public sealed class GetMachinesSimpleResult
    {
        public readonly ImmutableArray<Outputs.GetMachinesSimpleFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string MachineRegion;
        /// <summary>
        /// Service types. -CVM: Cloud Virtual Machine; -ECM: Edge Computing Machine -LH: Lighthouse; -Other: Mixed cloud; -ALL: All server types.
        /// </summary>
        public readonly string MachineType;
        /// <summary>
        /// Machine list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMachinesSimpleMachineResult> Machines;
        public readonly ImmutableArray<int> ProjectIds;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetMachinesSimpleResult(
            ImmutableArray<Outputs.GetMachinesSimpleFilterResult> filters,

            string id,

            string machineRegion,

            string machineType,

            ImmutableArray<Outputs.GetMachinesSimpleMachineResult> machines,

            ImmutableArray<int> projectIds,

            string? resultOutputFile)
        {
            Filters = filters;
            Id = id;
            MachineRegion = machineRegion;
            MachineType = machineType;
            Machines = machines;
            ProjectIds = projectIds;
            ResultOutputFile = resultOutputFile;
        }
    }
}