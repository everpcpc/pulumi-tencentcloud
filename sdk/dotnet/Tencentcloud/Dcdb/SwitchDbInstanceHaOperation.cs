// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dcdb
{
    /// <summary>
    /// Provides a resource to create a dcdb switch_db_instance_ha_operation
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
    ///     var switchOperation = new Tencentcloud.Dcdb.SwitchDbInstanceHaOperation("switchOperation", new()
    ///     {
    ///         InstanceId = local.Dcdb_id,
    ///         Zone = "ap-guangzhou-4",
    ///     });
    /// 
    ///     //3 to 4
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Dcdb/switchDbInstanceHaOperation:SwitchDbInstanceHaOperation")]
    public partial class SwitchDbInstanceHaOperation : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Instance ID in the format of tdsqlshard-ow728lmc.
        /// </summary>
        [Output("instanceId")]
        public Output<string> InstanceId { get; private set; } = null!;

        /// <summary>
        /// Target AZ. The node with the lowest delay in the target AZ will be automatically promoted to primary node.
        /// </summary>
        [Output("zone")]
        public Output<string> Zone { get; private set; } = null!;


        /// <summary>
        /// Create a SwitchDbInstanceHaOperation resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SwitchDbInstanceHaOperation(string name, SwitchDbInstanceHaOperationArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Dcdb/switchDbInstanceHaOperation:SwitchDbInstanceHaOperation", name, args ?? new SwitchDbInstanceHaOperationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SwitchDbInstanceHaOperation(string name, Input<string> id, SwitchDbInstanceHaOperationState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Dcdb/switchDbInstanceHaOperation:SwitchDbInstanceHaOperation", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SwitchDbInstanceHaOperation resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SwitchDbInstanceHaOperation Get(string name, Input<string> id, SwitchDbInstanceHaOperationState? state = null, CustomResourceOptions? options = null)
        {
            return new SwitchDbInstanceHaOperation(name, id, state, options);
        }
    }

    public sealed class SwitchDbInstanceHaOperationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Instance ID in the format of tdsqlshard-ow728lmc.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Target AZ. The node with the lowest delay in the target AZ will be automatically promoted to primary node.
        /// </summary>
        [Input("zone", required: true)]
        public Input<string> Zone { get; set; } = null!;

        public SwitchDbInstanceHaOperationArgs()
        {
        }
        public static new SwitchDbInstanceHaOperationArgs Empty => new SwitchDbInstanceHaOperationArgs();
    }

    public sealed class SwitchDbInstanceHaOperationState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Instance ID in the format of tdsqlshard-ow728lmc.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        /// <summary>
        /// Target AZ. The node with the lowest delay in the target AZ will be automatically promoted to primary node.
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public SwitchDbInstanceHaOperationState()
        {
        }
        public static new SwitchDbInstanceHaOperationState Empty => new SwitchDbInstanceHaOperationState();
    }
}