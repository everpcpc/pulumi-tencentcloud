// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cynosdb
{
    /// <summary>
    /// Provides a resource to create a cynosdb instance_param
    /// 
    /// ## Example Usage
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var instanceParam = new Tencentcloud.Cynosdb.InstanceParam("instanceParam", new()
    ///     {
    ///         ClusterId = "cynosdbmysql-bws8h88b",
    ///         InstanceId = "cynosdbmysql-ins-rikr6z4o",
    ///         InstanceParamLists = new[]
    ///         {
    ///             new Tencentcloud.Cynosdb.Inputs.InstanceParamInstanceParamListArgs
    ///             {
    ///                 CurrentValue = "0",
    ///                 ParamName = "init_connect",
    ///             },
    ///         },
    ///         IsInMaintainPeriod = "no",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Cynosdb/instanceParam:InstanceParam")]
    public partial class InstanceParam : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Cluster ID.
        /// </summary>
        [Output("clusterId")]
        public Output<string> ClusterId { get; private set; } = null!;

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Output("instanceId")]
        public Output<string?> InstanceId { get; private set; } = null!;

        /// <summary>
        /// Instance parameter list.
        /// </summary>
        [Output("instanceParamLists")]
        public Output<ImmutableArray<Outputs.InstanceParamInstanceParamList>> InstanceParamLists { get; private set; } = null!;

        /// <summary>
        /// Yes: modify within the operation and maintenance time window, no: execute immediately (default value).
        /// </summary>
        [Output("isInMaintainPeriod")]
        public Output<string?> IsInMaintainPeriod { get; private set; } = null!;


        /// <summary>
        /// Create a InstanceParam resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public InstanceParam(string name, InstanceParamArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Cynosdb/instanceParam:InstanceParam", name, args ?? new InstanceParamArgs(), MakeResourceOptions(options, ""))
        {
        }

        private InstanceParam(string name, Input<string> id, InstanceParamState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Cynosdb/instanceParam:InstanceParam", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/tencentcloudstack",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing InstanceParam resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static InstanceParam Get(string name, Input<string> id, InstanceParamState? state = null, CustomResourceOptions? options = null)
        {
            return new InstanceParam(name, id, state, options);
        }
    }

    public sealed class InstanceParamArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Cluster ID.
        /// </summary>
        [Input("clusterId", required: true)]
        public Input<string> ClusterId { get; set; } = null!;

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        [Input("instanceParamLists")]
        private InputList<Inputs.InstanceParamInstanceParamListArgs>? _instanceParamLists;

        /// <summary>
        /// Instance parameter list.
        /// </summary>
        public InputList<Inputs.InstanceParamInstanceParamListArgs> InstanceParamLists
        {
            get => _instanceParamLists ?? (_instanceParamLists = new InputList<Inputs.InstanceParamInstanceParamListArgs>());
            set => _instanceParamLists = value;
        }

        /// <summary>
        /// Yes: modify within the operation and maintenance time window, no: execute immediately (default value).
        /// </summary>
        [Input("isInMaintainPeriod")]
        public Input<string>? IsInMaintainPeriod { get; set; }

        public InstanceParamArgs()
        {
        }
        public static new InstanceParamArgs Empty => new InstanceParamArgs();
    }

    public sealed class InstanceParamState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Cluster ID.
        /// </summary>
        [Input("clusterId")]
        public Input<string>? ClusterId { get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        [Input("instanceParamLists")]
        private InputList<Inputs.InstanceParamInstanceParamListGetArgs>? _instanceParamLists;

        /// <summary>
        /// Instance parameter list.
        /// </summary>
        public InputList<Inputs.InstanceParamInstanceParamListGetArgs> InstanceParamLists
        {
            get => _instanceParamLists ?? (_instanceParamLists = new InputList<Inputs.InstanceParamInstanceParamListGetArgs>());
            set => _instanceParamLists = value;
        }

        /// <summary>
        /// Yes: modify within the operation and maintenance time window, no: execute immediately (default value).
        /// </summary>
        [Input("isInMaintainPeriod")]
        public Input<string>? IsInMaintainPeriod { get; set; }

        public InstanceParamState()
        {
        }
        public static new InstanceParamState Empty => new InstanceParamState();
    }
}