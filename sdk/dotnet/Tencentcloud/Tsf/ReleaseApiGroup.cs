// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tsf
{
    /// <summary>
    /// Provides a resource to create a tsf release_api_group
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
    ///     var releaseApiGroup = new Tencentcloud.Tsf.ReleaseApiGroup("releaseApiGroup", new()
    ///     {
    ///         GroupId = "grp-qp0rj3zi",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Tsf/releaseApiGroup:ReleaseApiGroup")]
    public partial class ReleaseApiGroup : global::Pulumi.CustomResource
    {
        /// <summary>
        /// api group Id.
        /// </summary>
        [Output("groupId")]
        public Output<string> GroupId { get; private set; } = null!;


        /// <summary>
        /// Create a ReleaseApiGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ReleaseApiGroup(string name, ReleaseApiGroupArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Tsf/releaseApiGroup:ReleaseApiGroup", name, args ?? new ReleaseApiGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ReleaseApiGroup(string name, Input<string> id, ReleaseApiGroupState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Tsf/releaseApiGroup:ReleaseApiGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ReleaseApiGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ReleaseApiGroup Get(string name, Input<string> id, ReleaseApiGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new ReleaseApiGroup(name, id, state, options);
        }
    }

    public sealed class ReleaseApiGroupArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// api group Id.
        /// </summary>
        [Input("groupId", required: true)]
        public Input<string> GroupId { get; set; } = null!;

        public ReleaseApiGroupArgs()
        {
        }
        public static new ReleaseApiGroupArgs Empty => new ReleaseApiGroupArgs();
    }

    public sealed class ReleaseApiGroupState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// api group Id.
        /// </summary>
        [Input("groupId")]
        public Input<string>? GroupId { get; set; }

        public ReleaseApiGroupState()
        {
        }
        public static new ReleaseApiGroupState Empty => new ReleaseApiGroupState();
    }
}
